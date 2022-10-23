using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrogForge
{
    public static class ProjectPart
    {
        private const int LENGTH_LENGTH = 12;

        public static void Export<T>(SaveFileDialog dlgExport, string magic, T data, params Image[] images) where T : Datas.NamedData
        {
            // AddExtension is buggy for some reason
            string extension = dlgExport.Filter.Substring(dlgExport.Filter.IndexOf("|") + 2);
            dlgExport.FileName = data.Name;
            if (dlgExport.ShowDialog() == DialogResult.OK)
            {
                string exportString = ExportString(magic, data, images);
                File.WriteAllText(dlgExport.FileName.Replace(extension, "") + extension, exportString);
            }
        }

        public static void Import<T>(OpenFileDialog dlgImport, string magic, Action<T> saveAction, params Action<T, Image>[] setters)
        {
            if (dlgImport.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < dlgImport.FileNames.Length; i++)
                {
                    string source = File.ReadAllText(dlgImport.FileNames[i]);
                    T data = ImportString<T>(magic, source, setters);
                    if (data != null)
                    {
                        saveAction(data);
                    }
                }
            }
        }

        private static string ExportString<T>(string magic, T data, params Image[] images)
        {
            // General sturcture of the file:
            // - Begins with a magic string for validation on import (magic)
            // - Then a list of human-readable lengths with fixed width, ex:   25, 8394,  342
            // - Then the JSON data
            // - Then all images one after the other

            // Generate base lengths (magic length + (each length length) * (number of lengths)
            int baseOffset = magic.Length + 1 + (LENGTH_LENGTH + 1) * (images.Length + 1) + 1;
            int[] lengths = new int[images.Length + 1];
            // We will add the first line after everything else (aka after all lengths are calculated)
            string result = "\n";
            // Add the JSON
            string nextData = data.ToJson();
            result += nextData;
            lengths[0] = nextData.Length;
            // Add all images
            for (int i = 0; i < images.Length; i++)
            {
                nextData = ImageToBase64(images[i], ImageFormat.Png);
                result += nextData;
                lengths[i + 1] = nextData.Length;
            }
            // Finally, add the first line (human-readable)
            string firstLine = magic + ":";
            for (int i = 0; i < lengths.Length; i++)
            {
                firstLine += (i > 0 ? "," : "") + lengths[i].ToString().PadLeft(LENGTH_LENGTH);
            }
            return firstLine + result;
        }

        private static T ImportString<T>(string magic, string source, params Action<T, Image>[] setters)
        {
            // Do everything in a try-catch in case users try inputing a pdf or something
            try
            {
                // Validate file using magic
                if (source.Substring(0, magic.Length + 1) != magic + ":")
                {
                    throw new Exception();
                }
                // Get all lengths
                source = source.Substring(magic.Length + 1);
                string firstLine = source.Split('\n')[0];
                string[] lengthStrings = firstLine.Split(',');
                int[] lengths = new int[lengthStrings.Length];
                for (int i = 0; i < lengths.Length; i++)
                {
                    lengths[i] = int.Parse(lengthStrings[i].Trim());
                }
                if (lengths.Length != setters.Length + 1)
                {
                    throw new Exception();
                }
                // Find all parts
                string actualFile = source.Substring(lengths.Length * (LENGTH_LENGTH + 1));
                T result = actualFile.Substring(0, lengths[0]).JsonToObject<T>();
                for (int i = 0; i < setters.Length; i++)
                {
                    actualFile = actualFile.Substring(lengths[i]);
                    Image image = Base64ToImage(actualFile.Substring(0, lengths[i + 1]));
                    setters[i](result, image);
                }
                return result;
            }
            catch
            {
                MessageBox.Show("Invalid file! Import failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default;
            }
        }

        // From https://stackoverflow.com/questions/18827081/c-sharp-base64-string-to-jpeg-image
        private static string ImageToBase64(Image image, ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();

                // Convert byte[] to base 64 string
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        private static Image Base64ToImage(string base64String)
        {
            // Convert base 64 string to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            // Convert byte[] to Image
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                Image image = Image.FromStream(ms, true);
                return image;
            }
        }
    }
}
