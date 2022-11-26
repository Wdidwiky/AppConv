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
    public partial class MYR : Form
    {
        double Rp, Euro, US_dolar, Yen, Ringgit, USD_batas, IDR_batas, EUR_batas, JPY_batas;
        public MYR()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (txtBoxInput.Text != null)
            {
                Ringgit = Convert.ToDouble(txtBoxInput.Text);
                Rp = Ringgit * 3483.41;
                US_dolar = Ringgit / 4.49;
                Euro = Ringgit / 4.68;
                Yen = Ringgit * 30.87;

                IDR_batas = Math.Round(Rp, 2);
                EUR_batas = Math.Round(Euro, 2);
                USD_batas = Math.Round(US_dolar, 2);
                JPY_batas = Math.Round(Yen, 2);
            }

            txtBoxOutputIDR.Text = Convert.ToString(IDR_batas);
            txtBoxOutputUSD.Text = Convert.ToString(USD_batas);
            txtBoxOutputEUR.Text = Convert.ToString(EUR_batas);
            txtBoxOutputJPY.Text = Convert.ToString(JPY_batas);
        }
    }
}
