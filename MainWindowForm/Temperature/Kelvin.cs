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
    public partial class Kelvin : Form
    {
        int c, f, k, r;

        private void btnConvert_Click(object sender, EventArgs e)
        {
            k = Convert.ToInt32(txtBoxInput.Text);
            c = k - 273;
            f = (k - 273) * 9 / 5 + 32;
            r = (k - 273) * 4 / 5;

            txtBoxOutputC.Text = Convert.ToString(c);
            txtBoxOutputF.Text = Convert.ToString(f);
            txtBoxOutputR.Text = Convert.ToString(r);
        }

        public Kelvin()
        {
            InitializeComponent();
        }
    }
}
