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
    public partial class hektometer : Form
    {
        double km, hm, dam, m, dm, cm, mm;
        public hektometer()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if(txtBoxInput.Text != null)
            {
                hm = Convert.ToInt32(txtBoxInput.Text);
                km = (hm / 10);
                dam = (hm * 10);
                m = (hm * 100);
                dm = (hm * 1000);
                cm = (hm * 10000);
                mm = (hm * 100000);
            }

            txtBoxOutPutkm.Text = Convert.ToString(km);
            txtBoxOutPutdam.Text = Convert.ToString(dam);
            txtBoxOutputm.Text = Convert.ToString(m);
            txtBoxOutputdm.Text = Convert.ToString(dm);
            txtBoxOutputcm.Text = Convert.ToString(cm);
            txtBoxOutPutmm.Text = Convert.ToString(mm);
        }
    }
}
