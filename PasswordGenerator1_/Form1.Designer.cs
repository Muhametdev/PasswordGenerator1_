namespace PasswordGenerator1_
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.numSifre = new System.Windows.Forms.NumericUpDown();
            this.numSifreUzun = new System.Windows.Forms.NumericUpDown();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numSifre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSifreUzun)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(393, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Şifre Oluştur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(49, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(143, 29);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Şifre Uzunluğu:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(49, 163);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(143, 29);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Şifreler:";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(49, 56);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(143, 29);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = "Şifre Sayısı:";
            // 
            // numSifre
            // 
            this.numSifre.Location = new System.Drawing.Point(244, 65);
            this.numSifre.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSifre.Name = "numSifre";
            this.numSifre.Size = new System.Drawing.Size(120, 20);
            this.numSifre.TabIndex = 2;
            this.numSifre.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numSifreUzun
            // 
            this.numSifreUzun.Location = new System.Drawing.Point(244, 122);
            this.numSifreUzun.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numSifreUzun.Name = "numSifreUzun";
            this.numSifreUzun.Size = new System.Drawing.Size(120, 20);
            this.numSifreUzun.TabIndex = 2;
            this.numSifreUzun.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // txtSonuc
            // 
            this.txtSonuc.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSonuc.Location = new System.Drawing.Point(232, 163);
            this.txtSonuc.Multiline = true;
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.ReadOnly = true;
            this.txtSonuc.Size = new System.Drawing.Size(332, 186);
            this.txtSonuc.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 409);
            this.Controls.Add(this.numSifreUzun);
            this.Controls.Add(this.numSifre);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numSifre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSifreUzun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.NumericUpDown numSifre;
        private System.Windows.Forms.NumericUpDown numSifreUzun;
        private System.Windows.Forms.TextBox txtSonuc;
    }
}

