using FrogForge.Datas;
using FrogForge.Editors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrogForge.UserControls
{
    public partial class EndingCardPanel : EndingCardEditor
    {
        public override EndingCardData Data
        {
            get
            {
                return new EndingCardData(txtRequirement.Text, txtTitle.Text, txtCard.Text);
            }
            set
            {
                txtRequirement.Text = value.Requirements;
                txtTitle.Text = value.Title;
                txtCard.Text = value.Card;
            }
        }

        public EndingCardPanel()
        {
            InitializeComponent();
        }

        public void Init(Utils.FilesController dataDirectory, frmBaseEditor editor)
        {
            txtCard.Font = FontStuff.GetFont("Gaiden", (int)Math.Round(txtCard.Font.SizeInPoints * Preferences.Current.ZoomAmount));
            txtRequirement.Init(dataDirectory, editor);
            txtRequirement.TextChanged += (sender, e) => editor.Dirty = true;
            txtTitle.TextChanged += (sender, e) => editor.Dirty = true;
            txtCard.TextChanged += (sender, e) => editor.Dirty = true;
        }
    }
}
