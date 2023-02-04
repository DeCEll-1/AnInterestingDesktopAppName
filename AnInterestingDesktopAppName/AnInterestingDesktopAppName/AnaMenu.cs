using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnInterestingDesktopAppName
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            GirisEkrani ge = new GirisEkrani();
            ge.ShowDialog();
            InitializeComponent();
            label1.Text = "a";
        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {
        }
    }
}
