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
    public partial class centimeter : Form
    {
        double km, hm, dam, m, dm, cm, mm;
        public centimeter()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (txtBoxInput.Text != null)
            {
                cm = Convert.ToInt32(txtBoxInput.Text);
                km = (cm / 100000);
                hm = (cm / 10000);
                dam = (cm / 1000);
                m = (cm / 100);
                dm = (cm / 10);
                mm = (cm * 10);
            }

            txtBoxOutputkm.Text = Convert.ToString(km);
            txtBoxOutputhm.Text = Convert.ToString(hm);
            txtBoxOutputdam.Text = Convert.ToString(dam);
            txtBoxOutputm.Text = Convert.ToString(m);
            txtBoxOutputdm.Text = Convert.ToString(dm);
            txtBoxOutputmm.Text = Convert.ToString(mm);
        }
    }
}
