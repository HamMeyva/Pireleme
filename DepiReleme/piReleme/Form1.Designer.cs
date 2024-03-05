namespace piReleme
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.kacinciBas = new System.Windows.Forms.Label();
            this.basSayisi = new System.Windows.Forms.Label();
            this.form2button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(501, 88);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(274, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pirele";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(175, 402);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(302, 56);
            this.textBox2.TabIndex = 2;
            this.textBox2.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(-43, 261);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(230, 190);
            this.textBox3.TabIndex = 3;
            this.textBox3.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox4.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox4.Location = new System.Drawing.Point(495, 372);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(305, 76);
            this.textBox4.TabIndex = 4;
            this.textBox4.Visible = false;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Info;
            this.textBox5.Location = new System.Drawing.Point(583, 271);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(162, 95);
            this.textBox5.TabIndex = 5;
            this.textBox5.Visible = false;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.Red;
            this.textBox6.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox6.Location = new System.Drawing.Point(619, 21);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(126, 244);
            this.textBox6.TabIndex = 6;
            this.textBox6.Visible = false;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox7.Location = new System.Drawing.Point(112, 149);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(501, 67);
            this.textBox7.TabIndex = 7;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // kacinciBas
            // 
            this.kacinciBas.AutoSize = true;
            this.kacinciBas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.kacinciBas.Location = new System.Drawing.Point(688, 415);
            this.kacinciBas.Name = "kacinciBas";
            this.kacinciBas.Size = new System.Drawing.Size(12, 18);
            this.kacinciBas.TabIndex = 8;
            this.kacinciBas.Text = ".";
            // 
            // basSayisi
            // 
            this.basSayisi.AutoSize = true;
            this.basSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.basSayisi.Location = new System.Drawing.Point(43, 415);
            this.basSayisi.Name = "basSayisi";
            this.basSayisi.Size = new System.Drawing.Size(46, 18);
            this.basSayisi.TabIndex = 9;
            this.basSayisi.Text = "label1";
            this.basSayisi.Visible = false;
            // 
            // form2button
            // 
            this.form2button.BackColor = System.Drawing.Color.Gold;
            this.form2button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.form2button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.form2button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.form2button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.form2button.Location = new System.Drawing.Point(3, 12);
            this.form2button.Name = "form2button";
            this.form2button.Size = new System.Drawing.Size(103, 59);
            this.form2button.TabIndex = 10;
            this.form2button.Text = "DePi\'rele";
            this.form2button.UseVisualStyleBackColor = false;
            this.form2button.Click += new System.EventHandler(this.form2button_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(617, 233);
            this.Controls.Add(this.form2button);
            this.Controls.Add(this.basSayisi);
            this.Controls.Add(this.kacinciBas);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pi\'releyici";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button form2button;
        public System.Windows.Forms.Label kacinciBas;
        public System.Windows.Forms.Label basSayisi;
    }
}

