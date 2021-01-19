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
        private OpenFileDialog dlgDataImport = new OpenFileDialog();
        private SaveFileDialog dlgDataExport = new SaveFileDialog();
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            WorkingDirectory.Path = DataDirectory.LoadFile("Path", DataDirectory.Path);
            txtPath.Text = WorkingDirectory.Path;
            dlgFolder.IsFolderPicker = true;
            dlgDataImport.Filter = "ZIP files|*.zip";
            dlgDataExport.Filter = "ZIP files|*.zip";
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

        private void btnClassEditor_Click(object sender, EventArgs e)
        {
            frmClassEditor classEditor = new frmClassEditor();
            classEditor.DataDirectory = DataDirectory;
            classEditor.WorkingDirectory = WorkingDirectory;
            classEditor.ShowDialog(this);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (dlgDataImport.ShowDialog(this) == DialogResult.OK)
            {
                FilesController tempData = new FilesController("TempData");
                if (System.IO.Directory.Exists(tempData.Path))
                {
                    System.IO.Directory.Delete(tempData.Path, true);
                }
                System.IO.Compression.ZipFile.ExtractToDirectory(dlgDataImport.FileName, tempData.Path);
                System.IO.Directory.Delete(DataDirectory.Path, true);
                System.IO.Directory.Move(tempData.Path, DataDirectory.Path);
                WorkingDirectory.Path = txtPath.Text;
                DataDirectory.SaveFile("Path", txtPath.Text);
                MessageBox.Show("Done!");
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dlgDataExport.ShowDialog(this) == DialogResult.OK)
            {
                if (System.IO.File.Exists(dlgDataExport.FileName))
                {
                    System.IO.File.Delete(dlgDataExport.FileName);
                }
                System.IO.Compression.ZipFile.CreateFromDirectory(DataDirectory.Path, dlgDataExport.FileName);
                MessageBox.Show("Done!");
            }
        }
    }
}
