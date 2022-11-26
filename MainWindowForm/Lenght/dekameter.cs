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
    public partial class dekameter : Form
    {
        double km, hm, dam, m, dm, cm, mm;
        public dekameter()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (txtBoxInput.Text != null)
            {
                dam = Convert.ToInt32(txtBoxInput.Text);
                km = (dam / 100);
                hm = (dam / 10);
                m = (dam * 10);
                dm = (dam * 100);
                cm = (dam * 1000);
                mm = (dam * 10000);
            }

            txtBoxOutputkm.Text = Convert.ToString(km);
            txtBoxOutputhm.Text = Convert.ToString(hm);
            txtBoxOutputm.Text = Convert.ToString(m);
            txtBoxOutputdm.Text = Convert.ToString(dm);
            txtBoxOutputcm.Text = Convert.ToString(cm);
            txtBoxOutputmm.Text = Convert.ToString(mm);
        }
    }
}
