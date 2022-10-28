using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;

namespace FrogForge
{
    public static class FontStuff
    {
        // From https://stackoverflow.com/questions/1955629/c-sharp-using-an-embedded-font-on-a-textbox/1956043#1956043

        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);

        private static PrivateFontCollection Collection { get; } = new PrivateFontCollection();

        public static void CreateFont(byte[] font)
        {
            Stream fontStream = new MemoryStream(font);
            //create an unsafe memory block for the data
            System.IntPtr data = Marshal.AllocCoTaskMem((int)fontStream.Length);
            //create a buffer to read in to
            Byte[] fontData = new Byte[fontStream.Length];
            //fetch the font program from the resource
            fontStream.Read(fontData, 0, (int)fontStream.Length);
            //copy the bytes to the unsafe memory block
            Marshal.Copy(fontData, 0, data, (int)fontStream.Length);

            // We HAVE to do this to register the font to the system (Weird .NET bug !)
            uint cFonts = 0;
            AddFontMemResourceEx(data, (uint)fontData.Length, IntPtr.Zero, ref cFonts);

            //pass the font to the font collection
            Collection.AddMemoryFont(data, (int)fontStream.Length);
            //close the resource stream
            fontStream.Close();
            //free the unsafe memory
            Marshal.FreeCoTaskMem(data);
        }

        public static Font GetFont(string name, float size)
        {
            for (int i = 0; i < Collection.Families.Length; i++)
            {
                if (Collection.Families[i].Name == name)
                {
                    return new Font(Collection.Families[i], size);
                }
            }
            throw new Exception("Font not found!");
        }
    }
}
