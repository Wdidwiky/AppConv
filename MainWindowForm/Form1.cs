using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainWindowForm
{
    public partial class MainForm : Form
    {
        //Fields
        private Button currentButton;
        private Form activeForm;
        private bool swap_temp;
        private bool swap_lenght;
        private bool swap_curr;

        public MainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void ActivatedButton(object btnSender, bool swap_temp, bool swap_lenght, bool swap_curr)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(117,108, 161);
                    currentButton.ForeColor = Color.FromArgb(51, 51, 76);
                    currentButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    if (swap_temp == true)
                    {
                        this.btnTemp.Image = global::MainWindowForm.Properties.Resources.suhu_ungu_fix;
                    }
                    else if (swap_lenght == true)
                    {
                        this.btnLenght.Image = global::MainWindowForm.Properties.Resources.penggaris_ungu;
                    }
                    else if (swap_curr == true)
                    {
                        this.btnCurrency.Image = global::MainWindowForm.Properties.Resources.mata_uang_ungu;
                    }
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control preveousBtn in panelMenu.Controls)
            {
                if (preveousBtn.GetType() == typeof(Button))
                {
                    preveousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    preveousBtn.ForeColor = Color.FromArgb(117, 108, 161);
                    this.btnTemp.Image = global::MainWindowForm.Properties.Resources.suhu_putih_fix1;
                    this.btnLenght.Image = global::MainWindowForm.Properties.Resources.penggaris_putih;
                    this.btnCurrency.Image = global::MainWindowForm.Properties.Resources.mata_uang_putih;
                    preveousBtn.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenCHildForm(Form childForm, object btnSender, bool swap_temp, bool swap_lenght, bool swap_curr)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivatedButton(btnSender, swap_temp, swap_lenght, swap_curr);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopMain.Controls.Add(childForm);
            this.panelDesktopMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTopPanel.Text = childForm.Text;
        }

        private void OpenCHildForm1(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopMain.Controls.Add(childForm);
            this.panelDesktopMain.Tag = childForm;
            lblTopPanel.Text = "HOME";
        }

        private void btnTemp_Click(object sender, EventArgs e)
        {
            swap_temp = true;
            swap_lenght = false;
            swap_curr = false;
            OpenCHildForm(new Temperature.Conv(), sender, swap_temp, swap_lenght, swap_curr);
        }

        private void btnLenght_Click(object sender, EventArgs e)
        {
            swap_temp = false;
            swap_lenght = true;
            swap_curr = false;
            OpenCHildForm(new Lenght.Conv(), sender, swap_temp, swap_lenght, swap_curr);
        }

        private void btnCurrency_Click(object sender, EventArgs e)
        {
            swap_temp = false;
            swap_lenght = false;
            swap_curr = true;
            OpenCHildForm(new Currency.Conv(), sender, swap_temp, swap_lenght, swap_curr);
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            swap_temp = false;
            swap_lenght = false;
            swap_curr = false;
            OpenCHildForm(new AboutUs(), sender, swap_temp, swap_lenght, swap_curr);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btn_logo_Click(object sender, EventArgs e)
        {
            OpenCHildForm1(new home(), sender);
        }
    }
}
