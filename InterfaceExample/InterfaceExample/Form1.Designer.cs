namespace InterfaceExample
{
    partial class Form1
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
            this.btnOptellen = new System.Windows.Forms.Button();
            this.tbGetal1 = new System.Windows.Forms.TextBox();
            this.tbGetal2 = new System.Windows.Forms.TextBox();
            this.bntAftrekken = new System.Windows.Forms.Button();
            this.btnVermenigvuldigen = new System.Windows.Forms.Button();
            this.bntDelen = new System.Windows.Forms.Button();
            this.lblOptellen = new System.Windows.Forms.Label();
            this.lblAftrekken = new System.Windows.Forms.Label();
            this.lblVermenigvuldigen = new System.Windows.Forms.Label();
            this.lblDelen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOptellen
            // 
            this.btnOptellen.Location = new System.Drawing.Point(52, 107);
            this.btnOptellen.Name = "btnOptellen";
            this.btnOptellen.Size = new System.Drawing.Size(100, 23);
            this.btnOptellen.TabIndex = 0;
            this.btnOptellen.Text = "Optellen";
            this.btnOptellen.UseVisualStyleBackColor = true;
            this.btnOptellen.Click += new System.EventHandler(this.btnOptellen_Click);
            // 
            // tbGetal1
            // 
            this.tbGetal1.Location = new System.Drawing.Point(52, 36);
            this.tbGetal1.Name = "tbGetal1";
            this.tbGetal1.Size = new System.Drawing.Size(100, 20);
            this.tbGetal1.TabIndex = 2;
            this.tbGetal1.Text = "10";
            // 
            // tbGetal2
            // 
            this.tbGetal2.Location = new System.Drawing.Point(179, 36);
            this.tbGetal2.Name = "tbGetal2";
            this.tbGetal2.Size = new System.Drawing.Size(100, 20);
            this.tbGetal2.TabIndex = 3;
            this.tbGetal2.Text = "5";
            // 
            // bntAftrekken
            // 
            this.bntAftrekken.Location = new System.Drawing.Point(52, 136);
            this.bntAftrekken.Name = "bntAftrekken";
            this.bntAftrekken.Size = new System.Drawing.Size(100, 23);
            this.bntAftrekken.TabIndex = 4;
            this.bntAftrekken.Text = "Aftrekken";
            this.bntAftrekken.UseVisualStyleBackColor = true;
            this.bntAftrekken.Click += new System.EventHandler(this.bntAftrekken_Click);
            // 
            // btnVermenigvuldigen
            // 
            this.btnVermenigvuldigen.Location = new System.Drawing.Point(52, 165);
            this.btnVermenigvuldigen.Name = "btnVermenigvuldigen";
            this.btnVermenigvuldigen.Size = new System.Drawing.Size(100, 23);
            this.btnVermenigvuldigen.TabIndex = 6;
            this.btnVermenigvuldigen.Text = "Vermenigvuldigen";
            this.btnVermenigvuldigen.UseVisualStyleBackColor = true;
            // 
            // bntDelen
            // 
            this.bntDelen.Location = new System.Drawing.Point(52, 194);
            this.bntDelen.Name = "bntDelen";
            this.bntDelen.Size = new System.Drawing.Size(100, 23);
            this.bntDelen.TabIndex = 7;
            this.bntDelen.Text = "Delen";
            this.bntDelen.UseVisualStyleBackColor = true;
            // 
            // lblOptellen
            // 
            this.lblOptellen.AutoSize = true;
            this.lblOptellen.Location = new System.Drawing.Point(176, 112);
            this.lblOptellen.Name = "lblOptellen";
            this.lblOptellen.Size = new System.Drawing.Size(35, 13);
            this.lblOptellen.TabIndex = 8;
            this.lblOptellen.Text = "label1";
            // 
            // lblAftrekken
            // 
            this.lblAftrekken.AutoSize = true;
            this.lblAftrekken.Location = new System.Drawing.Point(176, 141);
            this.lblAftrekken.Name = "lblAftrekken";
            this.lblAftrekken.Size = new System.Drawing.Size(35, 13);
            this.lblAftrekken.TabIndex = 9;
            this.lblAftrekken.Text = "label1";
            // 
            // lblVermenigvuldigen
            // 
            this.lblVermenigvuldigen.AutoSize = true;
            this.lblVermenigvuldigen.Location = new System.Drawing.Point(176, 170);
            this.lblVermenigvuldigen.Name = "lblVermenigvuldigen";
            this.lblVermenigvuldigen.Size = new System.Drawing.Size(35, 13);
            this.lblVermenigvuldigen.TabIndex = 10;
            this.lblVermenigvuldigen.Text = "label1";
            // 
            // lblDelen
            // 
            this.lblDelen.AutoSize = true;
            this.lblDelen.Location = new System.Drawing.Point(176, 199);
            this.lblDelen.Name = "lblDelen";
            this.lblDelen.Size = new System.Drawing.Size(35, 13);
            this.lblDelen.TabIndex = 11;
            this.lblDelen.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDelen);
            this.Controls.Add(this.lblVermenigvuldigen);
            this.Controls.Add(this.lblAftrekken);
            this.Controls.Add(this.lblOptellen);
            this.Controls.Add(this.bntDelen);
            this.Controls.Add(this.btnVermenigvuldigen);
            this.Controls.Add(this.bntAftrekken);
            this.Controls.Add(this.tbGetal2);
            this.Controls.Add(this.tbGetal1);
            this.Controls.Add(this.btnOptellen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOptellen;
        private System.Windows.Forms.TextBox tbGetal1;
        private System.Windows.Forms.TextBox tbGetal2;
        private System.Windows.Forms.Button bntAftrekken;
        private System.Windows.Forms.Button btnVermenigvuldigen;
        private System.Windows.Forms.Button bntDelen;
        private System.Windows.Forms.Label lblOptellen;
        private System.Windows.Forms.Label lblAftrekken;
        private System.Windows.Forms.Label lblVermenigvuldigen;
        private System.Windows.Forms.Label lblDelen;
    }
}

