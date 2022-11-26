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
    public partial class Fahrenheit : Form
    {
        int c, f, r, k;

        private void btnConvert_Click(object sender, EventArgs e)
        {
            f = Convert.ToInt32(txtBoxInput.Text);
            c = (f - 32) * 5 / 9;
            r = (f - 32) * 4 / 9;
            k = (f - 32) * 5 / 9 + 273;

            txtBoxOutputC.Text = Convert.ToString(c);
            txtBoxOutputR.Text = Convert.ToString(r);
            txtBoxOutputK.Text = Convert.ToString(k);
        }

        public Fahrenheit()
        {
            InitializeComponent();
        }
    }
}
