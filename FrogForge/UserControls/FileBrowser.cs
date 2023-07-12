using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace FrogForge.UserControls
{
    public partial class FileBrowser : UserControl
    {
        public FilesController Directory;
        /// <summary>
        /// Argument 1 - File name
        /// </summary>
        public Action<string> OnFileSelected;
        public bool ShowDirectories = true;
        public string TopMostDirectory;
        public string SelectedFilename
        {
            get
            {
                return lstFiles.SelectedItem?.ToString();
            }
            set
            {
                lstFiles.SelectedItem = value;
            }
        }
        public string CurrentSubDirectory
        {
            get
            {
                if (IsAtTopMostDirectory)
                {
                    return "";
                }
                else
                {
                    return Directory.Path.Substring(TopMostDirectory.Length + 1);
                }
            }
        }
        public bool IsAtTopMostDirectory
        {
            get
            {
                return Directory.Path == TopMostDirectory;
            }
        }

        public FileBrowser()
        {
            InitializeComponent();
        }

        public void UpdateList()
        {
            List<string> items = new List<string>();
            string selectedItem = "";
            if (ShowDirectories)
            {
                if (Directory.Path != TopMostDirectory)
                {
                    items.Add("..");
                }
                items.AddRange(Directory.AllDirectories());
                for (int i = 0; i < items.Count; i++)
                {
                    items[i] = @"\" + items[i];
                }
            }
            else
            {
                selectedItem = lstFiles.SelectedItem?.ToString() ?? "";
            }
            List<string> files = new List<string>(Directory.AllFiles());
            for (int i = 0; i < files.Count; i++)
            {
                if (files[i].Substring(files[i].Length - Directory.DefultFileFormat.Length) != Directory.DefultFileFormat)
                {
                    files.RemoveAt(i);
                    i--;
                }
                else
                {
                    files[i] = files[i].Replace(Directory.DefultFileFormat, "");
                }
            }
            items.AddRange(files);
            items.Sort(CompareNatural);
            lstFiles.Items.Clear();
            lstFiles.Items.AddRange(items.ToArray());
            if (selectedItem != "")
            {
                lstFiles.SelectedItem = selectedItem;
            }
        }

        public void Navigate(string place)
        {
            if (place[0] == @"\"[0])
            {
                if (place == @"\..")
                {
                    Directory.Path = Directory.Path.Substring(0, Directory.Path.LastIndexOf(Directory.Seperator));
                }
                else
                {
                    Directory.CreateDirectory(place.Substring(1), true);
                }
                UpdateList();
            }
            else
            {
                OnFileSelected(lstFiles.SelectedItem.ToString());
                VoiceAssist.Say("Open");
            }
        }

        private void lstFiles_DoubleClick(object sender, EventArgs e)
        {
            if (lstFiles.SelectedItem == null)
            {
                return;
            }
            string item = lstFiles.SelectedItem.ToString();
            Navigate(item);
        }

        // From https://stackoverflow.com/questions/248603/natural-sort-order-in-c-sharp
        public static int CompareNatural(string strA, string strB)
        {
            return CompareNatural(strA, strB, System.Globalization.CultureInfo.CurrentCulture, System.Globalization.CompareOptions.IgnoreCase);
        }

        public static int CompareNatural(string strA, string strB, System.Globalization.CultureInfo culture, System.Globalization.CompareOptions options)
        {
            System.Globalization.CompareInfo cmp = culture.CompareInfo;
            int iA = 0;
            int iB = 0;
            int softResult = 0;
            int softResultWeight = 0;
            while (iA < strA.Length && iB < strB.Length)
            {
                bool isDigitA = Char.IsDigit(strA[iA]);
                bool isDigitB = Char.IsDigit(strB[iB]);
                if (isDigitA != isDigitB)
                {
                    return cmp.Compare(strA, iA, strB, iB, options);
                }
                else if (!isDigitA && !isDigitB)
                {
                    int jA = iA + 1;
                    int jB = iB + 1;
                    while (jA < strA.Length && !Char.IsDigit(strA[jA])) jA++;
                    while (jB < strB.Length && !Char.IsDigit(strB[jB])) jB++;
                    int cmpResult = cmp.Compare(strA, iA, jA - iA, strB, iB, jB - iB, options);
                    if (cmpResult != 0)
                    {
                        // Certain strings may be considered different due to "soft" differences that are
                        // ignored if more significant differences follow, e.g. a hyphen only affects the
                        // comparison if no other differences follow
                        string sectionA = strA.Substring(iA, jA - iA);
                        string sectionB = strB.Substring(iB, jB - iB);
                        if (cmp.Compare(sectionA + "1", sectionB + "2", options) ==
                            cmp.Compare(sectionA + "2", sectionB + "1", options))
                        {
                            return cmp.Compare(strA, iA, strB, iB, options);
                        }
                        else if (softResultWeight < 1)
                        {
                            softResult = cmpResult;
                            softResultWeight = 1;
                        }
                    }
                    iA = jA;
                    iB = jB;
                }
                else
                {
                    char zeroA = (char)(strA[iA] - (int)Char.GetNumericValue(strA[iA]));
                    char zeroB = (char)(strB[iB] - (int)Char.GetNumericValue(strB[iB]));
                    int jA = iA;
                    int jB = iB;
                    while (jA < strA.Length && strA[jA] == zeroA) jA++;
                    while (jB < strB.Length && strB[jB] == zeroB) jB++;
                    int resultIfSameLength = 0;
                    do
                    {
                        isDigitA = jA < strA.Length && Char.IsDigit(strA[jA]);
                        isDigitB = jB < strB.Length && Char.IsDigit(strB[jB]);
                        int numA = isDigitA ? (int)Char.GetNumericValue(strA[jA]) : 0;
                        int numB = isDigitB ? (int)Char.GetNumericValue(strB[jB]) : 0;
                        if (isDigitA && (char)(strA[jA] - numA) != zeroA) isDigitA = false;
                        if (isDigitB && (char)(strB[jB] - numB) != zeroB) isDigitB = false;
                        if (isDigitA && isDigitB)
                        {
                            if (numA != numB && resultIfSameLength == 0)
                            {
                                resultIfSameLength = numA < numB ? -1 : 1;
                            }
                            jA++;
                            jB++;
                        }
                    }
                    while (isDigitA && isDigitB);
                    if (isDigitA != isDigitB)
                    {
                        // One number has more digits than the other (ignoring leading zeros) - the longer
                        // number must be larger
                        return isDigitA ? 1 : -1;
                    }
                    else if (resultIfSameLength != 0)
                    {
                        // Both numbers are the same length (ignoring leading zeros) and at least one of
                        // the digits differed - the first difference determines the result
                        return resultIfSameLength;
                    }
                    int lA = jA - iA;
                    int lB = jB - iB;
                    if (lA != lB)
                    {
                        // Both numbers are equivalent but one has more leading zeros
                        return lA > lB ? -1 : 1;
                    }
                    else if (zeroA != zeroB && softResultWeight < 2)
                    {
                        softResult = cmp.Compare(strA, iA, 1, strB, iB, 1, options);
                        softResultWeight = 2;
                    }
                    iA = jA;
                    iB = jB;
                }
            }
            if (iA < strA.Length || iB < strB.Length)
            {
                return iA < strA.Length ? 1 : -1;
            }
            else if (softResult != 0)
            {
                return softResult;
            }
            return 0;
        }
    }
}