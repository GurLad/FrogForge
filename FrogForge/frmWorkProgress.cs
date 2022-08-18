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
    public partial class frmWorkProgress : Form
    {
        public string LabelText
        {
            get
            {
                return lblWorking.Text;
            }
            set
            {
                lblWorking.Text = value;
            }
        }
        public bool ExactProgress
        {
            set
            {
                prbProgress.Style = value ? ProgressBarStyle.Continuous : ProgressBarStyle.Marquee;
            }
        }
        public float Progress
        {
            set
            {
                prbProgress.Value = (int)(value * prbProgress.Maximum);
            }
        }
        private bool _cancelable = true;
        public bool Cancelable
        {
            get
            {
                return _cancelable;
            }
            set
            {
                _cancelable = value;
                btnCancel.Enabled = Cancelable;
            }
        }
        public bool Canceled { get; set; } = false;
        public bool Canceling { get; set; } = false;
        public Action CancelAction { get; set; } = null;
        public string ActionName { get; set; } = "this action";

        public frmWorkProgress()
        {
            InitializeComponent();
        }

        public void End()
        {
            FormClosing -= frmWorkProgress_FormClosing;
            Close();
        }

        public async Task FinishCanceling()
        {
            await Task.Run(() => { while (Canceling) ; }); // Busy waiting is bad, will fix in the future
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void frmWorkProgress_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Cancel())
            {
                e.Cancel = true;
            }
        }

        private bool Cancel()
        {
            if (Cancelable)
            {
                Canceling = true;
                if (ExtensionMethods.ConfirmDialog("Are you sure you want to cancel " + ActionName + "?", "Cancel"))
                {
                    Canceling = false;
                    Canceled = true;
                    CancelAction?.Invoke();
                    return true;
                }
                Canceling = false;
            }
            else
            {
                MessageBox.Show("It's impossible to cancel " + ActionName + " now!");
            }
            return false;
        }

        public static frmWorkProgress Show(string labelText, string acitonName, bool cancelable, bool exactProgress, IWin32Window owner)
        {
            frmWorkProgress workProgress = new frmWorkProgress();
            workProgress.LabelText = labelText;
            workProgress.ActionName = acitonName;
            workProgress.Cancelable = cancelable;
            workProgress.ExactProgress = exactProgress;
            workProgress.Show(owner);
            return workProgress;
        }
    }
}
