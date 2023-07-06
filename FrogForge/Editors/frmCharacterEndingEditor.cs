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
        public frmCharacterEndingEditor()
        {
            InitializeComponent();
            BaseName = Text;
        }

        private void frmCharacterEndingEditor_Load(object sender, EventArgs e)
        {
            // Init stuff
            dlgImport.Filter = dlgExport.Filter = "Character Endings data files|*.characterending.ffpp";
            lstCharacterEndings.Init(this, () => new CharacterEndingData(), CharacterEndingDataFromUI, CharacterEndingDataToUI, "CharacterEndings");
            lstEndingCards.Init(this, () => new EndingCardData(), () => new EndingCardPanel(), (a) => a.Init(DataDirectory, this));
            this.ApplyPreferences();
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
            lstCharacterEndings.Save(txtName.Text);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            lstCharacterEndings.New();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lstCharacterEndings.Remove();
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
            lstCharacterEndings.SaveToFile();
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
    }
}
