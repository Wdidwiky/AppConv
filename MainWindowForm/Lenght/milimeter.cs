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
    public partial class milimeter : Form
    {
        double km, hm, dam, m, dm, cm, mm;
        public milimeter()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (txtBoxInput.Text != null)
            {
                mm = Convert.ToInt32(txtBoxInput.Text);
                km = (mm / 1000000);
                hm = (mm / 100000);
                dam = (mm / 10000);
                m = (mm / 1000);
                dm = (mm / 100);
                cm = (mm / 10);
            }

            txtBoxOutputkm.Text = Convert.ToString(km);
            txtBoxOutputhm.Text = Convert.ToString(hm);
            txtBoxOutputdam.Text = Convert.ToString(dam);
            txtBoxOutputm.Text = Convert.ToString(m);
            txtBoxOutputdm.Text = Convert.ToString(dm);
            txtBoxOutputcm.Text = Convert.ToString(cm);
        }
    }
}
