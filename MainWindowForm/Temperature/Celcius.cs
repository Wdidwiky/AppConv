using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainWindowForm.Convertion
{
    public partial class Celcius : Form
    {
        int c, f, r, k;
        public Celcius()
        {
            InitializeComponent();
        }



        private void btnConvert_Click(object sender, EventArgs e)
        {
            if(txtBoxInput.Text!=null)
            {
                c = Convert.ToInt32(txtBoxInput.Text);
                f = (c * 9 / 5) + 32;
                r = c * 4 / 5;
                k = c + 273;
            }

            txtBoxOutputF.Text = Convert.ToString(f);
            txtBoxOutputR.Text = Convert.ToString(r);
            txtBoxOutputK.Text = Convert.ToString(k);
        }
    }
}
