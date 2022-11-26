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
    public partial class JPY : Form
    {
        double Rp, Euro, US_dolar, Yen, Ringgit, USD_batas, IDR_batas, EUR_batas, MYR_batas;
        public JPY()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (txtBoxInput.Text != null)
            {
                Yen = Convert.ToDouble(txtBoxInput.Text);
                Rp = Yen * 112.82;
                US_dolar = Yen / 138.70;
                Euro = Yen / 144.49;
                Ringgit = Yen / 30.87;

                IDR_batas = Math.Round(Rp, 2);
                EUR_batas = Math.Round(Euro, 2);
                USD_batas = Math.Round(US_dolar, 2);
                MYR_batas = Math.Round(Ringgit, 2);
            }

            txtBoxOutputIDR.Text = Convert.ToString(IDR_batas);
            txtBoxOutputUSD.Text = Convert.ToString(USD_batas);
            txtBoxOutputEUR.Text = Convert.ToString(EUR_batas);
            txtBoxOutputMYR.Text = Convert.ToString(MYR_batas);
        }
    }
}
