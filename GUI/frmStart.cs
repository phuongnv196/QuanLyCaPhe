using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYWIN10
{
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i ==1)
            {
                Form f = new frmLockScreen(this);
                f.Show();
                i = 0;
                timer1.Enabled = false;
            }
            i++;
        }
    }
}
