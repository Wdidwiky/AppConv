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
    public partial class meter : Form
    {
        double km, hm, dam, m, dm, cm, mm;
        public meter()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (txtBoxInput.Text != null)
            {
                m = Convert.ToInt32(txtBoxInput.Text);
                km = (m / 1000);
                hm = (m / 100);
                dam = (m / 10);
                dm = (m * 10);
                cm = (m * 100);
                mm = (m * 1000);
            }

            txtBoxOutputkm.Text = Convert.ToString(km);
            txtBoxOutputhm.Text = Convert.ToString(hm);
            txtBoxOutputdam.Text = Convert.ToString(dam);
            txtBoxOutputdm.Text = Convert.ToString(dm);
            txtBoxOutputcm.Text = Convert.ToString(cm);
            txtBoxOutputmm.Text = Convert.ToString(mm);
        }
    }
}
