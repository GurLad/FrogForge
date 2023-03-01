using FrogForge.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;
using static FrogForge.ExtensionMethods;

namespace FrogForge.Editors
{
    public partial class frmBaseEditor : Form
    {
        public FilesController DataDirectory { get; set; }
        public FilesController WorkingDirectory { get; set; }
        private bool _dirty;
        public bool Dirty
        {
            get
            {
                return _dirty;
            }
            set
            {
                if (_dirty == value)
                {
                    return;
                }
                _dirty = value;
                if (_dirty)
                {
                    Text += "*";
                }
                else
                {
                    Text = Text.Replace("*", "");
                }
            }
        }
        public string CurrentFile
        {
            set
            {
                Text = BaseName + (value == "" ? "" : " - " + value);
                Dirty = false;
            }
        }
        protected OpenFileDialog dlgOpen = new OpenFileDialog();
        protected SaveFileDialog dlgExport = new SaveFileDialog();
        protected OpenFileDialog dlgImport = new OpenFileDialog();
        protected string BaseName;
        protected EventHandler DirtyFunc;

        protected frmBaseEditor()
        {
            // Init stuff
            CurrentFile = "";
            FormClosing += FormClosingEvent;
            KeyPreview = true;
            KeyDown += KeyDownEvent;
            DirtyFunc = (s, e1) => Dirty = true;
            dlgOpen.Filter = "Image files|*.gif;*.png";
            dlgExport.Filter = dlgImport.Filter = "ERROR|*.*"; // Need to be set for each editor
            dlgExport.SupportMultiDottedExtensions = dlgImport.SupportMultiDottedExtensions = true;
            dlgImport.Multiselect = true;
        }

        public bool HasUnsavedChanges()
        {
            return Dirty && !ConfirmDialog("Unsaved changes! Discard?", "Unsaved changes");
        }
        public void RecenterForm()
        {
            CenterToScreen();
        }

        protected bool DeleteFile(string fileName, FilesController directory, bool showConfirmDialog = true, string format = null)
        {
            if (!showConfirmDialog || ConfirmDialog("Are you sure you want to delete " + fileName + "?", "Delete"))
            {
                directory.DeleteFile(fileName, format);
                if (directory.CheckFileExist(fileName + (format ?? directory.DefultFileFormat) + ".meta"))
                {
                    directory.DeleteFile(fileName + (format ?? directory.DefultFileFormat) + ".meta", "");
                }
                return true;
            }
            return false;
        }

        protected void DeleteFolder(string folderName, FilesController directory)
        {
            directory.DeleteDirectory(@"\" + folderName);
            if (directory.CheckFileExist(folderName + ".meta"))
            {
                directory.DeleteFile(folderName + ".meta", "");
            }
        }

        protected virtual bool ControlKeyAction(Keys key)
        {
            throw new NotImplementedException();
        }

        private void FormClosingEvent(object sender, FormClosingEventArgs e)
        {
            if (HasUnsavedChanges())
            {
                e.Cancel = true;
            }
        }

        private void KeyDownEvent(object sender, KeyEventArgs e)
        {
            if (ModifierKeys == Keys.Control)
            {
                e.Handled = ControlKeyAction(e.KeyCode);
            }
        }
    }
}
