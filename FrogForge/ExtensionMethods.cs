using FrogForge.Editors;
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

        public static void ApplyPreferences(this Control control, bool zoom = true)
        {
            void ApplyDarkMode(Control caller)
            {
                if (caller is PalettePanel || caller is GrowthsPanel)
                {
                    return;
                }
                caller.BackColor = Preferences.Current.DarkModeBackColor;
                caller.ForeColor = Color.White;
                if (caller is Button)
                {
                    ((Button)caller).FlatStyle = FlatStyle.Flat;
                    ((Button)caller).FlatAppearance.MouseOverBackColor = Color.DarkGray;
                }
                else if (caller is ComboBox)
                {
                    ((ComboBox)caller).FlatStyle = FlatStyle.Flat;
                }
                else if (caller is TextBox)
                {
                    ((TextBox)caller).BorderStyle = BorderStyle.FixedSingle;
                }
                else if (caller is ListBox)
                {
                    ((ListBox)caller).BorderStyle = BorderStyle.FixedSingle;
                }
                else if (caller is NumericUpDown)
                {
                    ((NumericUpDown)caller).BorderStyle = BorderStyle.FixedSingle;
                }
                foreach (Control otherControl in caller.Controls)
                {
                    ApplyDarkMode(otherControl);
                }
            }
            void ApplyZoomMode(Control caller)
            {
                if (caller is PalettePanel)
                {
                    ((PalettePanel)caller).ApplyZoomMode();
                    return;
                }
                if (caller is EventTextBox)
                {
                    caller.Font = new Font(caller.Font.FontFamily, (int)Math.Round(control.Font.Size * Preferences.Current.ZoomAmount));
                    return;
                }
                if (caller is TeamPanel)
                {
                    foreach (Control item in caller.Controls)
                    {
                        item.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    }
                    caller.Left = (int)Math.Round(caller.Left / Preferences.Current.ZoomAmount);
                    caller.Width = (int)Math.Round(caller.Width / Preferences.Current.ZoomAmount);
                }
                foreach (Control otherControl in caller.Controls)
                {
                    ApplyZoomMode(otherControl);
                }
            }

            if (Preferences.Current.DarkMode)
            {
                ApplyDarkMode(control);
            }
            if (Preferences.Current.ZoomAmount > 1 && zoom)
            {
                control.Font = new Font(control.Font.FontFamily, (int)Math.Round(control.Font.Size * Preferences.Current.ZoomAmount));
                foreach (Control otherControl in control.Controls)
                {
                    ApplyZoomMode(otherControl);
                }
                if (control is frmBaseEditor)
                {
                    ((frmBaseEditor)control).RecenterForm();
                }
            }
        }

        public static void ResizeByZoom(this Control control, bool pos = true, bool x = true, bool y = true)
        {
            if (x)
            {
                control.Width = (int)Math.Round(control.Width * Preferences.Current.ZoomAmount);
            }
            if (y)
            {
                control.Height = (int)Math.Round(control.Height * Preferences.Current.ZoomAmount);
            }
            if (pos)
            {
                if (x)
                {
                    control.Left = (int)Math.Round(control.Left * Preferences.Current.ZoomAmount);
                }
                if (y)
                {
                    control.Top = (int)Math.Round(control.Top * Preferences.Current.ZoomAmount);
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
