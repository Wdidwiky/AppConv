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
    public partial class IDR : Form
    {
        double Rp, Euro, US_dolar, Yen, Ringgit,EUR_batas,USD_batas,JPY_batas,MYR_batas;
        public IDR()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if(txtBoxInput.Text!=null)
            {
                Rp = Convert.ToDouble(txtBoxInput.Text);
                Euro = Rp / 16321.92;
                US_dolar = Rp / 15646.75;
                Yen = Rp / 112.83;
                Ringgit = Rp / 3487.90;
                EUR_batas = Math.Round(Euro, 2);
                USD_batas = Math.Round(US_dolar, 2);
                JPY_batas = Math.Round(Yen, 2);
                MYR_batas = Math.Round(Ringgit, 2);
            }

            txtBoxOutputEUR.Text = Convert.ToString(EUR_batas);
            txtBoxOutputUSD.Text = Convert.ToString(USD_batas);
            txtBoxOutputJPY.Text = Convert.ToString(JPY_batas);
            txtBoxOutputMYR.Text = Convert.ToString(MYR_batas);
        }

    }
}
