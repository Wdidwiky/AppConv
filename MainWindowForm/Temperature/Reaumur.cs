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
    public partial class Reaumur : Form
    {
        int c, f, k, r;

        private void btnConvert_Click(object sender, EventArgs e)
        {
            r = Convert.ToInt32(txtBoxInput.Text);
            c = (r * 5) / 4;
            k = (r * 5 / 4) + 273;
            f = (r * 9 / 4) + 32;

            txtBoxOutputC.Text = Convert.ToString(c);
            txtBoxOuputF.Text = Convert.ToString(f);
            txtBoxOutputK.Text = Convert.ToString(k);
        }

        public Reaumur()
        {
            InitializeComponent();
        }
    }
}
