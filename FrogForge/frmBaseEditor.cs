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
    public partial class frmBaseEditor : Form
    {
        public FilesController DataDirectory { get; set; }
        public FilesController WorkingDirectory { get; set; }
        
        // TBA: Move the saved/unsaved changes logic here
    }
}
