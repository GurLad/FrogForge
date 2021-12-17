using FrogForge.Datas;
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
    public partial class frmCGEditor : frmBaseEditor
    {
        private List<Palette> BaseSpritePalettes;

        public frmCGEditor()
        {
            InitializeComponent();
            BaseName = Text;
        }

        private void frmCGEditor_Load(object sender, EventArgs e)
        {
            // Init palettes
            BaseSpritePalettes = Palette.GetBaseSpritePalettes(WorkingDirectory);
            // Init stuff
            lstCGs.Init(this, () => new CGData(), CGDataFromUI, CGDataToUI, "CGs");
            pltBG1.Init(this, (p) => { picBG1.Palette = p; UpdatePreview(); });
            pltBG2.Init(this, (p) => { picBG2.Palette = p; UpdatePreview(); });
            fgpFG1.Init(this, BaseSpritePalettes, (p) => { picFG1.Palette = p; UpdatePreview(); });
            fgpFG2.Init(this, BaseSpritePalettes, (p) => { picFG2.Palette = p; UpdatePreview(); });
            picBG1.Init(dlgOpen, this, () => UpdatePreview());
            picBG2.Init(dlgOpen, this, () => UpdatePreview());
            picFG1.Init(dlgOpen, this, () => UpdatePreview());
            picFG2.Init(dlgOpen, this, () => UpdatePreview());
            this.ApplyPreferences();
        }

        private CGData CGDataFromUI(CGData data)
        {
            data.Name = txtName.Text;
            data.BGImage1 = picBG1.Image;
            data.BGImage2 = picBG2.Image;
            data.FGImage1 = picFG1.Image;
            data.FGImage2 = picFG2.Image;
            data.BGPalette1 = pltBG1.Data;
            data.BGPalette2 = pltBG2.Data;
            data.FGPalette1 = fgpFG1.Data;
            data.FGPalette2 = fgpFG2.Data;
            CurrentFile = data.Name;
            Dirty = false;
            return data;
        }

        private void CGDataToUI(CGData data)
        {
            data.LoadImages(WorkingDirectory);
            txtName.Text = data.Name;
            picBG1.Image = data.BGImage1;
            picBG2.Image = data.BGImage2;
            picFG1.Image = data.FGImage1;
            picFG2.Image = data.FGImage2;
            pltBG1.Data = data.BGPalette1;
            pltBG2.Data = data.BGPalette2;
            fgpFG1.Data = data.FGPalette1;
            fgpFG2.Data = data.FGPalette2;
            UpdatePreview();
            CurrentFile = data.Name;
            Dirty = false;
        }

        private void UpdatePreview()
        {
            Bitmap source = picBG2.Image?.Target ?? new Bitmap(256, 240);
            source = new Bitmap(source);
            using (Graphics g = Graphics.FromImage(source))
            {
                if (picBG1.Image != null)
                {
                    g.DrawImage(picBG1.Image.Target, Point.Empty);
                }
                if (picFG2.Image != null)
                {
                    g.DrawImage(picFG2.Image.Target, Point.Empty);
                }
                if (picFG1.Image != null)
                {
                    g.DrawImage(picFG1.Image.Target, Point.Empty);
                }
            }
            picPreview.Image = source;
            picPreview.FixZoom();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lstCGs.Save(txtName.Text);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            lstCGs.New();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lstCGs.Remove();
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

        private void frmCGEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            // Save info
            lstCGs.SaveToFile();
            // Save images
            foreach (CGData item in lstCGs.Data)
            {
                WorkingDirectory.CreateDirectory(@"Images\CGs\" + item.Name);
                if (item.BGImage1 != null)
                {
                    WorkingDirectory.SaveImage(@"CGs\" + item.Name + @"\BG1", item.BGImage1.ToBitmap(Palette.BasePalette));
                }
                if (item.BGImage2 != null)
                {
                    WorkingDirectory.SaveImage(@"CGs\" + item.Name + @"\BG2", item.BGImage2.ToBitmap(Palette.BasePalette));
                }
                if (item.FGImage1 != null)
                {
                    WorkingDirectory.SaveImage(@"CGs\" + item.Name + @"\FG1", item.FGImage1.ToBitmap(Palette.BasePalette));
                }
                if (item.FGImage2 != null)
                {
                    WorkingDirectory.SaveImage(@"CGs\" + item.Name + @"\FG2", item.FGImage2.ToBitmap(Palette.BasePalette));
                }
            }
            Cursor.Current = Cursors.Default;
        }
    }
}
