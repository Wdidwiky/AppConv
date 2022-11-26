namespace MainWindowForm.Temperature
{
    partial class Conv
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.btn_Kelvin = new System.Windows.Forms.Button();
            this.btn_Reaumur = new System.Windows.Forms.Button();
            this.btn_Fahrenheit = new System.Windows.Forms.Button();
            this.btn_Celcius = new System.Windows.Forms.Button();
            this.panelDisplay = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelTop.Controls.Add(this.btn_Kelvin);
            this.panelTop.Controls.Add(this.btn_Reaumur);
            this.panelTop.Controls.Add(this.btn_Fahrenheit);
            this.panelTop.Controls.Add(this.btn_Celcius);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(748, 31);
            this.panelTop.TabIndex = 0;
            // 
            // btn_Kelvin
            // 
            this.btn_Kelvin.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.btn_Kelvin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Kelvin.FlatAppearance.BorderSize = 0;
            this.btn_Kelvin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Kelvin.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Kelvin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(108)))), ((int)(((byte)(161)))));
            this.btn_Kelvin.Location = new System.Drawing.Point(561, 0);
            this.btn_Kelvin.Name = "btn_Kelvin";
            this.btn_Kelvin.Size = new System.Drawing.Size(187, 31);
            this.btn_Kelvin.TabIndex = 2;
            this.btn_Kelvin.Text = "Kelvin";
            this.btn_Kelvin.UseVisualStyleBackColor = true;
            this.btn_Kelvin.Click += new System.EventHandler(this.btn_Kelvin_Click);
            // 
            // btn_Reaumur
            // 
            this.btn_Reaumur.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.btn_Reaumur.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Reaumur.FlatAppearance.BorderSize = 0;
            this.btn_Reaumur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reaumur.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Reaumur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(108)))), ((int)(((byte)(161)))));
            this.btn_Reaumur.Location = new System.Drawing.Point(374, 0);
            this.btn_Reaumur.Name = "btn_Reaumur";
            this.btn_Reaumur.Size = new System.Drawing.Size(187, 31);
            this.btn_Reaumur.TabIndex = 2;
            this.btn_Reaumur.Text = "Reaumur";
            this.btn_Reaumur.UseVisualStyleBackColor = true;
            this.btn_Reaumur.Click += new System.EventHandler(this.btn_Reaumur_Click);
            // 
            // btn_Fahrenheit
            // 
            this.btn_Fahrenheit.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.btn_Fahrenheit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Fahrenheit.FlatAppearance.BorderSize = 0;
            this.btn_Fahrenheit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fahrenheit.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Fahrenheit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(108)))), ((int)(((byte)(161)))));
            this.btn_Fahrenheit.Location = new System.Drawing.Point(187, 0);
            this.btn_Fahrenheit.Name = "btn_Fahrenheit";
            this.btn_Fahrenheit.Size = new System.Drawing.Size(187, 31);
            this.btn_Fahrenheit.TabIndex = 3;
            this.btn_Fahrenheit.Text = "Fahrenheit";
            this.btn_Fahrenheit.UseVisualStyleBackColor = true;
            this.btn_Fahrenheit.Click += new System.EventHandler(this.btn_Fahrenheit_Click);
            // 
            // btn_Celcius
            // 
            this.btn_Celcius.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.btn_Celcius.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Celcius.FlatAppearance.BorderSize = 0;
            this.btn_Celcius.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Celcius.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Celcius.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(108)))), ((int)(((byte)(161)))));
            this.btn_Celcius.Location = new System.Drawing.Point(0, 0);
            this.btn_Celcius.Name = "btn_Celcius";
            this.btn_Celcius.Size = new System.Drawing.Size(187, 31);
            this.btn_Celcius.TabIndex = 1;
            this.btn_Celcius.Text = "Celcius";
            this.btn_Celcius.UseVisualStyleBackColor = true;
            this.btn_Celcius.Click += new System.EventHandler(this.btn_Celcius_Click);
            // 
            // panelDisplay
            // 
            this.panelDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(108)))), ((int)(((byte)(161)))));
            this.panelDisplay.BackgroundImage = global::MainWindowForm.Properties.Resources.logo_besar_250;
            this.panelDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDisplay.Location = new System.Drawing.Point(0, 31);
            this.panelDisplay.Name = "panelDisplay";
            this.panelDisplay.Size = new System.Drawing.Size(748, 347);
            this.panelDisplay.TabIndex = 1;
            // 
            // Conv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(108)))), ((int)(((byte)(161)))));
            this.ClientSize = new System.Drawing.Size(748, 378);
            this.Controls.Add(this.panelDisplay);
            this.Controls.Add(this.panelTop);
            this.Name = "Conv";
            this.Text = "Konversi Suhu";
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btn_Celcius;
        private System.Windows.Forms.Button btn_Kelvin;
        private System.Windows.Forms.Button btn_Reaumur;
        private System.Windows.Forms.Button btn_Fahrenheit;
        private System.Windows.Forms.Panel panelDisplay;
    }
}