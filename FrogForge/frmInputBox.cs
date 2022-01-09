using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrogForge
{
    public partial class frmInputBox : Form
    {
        public string Result { get => txtInput.Text; }

        public frmInputBox()
        {
            InitializeComponent();
        }

        public void SetTitleAndText(string title, string text)
        {
            Text = title;
            lblText.Text = text;
            txtInput.Text = "";
            txtInput.Focus();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            txtInput.Focus();
        }
    }

    public static class InputBox
    {
        private static frmInputBox frmInputBox = new frmInputBox();

        public static string Show(string title, string text, IWin32Window owner)
        {
            frmInputBox.SetTitleAndText(title, text);
            if (frmInputBox.ShowDialog(owner) == DialogResult.OK)
            {
                return frmInputBox.Result;
            }
            else
            {
                return null;
            }
        }
    }
}
