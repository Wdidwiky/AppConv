namespace MainWindowForm
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnAboutUs = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.lblTopPanel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDesktopMain = new System.Windows.Forms.Panel();
            this.btnCurrency = new System.Windows.Forms.Button();
            this.btnLenght = new System.Windows.Forms.Button();
            this.btnTemp = new System.Windows.Forms.Button();
            this.btn_logo = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTopBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnAboutUs);
            this.panelMenu.Controls.Add(this.btnCurrency);
            this.panelMenu.Controls.Add(this.btnLenght);
            this.panelMenu.Controls.Add(this.btnTemp);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 496);
            this.panelMenu.TabIndex = 0;
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAboutUs.FlatAppearance.BorderSize = 0;
            this.btnAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutUs.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutUs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(108)))), ((int)(((byte)(161)))));
            this.btnAboutUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutUs.Location = new System.Drawing.Point(0, 243);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAboutUs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAboutUs.Size = new System.Drawing.Size(200, 60);
            this.btnAboutUs.TabIndex = 5;
            this.btnAboutUs.Text = "About Us";
            this.btnAboutUs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutUs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAboutUs.UseVisualStyleBackColor = true;
            this.btnAboutUs.Click += new System.EventHandler(this.btnAboutUs_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.panelLogo.Controls.Add(this.btn_logo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 63);
            this.panelLogo.TabIndex = 2;
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelTopBar.Controls.Add(this.button2);
            this.panelTopBar.Controls.Add(this.button1);
            this.panelTopBar.Controls.Add(this.btn_close);
            this.panelTopBar.Controls.Add(this.lblTopPanel);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(200, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(738, 32);
            this.panelTopBar.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(678, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(15, 15);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(699, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(15, 15);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Location = new System.Drawing.Point(720, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(15, 15);
            this.btn_close.TabIndex = 3;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTopPanel
            // 
            this.lblTopPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTopPanel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(196)))), ((int)(((byte)(206)))));
            this.lblTopPanel.Location = new System.Drawing.Point(77, 1);
            this.lblTopPanel.Name = "lblTopPanel";
            this.lblTopPanel.Size = new System.Drawing.Size(584, 32);
            this.lblTopPanel.TabIndex = 2;
            this.lblTopPanel.Text = "HOME";
            this.lblTopPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelDesktopMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(200, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 464);
            this.panel1.TabIndex = 2;
            // 
            // panelDesktopMain
            // 
            this.panelDesktopMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(108)))), ((int)(((byte)(161)))));
            this.panelDesktopMain.BackgroundImage = global::MainWindowForm.Properties.Resources.logo_besar_250;
            this.panelDesktopMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelDesktopMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopMain.Location = new System.Drawing.Point(0, 0);
            this.panelDesktopMain.Name = "panelDesktopMain";
            this.panelDesktopMain.Size = new System.Drawing.Size(738, 464);
            this.panelDesktopMain.TabIndex = 0;
            // 
            // btnCurrency
            // 
            this.btnCurrency.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCurrency.FlatAppearance.BorderSize = 0;
            this.btnCurrency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrency.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurrency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(108)))), ((int)(((byte)(161)))));
            this.btnCurrency.Image = global::MainWindowForm.Properties.Resources.mata_uang_putih;
            this.btnCurrency.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCurrency.Location = new System.Drawing.Point(0, 183);
            this.btnCurrency.Name = "btnCurrency";
            this.btnCurrency.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCurrency.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCurrency.Size = new System.Drawing.Size(200, 60);
            this.btnCurrency.TabIndex = 4;
            this.btnCurrency.Text = "Mata Uang";
            this.btnCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCurrency.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCurrency.UseVisualStyleBackColor = true;
            this.btnCurrency.Click += new System.EventHandler(this.btnCurrency_Click);
            // 
            // btnLenght
            // 
            this.btnLenght.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLenght.FlatAppearance.BorderSize = 0;
            this.btnLenght.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLenght.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLenght.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(108)))), ((int)(((byte)(161)))));
            this.btnLenght.Image = global::MainWindowForm.Properties.Resources.penggaris_putih;
            this.btnLenght.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLenght.Location = new System.Drawing.Point(0, 123);
            this.btnLenght.Name = "btnLenght";
            this.btnLenght.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLenght.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLenght.Size = new System.Drawing.Size(200, 60);
            this.btnLenght.TabIndex = 3;
            this.btnLenght.Text = "Panjang";
            this.btnLenght.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLenght.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLenght.UseVisualStyleBackColor = true;
            this.btnLenght.Click += new System.EventHandler(this.btnLenght_Click);
            // 
            // btnTemp
            // 
            this.btnTemp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTemp.FlatAppearance.BorderSize = 0;
            this.btnTemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemp.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(108)))), ((int)(((byte)(161)))));
            this.btnTemp.Image = global::MainWindowForm.Properties.Resources.suhu_putih_fix1;
            this.btnTemp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemp.Location = new System.Drawing.Point(0, 63);
            this.btnTemp.Name = "btnTemp";
            this.btnTemp.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTemp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTemp.Size = new System.Drawing.Size(200, 60);
            this.btnTemp.TabIndex = 2;
            this.btnTemp.Text = "Suhu";
            this.btnTemp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTemp.UseVisualStyleBackColor = true;
            this.btnTemp.Click += new System.EventHandler(this.btnTemp_Click);
            // 
            // btn_logo
            // 
            this.btn_logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_logo.FlatAppearance.BorderSize = 0;
            this.btn_logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logo.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold);
            this.btn_logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(196)))), ((int)(((byte)(206)))));
            this.btn_logo.Image = global::MainWindowForm.Properties.Resources.logo;
            this.btn_logo.Location = new System.Drawing.Point(0, 0);
            this.btn_logo.Name = "btn_logo";
            this.btn_logo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_logo.Size = new System.Drawing.Size(200, 63);
            this.btn_logo.TabIndex = 0;
            this.btn_logo.Text = " AppConv";
            this.btn_logo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_logo.UseVisualStyleBackColor = true;
            this.btn_logo.Click += new System.EventHandler(this.btn_logo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 496);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTopBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelTopBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnAboutUs;
        private System.Windows.Forms.Button btnCurrency;
        private System.Windows.Forms.Button btnLenght;
        private System.Windows.Forms.Button btnTemp;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Label lblTopPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelDesktopMain;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_logo;
    }
}

