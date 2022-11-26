namespace MainWindowForm.Currency
{
    partial class EUR
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
            this.txtBoxInput = new System.Windows.Forms.TextBox();
            this.txtBoxOutputIDR = new System.Windows.Forms.TextBox();
            this.txtBoxOutputUSD = new System.Windows.Forms.TextBox();
            this.txtBoxOutputJPY = new System.Windows.Forms.TextBox();
            this.txtBoxOutputMYR = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxInput
            // 
            this.txtBoxInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxInput.Location = new System.Drawing.Point(278, 98);
            this.txtBoxInput.Name = "txtBoxInput";
            this.txtBoxInput.Size = new System.Drawing.Size(100, 20);
            this.txtBoxInput.TabIndex = 0;
            // 
            // txtBoxOutputIDR
            // 
            this.txtBoxOutputIDR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxOutputIDR.Location = new System.Drawing.Point(32, 202);
            this.txtBoxOutputIDR.Name = "txtBoxOutputIDR";
            this.txtBoxOutputIDR.Size = new System.Drawing.Size(100, 20);
            this.txtBoxOutputIDR.TabIndex = 1;
            // 
            // txtBoxOutputUSD
            // 
            this.txtBoxOutputUSD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxOutputUSD.Location = new System.Drawing.Point(196, 202);
            this.txtBoxOutputUSD.Name = "txtBoxOutputUSD";
            this.txtBoxOutputUSD.Size = new System.Drawing.Size(100, 20);
            this.txtBoxOutputUSD.TabIndex = 2;
            // 
            // txtBoxOutputJPY
            // 
            this.txtBoxOutputJPY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxOutputJPY.Location = new System.Drawing.Point(360, 202);
            this.txtBoxOutputJPY.Name = "txtBoxOutputJPY";
            this.txtBoxOutputJPY.Size = new System.Drawing.Size(100, 20);
            this.txtBoxOutputJPY.TabIndex = 3;
            // 
            // txtBoxOutputMYR
            // 
            this.txtBoxOutputMYR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxOutputMYR.Location = new System.Drawing.Point(524, 202);
            this.txtBoxOutputMYR.Name = "txtBoxOutputMYR";
            this.txtBoxOutputMYR.Size = new System.Drawing.Size(100, 20);
            this.txtBoxOutputMYR.TabIndex = 4;
            // 
            // btnConvert
            // 
            this.btnConvert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConvert.Location = new System.Drawing.Point(278, 133);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(100, 25);
            this.btnConvert.TabIndex = 5;
            this.btnConvert.Text = "CONVERT";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(278, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Euro";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label2.Location = new System.Drawing.Point(32, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Rupiah";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label3.Location = new System.Drawing.Point(196, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "US Dolar";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label4.Location = new System.Drawing.Point(360, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Yen";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label5.Location = new System.Drawing.Point(524, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ringgit";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EUR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(108)))), ((int)(((byte)(161)))));
            this.ClientSize = new System.Drawing.Size(656, 356);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtBoxOutputMYR);
            this.Controls.Add(this.txtBoxOutputJPY);
            this.Controls.Add(this.txtBoxOutputUSD);
            this.Controls.Add(this.txtBoxOutputIDR);
            this.Controls.Add(this.txtBoxInput);
            this.Name = "EUR";
            this.Text = "EUR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxInput;
        private System.Windows.Forms.TextBox txtBoxOutputIDR;
        private System.Windows.Forms.TextBox txtBoxOutputUSD;
        private System.Windows.Forms.TextBox txtBoxOutputJPY;
        private System.Windows.Forms.TextBox txtBoxOutputMYR;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}