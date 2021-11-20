namespace P3_4_1204055
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.cbJk = new System.Windows.Forms.ComboBox();
            this.dtTgl = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbKomposer = new System.Windows.Forms.CheckBox();
            this.cbVokal = new System.Windows.Forms.CheckBox();
            this.drum = new System.Windows.Forms.CheckBox();
            this.cbPiano = new System.Windows.Forms.CheckBox();
            this.cbKonduktor = new System.Windows.Forms.CheckBox();
            this.cbSaxophone = new System.Windows.Forms.CheckBox();
            this.cbGitar = new System.Windows.Forms.CheckBox();
            this.cbBiola = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbMinggu = new System.Windows.Forms.RadioButton();
            this.rbSelasakamis = new System.Windows.Forms.RadioButton();
            this.rbSabtuminggu = new System.Windows.Forms.RadioButton();
            this.rbSeninrabu = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btTampilan = new System.Windows.Forms.Button();
            this.btSelesai = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(186, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama                  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(186, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jenis Kelamin      :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(186, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tanggal Lahir      :";
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(298, 75);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(150, 20);
            this.tbNama.TabIndex = 3;
            // 
            // cbJk
            // 
            this.cbJk.FormattingEnabled = true;
            this.cbJk.Items.AddRange(new object[] {
            "Laki-laki",
            "Perempuan"});
            this.cbJk.Location = new System.Drawing.Point(298, 106);
            this.cbJk.Name = "cbJk";
            this.cbJk.Size = new System.Drawing.Size(121, 21);
            this.cbJk.TabIndex = 4;
            this.cbJk.Text = "-- pilih jenis kelamin --";
            // 
            // dtTgl
            // 
            this.dtTgl.CustomFormat = "";
            this.dtTgl.Location = new System.Drawing.Point(298, 140);
            this.dtTgl.Name = "dtTgl";
            this.dtTgl.Size = new System.Drawing.Size(200, 20);
            this.dtTgl.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbKomposer);
            this.groupBox1.Controls.Add(this.cbVokal);
            this.groupBox1.Controls.Add(this.drum);
            this.groupBox1.Controls.Add(this.cbPiano);
            this.groupBox1.Controls.Add(this.cbKonduktor);
            this.groupBox1.Controls.Add(this.cbSaxophone);
            this.groupBox1.Controls.Add(this.cbGitar);
            this.groupBox1.Controls.Add(this.cbBiola);
            this.groupBox1.Location = new System.Drawing.Point(30, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 200);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PIlihan Kelas";
            // 
            // cbKomposer
            // 
            this.cbKomposer.AutoSize = true;
            this.cbKomposer.Location = new System.Drawing.Point(184, 152);
            this.cbKomposer.Name = "cbKomposer";
            this.cbKomposer.Size = new System.Drawing.Size(73, 17);
            this.cbKomposer.TabIndex = 7;
            this.cbKomposer.Text = "Komposer\r\n";
            this.cbKomposer.UseVisualStyleBackColor = true;
            // 
            // cbVokal
            // 
            this.cbVokal.AutoSize = true;
            this.cbVokal.Location = new System.Drawing.Point(184, 112);
            this.cbVokal.Name = "cbVokal";
            this.cbVokal.Size = new System.Drawing.Size(53, 17);
            this.cbVokal.TabIndex = 6;
            this.cbVokal.Text = "Vokal\r\n";
            this.cbVokal.UseVisualStyleBackColor = true;
            // 
            // drum
            // 
            this.drum.AutoSize = true;
            this.drum.Location = new System.Drawing.Point(184, 72);
            this.drum.Name = "drum";
            this.drum.Size = new System.Drawing.Size(51, 17);
            this.drum.TabIndex = 5;
            this.drum.Text = "Drum";
            this.drum.UseVisualStyleBackColor = true;
            // 
            // cbPiano
            // 
            this.cbPiano.AutoSize = true;
            this.cbPiano.Location = new System.Drawing.Point(184, 32);
            this.cbPiano.Name = "cbPiano";
            this.cbPiano.Size = new System.Drawing.Size(53, 17);
            this.cbPiano.TabIndex = 4;
            this.cbPiano.Text = "Piano";
            this.cbPiano.UseVisualStyleBackColor = true;
            // 
            // cbKonduktor
            // 
            this.cbKonduktor.AutoSize = true;
            this.cbKonduktor.Location = new System.Drawing.Point(43, 152);
            this.cbKonduktor.Name = "cbKonduktor";
            this.cbKonduktor.Size = new System.Drawing.Size(75, 17);
            this.cbKonduktor.TabIndex = 3;
            this.cbKonduktor.Text = "Konduktor";
            this.cbKonduktor.UseVisualStyleBackColor = true;
            // 
            // cbSaxophone
            // 
            this.cbSaxophone.AutoSize = true;
            this.cbSaxophone.Location = new System.Drawing.Point(43, 112);
            this.cbSaxophone.Name = "cbSaxophone";
            this.cbSaxophone.Size = new System.Drawing.Size(80, 17);
            this.cbSaxophone.TabIndex = 2;
            this.cbSaxophone.Text = "Saxophone";
            this.cbSaxophone.UseVisualStyleBackColor = true;
            // 
            // cbGitar
            // 
            this.cbGitar.AutoSize = true;
            this.cbGitar.Location = new System.Drawing.Point(43, 72);
            this.cbGitar.Name = "cbGitar";
            this.cbGitar.Size = new System.Drawing.Size(48, 17);
            this.cbGitar.TabIndex = 1;
            this.cbGitar.Text = "Gitar";
            this.cbGitar.UseVisualStyleBackColor = true;
            // 
            // cbBiola
            // 
            this.cbBiola.AutoSize = true;
            this.cbBiola.Location = new System.Drawing.Point(43, 32);
            this.cbBiola.Name = "cbBiola";
            this.cbBiola.Size = new System.Drawing.Size(49, 17);
            this.cbBiola.TabIndex = 0;
            this.cbBiola.Text = "Biola";
            this.cbBiola.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rbMinggu);
            this.groupBox2.Controls.Add(this.rbSelasakamis);
            this.groupBox2.Controls.Add(this.rbSabtuminggu);
            this.groupBox2.Controls.Add(this.rbSeninrabu);
            this.groupBox2.Location = new System.Drawing.Point(355, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 200);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pilihan Jadwal";
            // 
            // rbMinggu
            // 
            this.rbMinggu.AutoSize = true;
            this.rbMinggu.Location = new System.Drawing.Point(66, 140);
            this.rbMinggu.Name = "rbMinggu";
            this.rbMinggu.Size = new System.Drawing.Size(129, 17);
            this.rbMinggu.TabIndex = 3;
            this.rbMinggu.TabStop = true;
            this.rbMinggu.Text = "Minggu, 13.00 - 17.00";
            this.rbMinggu.UseVisualStyleBackColor = true;
            // 
            // rbSelasakamis
            // 
            this.rbSelasakamis.AutoSize = true;
            this.rbSelasakamis.Location = new System.Drawing.Point(66, 76);
            this.rbSelasakamis.Name = "rbSelasakamis";
            this.rbSelasakamis.Size = new System.Drawing.Size(166, 17);
            this.rbSelasakamis.TabIndex = 1;
            this.rbSelasakamis.TabStop = true;
            this.rbSelasakamis.Text = "Selasa & Kamis, 14.00 - 16.00";
            this.rbSelasakamis.UseMnemonic = false;
            this.rbSelasakamis.UseVisualStyleBackColor = true;
            // 
            // rbSabtuminggu
            // 
            this.rbSabtuminggu.AutoSize = true;
            this.rbSabtuminggu.Location = new System.Drawing.Point(66, 108);
            this.rbSabtuminggu.Name = "rbSabtuminggu";
            this.rbSabtuminggu.Size = new System.Drawing.Size(169, 17);
            this.rbSabtuminggu.TabIndex = 2;
            this.rbSabtuminggu.TabStop = true;
            this.rbSabtuminggu.Text = "Sabtu & Minggu, 09.00 - 11.00";
            this.rbSabtuminggu.UseMnemonic = false;
            this.rbSabtuminggu.UseVisualStyleBackColor = true;
            // 
            // rbSeninrabu
            // 
            this.rbSeninrabu.AutoSize = true;
            this.rbSeninrabu.Location = new System.Drawing.Point(66, 44);
            this.rbSeninrabu.Name = "rbSeninrabu";
            this.rbSeninrabu.Size = new System.Drawing.Size(159, 17);
            this.rbSeninrabu.TabIndex = 0;
            this.rbSeninrabu.TabStop = true;
            this.rbSeninrabu.Text = "Senin & Rabu, 14.00 - 16.00";
            this.rbSeninrabu.UseMnemonic = false;
            this.rbSeninrabu.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(245, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "FORM PENDAFTARAN";
            // 
            // btTampilan
            // 
            this.btTampilan.Location = new System.Drawing.Point(238, 492);
            this.btTampilan.Name = "btTampilan";
            this.btTampilan.Size = new System.Drawing.Size(75, 23);
            this.btTampilan.TabIndex = 9;
            this.btTampilan.Text = "&Tampilkan";
            this.btTampilan.UseVisualStyleBackColor = true;
            this.btTampilan.Click += new System.EventHandler(this.btTampilan_Click);
            // 
            // btSelesai
            // 
            this.btSelesai.Location = new System.Drawing.Point(343, 492);
            this.btSelesai.Name = "btSelesai";
            this.btSelesai.Size = new System.Drawing.Size(75, 23);
            this.btSelesai.TabIndex = 10;
            this.btSelesai.Text = "&Selesai";
            this.btSelesai.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.btSelesai);
            this.Controls.Add(this.btTampilan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtTgl);
            this.Controls.Add(this.cbJk);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Astra Music School";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.ComboBox cbJk;
        private System.Windows.Forms.DateTimePicker dtTgl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbMinggu;
        private System.Windows.Forms.RadioButton rbSelasakamis;
        private System.Windows.Forms.RadioButton rbSabtuminggu;
        private System.Windows.Forms.RadioButton rbSeninrabu;
        private System.Windows.Forms.CheckBox cbKomposer;
        private System.Windows.Forms.CheckBox cbVokal;
        private System.Windows.Forms.CheckBox drum;
        private System.Windows.Forms.CheckBox cbPiano;
        private System.Windows.Forms.CheckBox cbKonduktor;
        private System.Windows.Forms.CheckBox cbSaxophone;
        private System.Windows.Forms.CheckBox cbGitar;
        private System.Windows.Forms.CheckBox cbBiola;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btTampilan;
        private System.Windows.Forms.Button btSelesai;
    }
}

