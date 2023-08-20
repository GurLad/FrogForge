using FrogForge.Datas;
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

namespace FrogForge.Editors
{
    public partial class frmCharacterEndingEditor : frmBaseEditor
    {
        private Size[] PageSizes { get; } = new Size[] { new Size(480, 320), new Size(334, 336) };

        public frmCharacterEndingEditor()
        {
            InitializeComponent();
            BaseName = Text;
        }

        private void frmCharacterEndingEditor_Load(object sender, EventArgs e)
        {
            // Init character endings
            dlgImport.Filter = dlgExport.Filter = "Character Endings data files|*.characterending.ffpp";
            lstCharacterEndings.Init(this, () => new CharacterEndingData(), CharacterEndingDataFromUI, CharacterEndingDataToUI, "CharacterEndings");
            lstEndingCards.Init(this, () => new EndingCardData(), () => new EndingCardPanel(), (a) => a.Init(DataDirectory, this));
            // Init global endings
            lstGlobalEndings.Init(null, () => new GlobalEndingData(), () => new GlobalEndingPanel(), (a) => a.Init(DataDirectory, null));
            this.ApplyPreferences();
            if (WorkingDirectory.CheckFileExist("GlobalEndings.json"))
            {
                lstGlobalEndings.Datas = WorkingDirectory.LoadFile("GlobalEndings", "", ".json").JsonToObject<List<GlobalEndingData>>();
            }
            // Dumb size fix
            Size truePage0 = Size;
            Size = PageSizes[0];
            this.ResizeByZoom(false);
            Size diff = Size - truePage0;
            PageSizes[0] = truePage0;
            Size = PageSizes[1];
            this.ResizeByZoom(false);
            PageSizes[1] = Size - diff;
            Size = PageSizes[0];
        }

        private CharacterEndingData CharacterEndingDataFromUI(CharacterEndingData data)
        {
            data.Name = txtName.Text;
            data.EndingCards = lstEndingCards.Datas;
            CurrentFile = data.Name;
            Dirty = false;
            return data;
        }

        private void CharacterEndingDataToUI(CharacterEndingData data)
        {
            txtName.Text = data.Name;
            lstEndingCards.Datas = data.EndingCards;
            CurrentFile = data.Name;
            Dirty = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbcMain.SelectedIndex == 0)
            {
                lstCharacterEndings.Save(txtName.Text);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (tbcMain.SelectedIndex == 0)
            {
                lstCharacterEndings.New();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tbcMain.SelectedIndex == 0)
            {
                lstCharacterEndings.Remove();
            }
        }

        protected override bool ControlKeyAction(Keys key)
        {
            switch (key)
            {
                case Keys.S:
                    btnSave_Click(this, new EventArgs());
                    return true;
                case Keys.N:
                    btnNew_Click(this, new EventArgs());
                    return true;
                default:
                    break;
            }
            return false;
        }

        private void frmCharacterEndingEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Character endings
            lstCharacterEndings.SaveToFile();
            // Global ending
            WorkingDirectory.SaveFile("GlobalEndings", lstGlobalEndings.Datas.ToJson(), ".json");
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            // Technically, could just be a simple JSON file as it doesn't contain any images, but eh
            CharacterEndingData data = CharacterEndingDataFromUI(new CharacterEndingData());
            ProjectPart.Export(dlgExport, "CharacterEnding", data);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            // Technically, could just be a simple JSON file as it doesn't contain any images, but eh
            ProjectPart.Import<CharacterEndingData>(
                dlgImport, "CharacterEnding",
                (ce) =>
                {
                    CharacterEndingDataToUI(ce);
                    btnSave_Click(sender, e);
                });
        }

        private void tbcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            Left += (Width - PageSizes[tbcMain.SelectedIndex].Width) / 2;
            Top += (Height - PageSizes[tbcMain.SelectedIndex].Height) / 2;
            Size = PageSizes[tbcMain.SelectedIndex];
            //this.ResizeByZoom(false);
            CurrentFile = "";
            Dirty = false;
            btnExport.Enabled = btnImport.Enabled = btnNew.Enabled = btnRemove.Enabled = btnSave.Enabled = tbcMain.SelectedIndex == 0;
        }
    }
}
