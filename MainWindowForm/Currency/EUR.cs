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
    public partial class EUR : Form
    {
        double Rp, Euro, US_dolar, Yen, Ringgit, USD_batas, IDR_batas, JPY_batas, MYR_batas;
        public EUR()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (txtBoxInput.Text != null)
            {
                Euro = Convert.ToDouble(txtBoxInput.Text);
                Rp = Euro * 16297;
                US_dolar = Euro * 1.04;
                Yen = Euro * 144.49;
                Ringgit = Euro * 4.68;

                IDR_batas = Math.Round(Rp, 2);
                USD_batas = Math.Round(US_dolar, 2);
                JPY_batas = Math.Round(Yen, 2);
                MYR_batas = Math.Round(Ringgit, 2);
            }

            txtBoxOutputIDR.Text = Convert.ToString(IDR_batas);
            txtBoxOutputUSD.Text = Convert.ToString(USD_batas);
            txtBoxOutputJPY.Text = Convert.ToString(JPY_batas);
            txtBoxOutputMYR.Text = Convert.ToString(MYR_batas);
        }
    }
}
