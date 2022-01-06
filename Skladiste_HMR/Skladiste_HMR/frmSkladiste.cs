using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skladiste_HMR
{
    public partial class frmSkladiste : Form
    {
        string ulogaGlob = "";
        public frmSkladiste(string uloga)
        {
            ulogaGlob = uloga;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
