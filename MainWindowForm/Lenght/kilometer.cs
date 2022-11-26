using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainWindowForm.Lenght
{
    public partial class kilometer : Form
    {
        double km, hm, dam, m, dm, cm, mm;
        public kilometer()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (txtBoxInput.Text != null)
            {
                km = Convert.ToInt32(txtBoxInput.Text);
                hm = (km * 10);
                dam = (km * 100);
                m = (km * 1000);
                dm = (km * 10000);
                cm = (km * 100000);
                mm = (km * 1000000);
            }
                txtBoxOutputhm.Text = Convert.ToString(hm);
                txtBoxOutputdam.Text = Convert.ToString(dam);
                txtBoxOutputm.Text = Convert.ToString(m);
                txtBoxOutputdm.Text = Convert.ToString(dm);
                txtBoxOutputcm.Text = Convert.ToString(cm);
                txtBoxOutputmm.Text = Convert.ToString(mm);
        }
    }
}
