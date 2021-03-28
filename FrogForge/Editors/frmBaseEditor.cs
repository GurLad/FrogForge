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
        protected string BaseName;
        protected EventHandler DirtyFunc;

        protected frmBaseEditor()
        {
            CurrentFile = "";
            FormClosing += FormClosingEvent;
            KeyPreview = true;
            KeyDown += KeyDownEvent;
            DirtyFunc = (s, e1) => Dirty = true;
        }

        public bool ConfirmDialog(string text, string title)
        {
            return MessageBox.Show(text, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;
        }

        public bool HasUnsavedChanges()
        {
            return Dirty && !ConfirmDialog("Unsaved changes! Discard?", "Unsaved changes");
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
