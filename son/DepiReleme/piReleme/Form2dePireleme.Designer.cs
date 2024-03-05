namespace piReleme
{
    partial class Form2dePireleme
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
            this.toplam = new System.Windows.Forms.Label();
            this.kacBasamak = new System.Windows.Forms.Label();
            this.denItibaren = new System.Windows.Forms.Label();
            this.dePirele = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.mesaj = new System.Windows.Forms.TextBox();
            this.sonmesajBinary = new System.Windows.Forms.TextBox();
            this.yenile = new System.Windows.Forms.Button();
            this.okunanMesaj = new System.Windows.Forms.TextBox();
            this.mesjKarakter = new System.Windows.Forms.Label();
            this.karakterler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // toplam
            // 
            this.toplam.AutoSize = true;
            this.toplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.toplam.Location = new System.Drawing.Point(12, 421);
            this.toplam.Name = "toplam";
            this.toplam.Size = new System.Drawing.Size(59, 20);
            this.toplam.TabIndex = 0;
            this.toplam.Text = "00000";
            // 
            // kacBasamak
            // 
            this.kacBasamak.AutoSize = true;
            this.kacBasamak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.kacBasamak.Location = new System.Drawing.Point(368, 421);
            this.kacBasamak.Name = "kacBasamak";
            this.kacBasamak.Size = new System.Drawing.Size(59, 20);
            this.kacBasamak.TabIndex = 1;
            this.kacBasamak.Text = "label2";
            // 
            // denItibaren
            // 
            this.denItibaren.AutoSize = true;
            this.denItibaren.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.denItibaren.Location = new System.Drawing.Point(706, 421);
            this.denItibaren.Name = "denItibaren";
            this.denItibaren.Size = new System.Drawing.Size(59, 20);
            this.denItibaren.TabIndex = 2;
            this.denItibaren.Text = "00000";
            // 
            // dePirele
            // 
            this.dePirele.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dePirele.Location = new System.Drawing.Point(322, 222);
            this.dePirele.Name = "dePirele";
            this.dePirele.Size = new System.Drawing.Size(132, 41);
            this.dePirele.TabIndex = 3;
            this.dePirele.Text = "Depirele";
            this.dePirele.UseVisualStyleBackColor = true;
            this.dePirele.Click += new System.EventHandler(this.dePirele_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(210, 128);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(364, 88);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.No;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(762, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mesaj
            // 
            this.mesaj.BackColor = System.Drawing.SystemColors.HotTrack;
            this.mesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.mesaj.Location = new System.Drawing.Point(210, 32);
            this.mesaj.Multiline = true;
            this.mesaj.Name = "mesaj";
            this.mesaj.Size = new System.Drawing.Size(364, 72);
            this.mesaj.TabIndex = 6;
            // 
            // sonmesajBinary
            // 
            this.sonmesajBinary.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sonmesajBinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.sonmesajBinary.Location = new System.Drawing.Point(635, 144);
            this.sonmesajBinary.Multiline = true;
            this.sonmesajBinary.Name = "sonmesajBinary";
            this.sonmesajBinary.Size = new System.Drawing.Size(130, 72);
            this.sonmesajBinary.TabIndex = 7;
            this.sonmesajBinary.TextChanged += new System.EventHandler(this.sonmesajBinary_TextChanged);
            // 
            // yenile
            // 
            this.yenile.BackColor = System.Drawing.Color.Lime;
            this.yenile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yenile.Cursor = System.Windows.Forms.Cursors.No;
            this.yenile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yenile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.yenile.Location = new System.Drawing.Point(721, 1);
            this.yenile.Name = "yenile";
            this.yenile.Size = new System.Drawing.Size(35, 36);
            this.yenile.TabIndex = 8;
            this.yenile.Text = "O";
            this.yenile.UseVisualStyleBackColor = false;
            this.yenile.Click += new System.EventHandler(this.yenile_Click);
            // 
            // okunanMesaj
            // 
            this.okunanMesaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.okunanMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.okunanMesaj.Location = new System.Drawing.Point(210, 278);
            this.okunanMesaj.Multiline = true;
            this.okunanMesaj.Name = "okunanMesaj";
            this.okunanMesaj.Size = new System.Drawing.Size(364, 72);
            this.okunanMesaj.TabIndex = 9;
            // 
            // mesjKarakter
            // 
            this.mesjKarakter.AutoSize = true;
            this.mesjKarakter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.mesjKarakter.Location = new System.Drawing.Point(673, 222);
            this.mesjKarakter.Name = "mesjKarakter";
            this.mesjKarakter.Size = new System.Drawing.Size(39, 20);
            this.mesjKarakter.TabIndex = 10;
            this.mesjKarakter.Text = "bos";
            // 
            // karakterler
            // 
            this.karakterler.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.karakterler.FormattingEnabled = true;
            this.karakterler.Location = new System.Drawing.Point(42, 94);
            this.karakterler.Name = "karakterler";
            this.karakterler.Size = new System.Drawing.Size(120, 160);
            this.karakterler.TabIndex = 11;
            // 
            // Form2dePireleme
            // 
            this.AcceptButton = this.dePirele;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.karakterler);
            this.Controls.Add(this.mesjKarakter);
            this.Controls.Add(this.okunanMesaj);
            this.Controls.Add(this.yenile);
            this.Controls.Add(this.sonmesajBinary);
            this.Controls.Add(this.mesaj);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dePirele);
            this.Controls.Add(this.denItibaren);
            this.Controls.Add(this.kacBasamak);
            this.Controls.Add(this.toplam);
            this.Name = "Form2dePireleme";
            this.Text = "Form2dePireleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label toplam;
        private System.Windows.Forms.Label kacBasamak;
        private System.Windows.Forms.Label denItibaren;
        private System.Windows.Forms.Button dePirele;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox mesaj;
        private System.Windows.Forms.TextBox sonmesajBinary;
        private System.Windows.Forms.Button yenile;
        private System.Windows.Forms.TextBox okunanMesaj;
        private System.Windows.Forms.Label mesjKarakter;
        private System.Windows.Forms.ListBox karakterler;
    }
}