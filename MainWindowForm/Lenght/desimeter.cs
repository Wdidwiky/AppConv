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
    public partial class desimeter : Form
    {
        double km, hm, dam, m, dm, cm, mm;
        public desimeter()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (txtBoxInput.Text != null)
            {
                dm = Convert.ToInt32(txtBoxInput.Text);
                km = (dm / 10000);
                hm = (dm / 1000);
                dam = (dm / 100);
                m = (dm / 10);
                cm = (dm * 10);
                mm = (dm * 100);
            }

            txtBoxOutputkm.Text = Convert.ToString(km);
            txtBoxOutputhm.Text = Convert.ToString(hm);
            txtBoxOutputdam.Text = Convert.ToString(dam);
            txtBoxOutputm.Text = Convert.ToString(m);
            txtBoxOutputcm.Text = Convert.ToString(cm);
            txtBoxOutputmm.Text = Convert.ToString(mm);
        }
    }
}
