using FrogForge.UserControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace FrogForge
{
    public static class ExtensionMethods
    {
        public static string ToJson<T>(this T obj)
        {
            return JsonSerializer.Serialize(obj, typeof(T));
        }

        public static T JsonToObject<T>(this string jsonContent)
        {
            return (T)JsonSerializer.Deserialize(jsonContent, typeof(T));
        }

        public static bool DirectoryExists(this FilesController files, string name)
        {
            return System.IO.Directory.Exists(files.Path + name);
        }

        public static void DeleteDirectory(this FilesController files, string toDelete, bool recursive = true)
        {
            System.IO.Directory.Delete(files.Path + toDelete, recursive);
        }

        public static Image SplitGIF(this Image source)
        {
            FrameDimension dimension = new FrameDimension(source.FrameDimensionsList.First());
            int frameCount = source.GetFrameCount(dimension);
            Bitmap target = new Bitmap(source.Width * frameCount, source.Height);
            Graphics graphics = Graphics.FromImage(target);
            Rectangle cloneRect = new Rectangle(0, 0, source.Width, source.Height);
            for (int i = 0; i < frameCount; i++)
            {
                cloneRect.Location = new Point(i * cloneRect.Width, 0);
                source.SelectActiveFrame(dimension, i);
                graphics.DrawImage(source, cloneRect);
            }
            graphics.Dispose();
            return target;
        }

        public static void ApplyPreferences(this Control control)
        {
            if (Preferences.Current.DarkMode)
            {
                if (control is PalettePanel || control is GrowthsPanel)
                {
                    return;
                }
                control.BackColor = Preferences.Current.DarkModeBackColor;
                control.ForeColor = Color.White;
                if (control is Button)
                {
                    ((Button)control).FlatStyle = FlatStyle.Flat;
                    ((Button)control).FlatAppearance.MouseOverBackColor = Color.DarkGray;
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).FlatStyle = FlatStyle.Flat;
                }
                else if (control is TextBox)
                {
                    ((TextBox)control).BorderStyle = BorderStyle.FixedSingle;
                }
                else if (control is ListBox)
                {
                    ((ListBox)control).BorderStyle = BorderStyle.FixedSingle;
                }
                else if (control is NumericUpDown)
                {
                    ((NumericUpDown)control).BorderStyle = BorderStyle.FixedSingle;
                }
                foreach (Control otherControl in control.Controls)
                {
                    otherControl.ApplyPreferences();
                }
            }
        }

        public static bool ConfirmDialog(string text, string title)
        {
            VoiceAssist.Say("Confirm");
            return MessageBox.Show(text, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;
        }
    }
}
