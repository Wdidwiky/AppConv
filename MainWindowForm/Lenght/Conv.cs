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
    public partial class Conv : Form
    {
        private Button currentButton;
        private Form activeForm;

        public Conv()
        {
            InitializeComponent();
        }

        private void ActivatedButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(117, 108, 161);
                    currentButton.ForeColor = Color.FromArgb(51, 51, 76);
                    currentButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control preveousBtn in panelTop.Controls)
            {
                if (preveousBtn.GetType() == typeof(Button))
                {
                    preveousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    preveousBtn.ForeColor = Color.FromArgb(117, 108, 161);
                    preveousBtn.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenCHildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivatedButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(childForm);
            this.panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_km_Click(object sender, EventArgs e)
        {
            OpenCHildForm(new Lenght.kilometer(),sender);
        }

        private void btn_hm_Click(object sender, EventArgs e)
        {
            OpenCHildForm(new Lenght.hektometer(), sender);
        }

        private void btn_dam_Click(object sender, EventArgs e)
        {
            OpenCHildForm(new Lenght.dekameter(), sender);
        }

        private void btn_m_Click(object sender, EventArgs e)
        {
            OpenCHildForm(new Lenght.meter(), sender);
        }

        private void btn_dm_Click(object sender, EventArgs e)
        {
            OpenCHildForm(new Lenght.desimeter(), sender);
        }

        private void btn_cm_Click(object sender, EventArgs e)
        {
            OpenCHildForm(new Lenght.centimeter(), sender);
        }

        private void btn_mm_Click(object sender, EventArgs e)
        {
            OpenCHildForm(new Lenght.milimeter(), sender);
        }
    }
}
