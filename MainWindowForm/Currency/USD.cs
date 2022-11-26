using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainWindowForm.Currency
{
    public partial class USD : Form
    {
        double Rp, Euro, US_dolar, Yen, Ringgit, EUR_batas, IDR_batas, JPY_batas, MYR_batas;
        public USD()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (txtBoxInput.Text != null)
            {
                US_dolar = Convert.ToDouble(txtBoxInput.Text);
                Rp = US_dolar * 15646.75;
                Euro = US_dolar * 0.96;
                Yen = US_dolar * 139.10;
                Ringgit = US_dolar * 4.50;
                IDR_batas = Math.Round(Rp, 2);
                EUR_batas = Math.Round(Euro, 2);
                JPY_batas = Math.Round(Yen, 2);
                MYR_batas = Math.Round(Ringgit, 2);
            }

            txtBoxOuputIDR.Text = Convert.ToString(IDR_batas);
            txtBoxOuputEUR.Text = Convert.ToString(EUR_batas);
            txtBoxOuputJPY.Text = Convert.ToString(JPY_batas);
            txtBoxOuputMYR.Text = Convert.ToString(MYR_batas);

        }
    }
}
