namespace GelismisHesapMakinesi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbislem = new System.Windows.Forms.ComboBox();
            this.nudSayi1 = new System.Windows.Forms.NumericUpDown();
            this.nudSayi2 = new System.Windows.Forms.NumericUpDown();
            this.btnSonuc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSayi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSayi2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1.sayi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Islem";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "2.sayi";
            // 
            // cmbislem
            // 
            this.cmbislem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbislem.FormattingEnabled = true;
            this.cmbislem.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "%"});
            this.cmbislem.Location = new System.Drawing.Point(98, 71);
            this.cmbislem.Name = "cmbislem";
            this.cmbislem.Size = new System.Drawing.Size(100, 21);
            this.cmbislem.TabIndex = 5;
            // 
            // nudSayi1
            // 
            this.nudSayi1.Location = new System.Drawing.Point(98, 33);
            this.nudSayi1.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.nudSayi1.Minimum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            -2147483648});
            this.nudSayi1.Name = "nudSayi1";
            this.nudSayi1.Size = new System.Drawing.Size(100, 20);
            this.nudSayi1.TabIndex = 6;
            // 
            // nudSayi2
            // 
            this.nudSayi2.Location = new System.Drawing.Point(98, 112);
            this.nudSayi2.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.nudSayi2.Minimum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            -2147483648});
            this.nudSayi2.Name = "nudSayi2";
            this.nudSayi2.Size = new System.Drawing.Size(100, 20);
            this.nudSayi2.TabIndex = 7;
            // 
            // btnSonuc
            // 
            this.btnSonuc.Location = new System.Drawing.Point(123, 154);
            this.btnSonuc.Name = "btnSonuc";
            this.btnSonuc.Size = new System.Drawing.Size(75, 23);
            this.btnSonuc.TabIndex = 8;
            this.btnSonuc.Text = "Sonuc";
            this.btnSonuc.UseVisualStyleBackColor = true;
            this.btnSonuc.Click += new System.EventHandler(this.btnSonuc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sonuc:";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(120, 202);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(0, 13);
            this.lblSonuc.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSonuc);
            this.Controls.Add(this.nudSayi2);
            this.Controls.Add(this.nudSayi1);
            this.Controls.Add(this.cmbislem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSayi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSayi2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbislem;
        private System.Windows.Forms.NumericUpDown nudSayi1;
        private System.Windows.Forms.NumericUpDown nudSayi2;
        private System.Windows.Forms.Button btnSonuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSonuc;
    }
}

