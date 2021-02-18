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

namespace FrogForge
{
    public abstract partial class frmBaseEditor : Form
    {
        public FilesController DataDirectory { get; set; }
        public FilesController WorkingDirectory { get; set; }
        protected string BaseName;
        protected string CurrentFile
        {
            set
            {
                Text = BaseName + (value == "" ? "" : " - " + value);
                Dirty = false;
            }
        }
        private bool _dirty;
        protected bool Dirty
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

        protected frmBaseEditor()
        {
            CurrentFile = "";
            FormClosing += FormClosingEvent;
            KeyPreview = true;
            KeyDown += KeyDownEvent;
        }

        protected bool HasUnsavedChanges()
        {
            return Dirty && MessageBox.Show("Unsaved changes! Discard?", "Unsaved changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No;
        }

        protected bool DeleteFile(string fileName, FilesController directory)
        {
            if (MessageBox.Show("Are you sure you want to delete " + fileName + "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                directory.DeleteFile(fileName);
                if (directory.CheckFileExist(fileName + directory.DefultFileFormat + ".meta"))
                {
                    directory.DeleteFile(fileName + directory.DefultFileFormat + ".meta", "");
                }
                return true;
            }
            return false;
        }

        protected abstract void ControlKeyAction(Keys key);

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
                ControlKeyAction(e.KeyCode);
            }
        }
    }
}
