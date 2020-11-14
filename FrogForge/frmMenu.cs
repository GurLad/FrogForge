using Microsoft.WindowsAPICodePack.Dialogs;
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
    public partial class frmMenu : Form
    {
        private FilesController DataDirectory = new FilesController("Data");
        private FilesController WorkingDirectory = new FilesController();
        private CommonOpenFileDialog dlgFolder = new CommonOpenFileDialog();
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            WorkingDirectory.Path = DataDirectory.LoadFile("Path", DataDirectory.Path);
            txtPath.Text = WorkingDirectory.Path;
            dlgFolder.IsFolderPicker = true;
        }

        private void btnChangePath_Click(object sender, EventArgs e)
        {
            if (dlgFolder.ShowDialog() == CommonFileDialogResult.Ok)
            {
                DataDirectory.SaveFile("Path", dlgFolder.FileName);
                WorkingDirectory.Path = dlgFolder.FileName;
                txtPath.Text = WorkingDirectory.Path;
            }
        }

        private void btnLevelEditor_Click(object sender, EventArgs e)
        {
            frmLevelEditor levelEditor = new frmLevelEditor();
            levelEditor.DataDirectory = DataDirectory;
            levelEditor.WorkingDirectory = WorkingDirectory;
            levelEditor.ShowDialog(this);
        }

        private void btnConversationEditor_Click(object sender, EventArgs e)
        {
            frmConversationEditor conversationEditor = new frmConversationEditor();
            conversationEditor.DataDirectory = DataDirectory;
            conversationEditor.WorkingDirectory = WorkingDirectory;
            conversationEditor.ShowDialog(this);
        }
    }
}
