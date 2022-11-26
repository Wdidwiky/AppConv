namespace MainWindowForm.Convertion
{
    partial class Kelvin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBoxInput = new System.Windows.Forms.TextBox();
            this.txtBoxOutputC = new System.Windows.Forms.TextBox();
            this.txtBoxOutputF = new System.Windows.Forms.TextBox();
            this.txtBoxOutputR = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnConvert);
            this.panel1.Controls.Add(this.txtBoxOutputR);
            this.panel1.Controls.Add(this.txtBoxOutputF);
            this.panel1.Controls.Add(this.txtBoxOutputC);
            this.panel1.Controls.Add(this.txtBoxInput);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 356);
            this.panel1.TabIndex = 0;
            // 
            // txtBoxInput
            // 
            this.txtBoxInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxInput.Location = new System.Drawing.Point(310, 86);
            this.txtBoxInput.Name = "txtBoxInput";
            this.txtBoxInput.Size = new System.Drawing.Size(100, 20);
            this.txtBoxInput.TabIndex = 0;
            // 
            // txtBoxOutputC
            // 
            this.txtBoxOutputC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxOutputC.Location = new System.Drawing.Point(310, 171);
            this.txtBoxOutputC.Name = "txtBoxOutputC";
            this.txtBoxOutputC.Size = new System.Drawing.Size(100, 20);
            this.txtBoxOutputC.TabIndex = 1;
            // 
            // txtBoxOutputF
            // 
            this.txtBoxOutputF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxOutputF.Location = new System.Drawing.Point(310, 211);
            this.txtBoxOutputF.Name = "txtBoxOutputF";
            this.txtBoxOutputF.Size = new System.Drawing.Size(100, 20);
            this.txtBoxOutputF.TabIndex = 2;
            // 
            // txtBoxOutputR
            // 
            this.txtBoxOutputR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxOutputR.Location = new System.Drawing.Point(310, 251);
            this.txtBoxOutputR.Name = "txtBoxOutputR";
            this.txtBoxOutputR.Size = new System.Drawing.Size(100, 20);
            this.txtBoxOutputR.TabIndex = 3;
            // 
            // btnConvert
            // 
            this.btnConvert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConvert.Location = new System.Drawing.Point(241, 126);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(169, 25);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "CONVERT";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(238, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kelvin";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label2.Location = new System.Drawing.Point(238, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Celcius";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label3.Location = new System.Drawing.Point(238, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fahrenheit";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label4.Location = new System.Drawing.Point(238, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Reaumur";
            // 
            // Kelvin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(108)))), ((int)(((byte)(161)))));
            this.ClientSize = new System.Drawing.Size(648, 356);
            this.Controls.Add(this.panel1);
            this.Name = "Kelvin";
            this.Text = "Kelvin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBoxInput;
        private System.Windows.Forms.TextBox txtBoxOutputR;
        private System.Windows.Forms.TextBox txtBoxOutputF;
        private System.Windows.Forms.TextBox txtBoxOutputC;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}