namespace VeriYapilari_odev2
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
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.gbSilme = new System.Windows.Forms.GroupBox();
            this.txtsira = new System.Windows.Forms.TextBox();
            this.lblsira = new System.Windows.Forms.Label();
            this.btnSilme = new System.Windows.Forms.Button();
            this.rbSiraSil = new System.Windows.Forms.RadioButton();
            this.rbNoSil = new System.Windows.Forms.RadioButton();
            this.rbTumSil = new System.Windows.Forms.RadioButton();
            this.rbSonSil = new System.Windows.Forms.RadioButton();
            this.rbBasSil = new System.Windows.Forms.RadioButton();
            this.gbBoyut = new System.Windows.Forms.GroupBox();
            this.lblListeBoyutu = new System.Windows.Forms.Label();
            this.btnListeBoyutu = new System.Windows.Forms.Button();
            this.gBListele = new System.Windows.Forms.GroupBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.rbOrtListele = new System.Windows.Forms.RadioButton();
            this.rbNoListele = new System.Windows.Forms.RadioButton();
            this.rbAdListele = new System.Windows.Forms.RadioButton();
            this.gbEkle = new System.Windows.Forms.GroupBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.rbSonaEkle = new System.Windows.Forms.RadioButton();
            this.rbSirayaEkle = new System.Windows.Forms.RadioButton();
            this.rbBasaEkle = new System.Windows.Forms.RadioButton();
            this.txtOrt = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.lblOrt = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblListeBos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbSilme.SuspendLayout();
            this.gbBoyut.SuspendLayout();
            this.gBListele.SuspendLayout();
            this.gbEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(39, 406);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(358, 324);
            this.listBox2.TabIndex = 23;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(39, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(358, 324);
            this.listBox1.TabIndex = 22;
            // 
            // gbSilme
            // 
            this.gbSilme.Controls.Add(this.txtsira);
            this.gbSilme.Controls.Add(this.lblsira);
            this.gbSilme.Controls.Add(this.btnSilme);
            this.gbSilme.Controls.Add(this.rbSiraSil);
            this.gbSilme.Controls.Add(this.rbNoSil);
            this.gbSilme.Controls.Add(this.rbTumSil);
            this.gbSilme.Controls.Add(this.rbSonSil);
            this.gbSilme.Controls.Add(this.rbBasSil);
            this.gbSilme.Location = new System.Drawing.Point(770, 192);
            this.gbSilme.Name = "gbSilme";
            this.gbSilme.Size = new System.Drawing.Size(266, 375);
            this.gbSilme.TabIndex = 18;
            this.gbSilme.TabStop = false;
            this.gbSilme.Text = "Silme İşlemi";
            // 
            // txtsira
            // 
            this.txtsira.Location = new System.Drawing.Point(105, 276);
            this.txtsira.Name = "txtsira";
            this.txtsira.Size = new System.Drawing.Size(80, 22);
            this.txtsira.TabIndex = 19;
            // 
            // lblsira
            // 
            this.lblsira.AutoSize = true;
            this.lblsira.Location = new System.Drawing.Point(46, 276);
            this.lblsira.Name = "lblsira";
            this.lblsira.Size = new System.Drawing.Size(37, 17);
            this.lblsira.TabIndex = 18;
            this.lblsira.Text = "Sıra:";
            // 
            // btnSilme
            // 
            this.btnSilme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSilme.Location = new System.Drawing.Point(29, 318);
            this.btnSilme.Name = "btnSilme";
            this.btnSilme.Size = new System.Drawing.Size(156, 35);
            this.btnSilme.TabIndex = 17;
            this.btnSilme.Text = "Silme";
            this.btnSilme.UseVisualStyleBackColor = true;
            this.btnSilme.Click += new System.EventHandler(this.btnSilme_Click);
            // 
            // rbSiraSil
            // 
            this.rbSiraSil.AutoSize = true;
            this.rbSiraSil.Location = new System.Drawing.Point(29, 230);
            this.rbSiraSil.Name = "rbSiraSil";
            this.rbSiraSil.Size = new System.Drawing.Size(109, 21);
            this.rbSiraSil.TabIndex = 16;
            this.rbSiraSil.TabStop = true;
            this.rbSiraSil.Text = "Girilen Sırayı";
            this.rbSiraSil.UseVisualStyleBackColor = true;
            // 
            // rbNoSil
            // 
            this.rbNoSil.AutoSize = true;
            this.rbNoSil.Location = new System.Drawing.Point(29, 183);
            this.rbNoSil.Name = "rbNoSil";
            this.rbNoSil.Size = new System.Drawing.Size(134, 21);
            this.rbNoSil.TabIndex = 15;
            this.rbNoSil.TabStop = true;
            this.rbNoSil.Text = "Girilen Numarayı";
            this.rbNoSil.UseVisualStyleBackColor = true;
            // 
            // rbTumSil
            // 
            this.rbTumSil.AutoSize = true;
            this.rbTumSil.Location = new System.Drawing.Point(29, 143);
            this.rbTumSil.Name = "rbTumSil";
            this.rbTumSil.Size = new System.Drawing.Size(81, 21);
            this.rbTumSil.TabIndex = 14;
            this.rbTumSil.TabStop = true;
            this.rbTumSil.Text = "Tümünü";
            this.rbTumSil.UseVisualStyleBackColor = true;
            // 
            // rbSonSil
            // 
            this.rbSonSil.AutoSize = true;
            this.rbSonSil.Location = new System.Drawing.Point(29, 100);
            this.rbSonSil.Name = "rbSonSil";
            this.rbSonSil.Size = new System.Drawing.Size(91, 21);
            this.rbSonSil.TabIndex = 13;
            this.rbSonSil.TabStop = true;
            this.rbSonSil.Text = "Sondakini";
            this.rbSonSil.UseVisualStyleBackColor = true;
            // 
            // rbBasSil
            // 
            this.rbBasSil.AutoSize = true;
            this.rbBasSil.Location = new System.Drawing.Point(29, 53);
            this.rbBasSil.Name = "rbBasSil";
            this.rbBasSil.Size = new System.Drawing.Size(86, 21);
            this.rbBasSil.TabIndex = 12;
            this.rbBasSil.TabStop = true;
            this.rbBasSil.Text = "Baştakini";
            this.rbBasSil.UseVisualStyleBackColor = true;
            // 
            // gbBoyut
            // 
            this.gbBoyut.Controls.Add(this.lblListeBoyutu);
            this.gbBoyut.Controls.Add(this.btnListeBoyutu);
            this.gbBoyut.Location = new System.Drawing.Point(770, 573);
            this.gbBoyut.Name = "gbBoyut";
            this.gbBoyut.Size = new System.Drawing.Size(266, 127);
            this.gbBoyut.TabIndex = 19;
            this.gbBoyut.TabStop = false;
            this.gbBoyut.Text = "Liste Boyutu";
            // 
            // lblListeBoyutu
            // 
            this.lblListeBoyutu.AutoSize = true;
            this.lblListeBoyutu.BackColor = System.Drawing.Color.Gainsboro;
            this.lblListeBoyutu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblListeBoyutu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblListeBoyutu.Location = new System.Drawing.Point(115, 38);
            this.lblListeBoyutu.Name = "lblListeBoyutu";
            this.lblListeBoyutu.Size = new System.Drawing.Size(23, 25);
            this.lblListeBoyutu.TabIndex = 20;
            this.lblListeBoyutu.Text = "0";
            // 
            // btnListeBoyutu
            // 
            this.btnListeBoyutu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListeBoyutu.Location = new System.Drawing.Point(55, 80);
            this.btnListeBoyutu.Name = "btnListeBoyutu";
            this.btnListeBoyutu.Size = new System.Drawing.Size(156, 35);
            this.btnListeBoyutu.TabIndex = 18;
            this.btnListeBoyutu.Text = "Liste Boyutu";
            this.btnListeBoyutu.UseVisualStyleBackColor = true;
            this.btnListeBoyutu.Click += new System.EventHandler(this.btnListeBoyutu_Click);
            // 
            // gBListele
            // 
            this.gBListele.Controls.Add(this.btnListele);
            this.gBListele.Controls.Add(this.rbOrtListele);
            this.gBListele.Controls.Add(this.rbNoListele);
            this.gBListele.Controls.Add(this.rbAdListele);
            this.gBListele.Location = new System.Drawing.Point(476, 453);
            this.gBListele.Name = "gBListele";
            this.gBListele.Size = new System.Drawing.Size(242, 254);
            this.gBListele.TabIndex = 20;
            this.gBListele.TabStop = false;
            this.gBListele.Text = "Listeleme İşlemi";
            // 
            // btnListele
            // 
            this.btnListele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListele.Location = new System.Drawing.Point(19, 200);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(156, 35);
            this.btnListele.TabIndex = 15;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // rbOrtListele
            // 
            this.rbOrtListele.AutoSize = true;
            this.rbOrtListele.Location = new System.Drawing.Point(30, 136);
            this.rbOrtListele.Name = "rbOrtListele";
            this.rbOrtListele.Size = new System.Drawing.Size(135, 21);
            this.rbOrtListele.TabIndex = 14;
            this.rbOrtListele.TabStop = true;
            this.rbOrtListele.Text = "Ortalamaya göre";
            this.rbOrtListele.UseVisualStyleBackColor = true;
            // 
            // rbNoListele
            // 
            this.rbNoListele.AutoSize = true;
            this.rbNoListele.Location = new System.Drawing.Point(30, 46);
            this.rbNoListele.Name = "rbNoListele";
            this.rbNoListele.Size = new System.Drawing.Size(127, 21);
            this.rbNoListele.TabIndex = 12;
            this.rbNoListele.TabStop = true;
            this.rbNoListele.Text = "Numaraya göre";
            this.rbNoListele.UseVisualStyleBackColor = true;
            // 
            // rbAdListele
            // 
            this.rbAdListele.AutoSize = true;
            this.rbAdListele.Location = new System.Drawing.Point(30, 93);
            this.rbAdListele.Name = "rbAdListele";
            this.rbAdListele.Size = new System.Drawing.Size(137, 21);
            this.rbAdListele.TabIndex = 13;
            this.rbAdListele.TabStop = true;
            this.rbAdListele.Text = "Ada soyada göre";
            this.rbAdListele.UseVisualStyleBackColor = true;
            // 
            // gbEkle
            // 
            this.gbEkle.Controls.Add(this.btnEkle);
            this.gbEkle.Controls.Add(this.rbSonaEkle);
            this.gbEkle.Controls.Add(this.rbSirayaEkle);
            this.gbEkle.Controls.Add(this.rbBasaEkle);
            this.gbEkle.Location = new System.Drawing.Point(476, 192);
            this.gbEkle.Name = "gbEkle";
            this.gbEkle.Size = new System.Drawing.Size(242, 255);
            this.gbEkle.TabIndex = 17;
            this.gbEkle.TabStop = false;
            this.gbEkle.Text = "Ekleme İşlemi";
            // 
            // btnEkle
            // 
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEkle.Location = new System.Drawing.Point(19, 192);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(156, 35);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // rbSonaEkle
            // 
            this.rbSonaEkle.AutoSize = true;
            this.rbSonaEkle.Location = new System.Drawing.Point(30, 143);
            this.rbSonaEkle.Name = "rbSonaEkle";
            this.rbSonaEkle.Size = new System.Drawing.Size(62, 21);
            this.rbSonaEkle.TabIndex = 11;
            this.rbSonaEkle.TabStop = true;
            this.rbSonaEkle.Text = "Sona";
            this.rbSonaEkle.UseVisualStyleBackColor = true;
            // 
            // rbSirayaEkle
            // 
            this.rbSirayaEkle.AutoSize = true;
            this.rbSirayaEkle.Location = new System.Drawing.Point(30, 100);
            this.rbSirayaEkle.Name = "rbSirayaEkle";
            this.rbSirayaEkle.Size = new System.Drawing.Size(69, 21);
            this.rbSirayaEkle.TabIndex = 10;
            this.rbSirayaEkle.TabStop = true;
            this.rbSirayaEkle.Text = "Sıraya";
            this.rbSirayaEkle.UseVisualStyleBackColor = true;
            // 
            // rbBasaEkle
            // 
            this.rbBasaEkle.AutoSize = true;
            this.rbBasaEkle.Location = new System.Drawing.Point(30, 53);
            this.rbBasaEkle.Name = "rbBasaEkle";
            this.rbBasaEkle.Size = new System.Drawing.Size(61, 21);
            this.rbBasaEkle.TabIndex = 9;
            this.rbBasaEkle.TabStop = true;
            this.rbBasaEkle.Text = "Başa";
            this.rbBasaEkle.UseVisualStyleBackColor = true;
            // 
            // txtOrt
            // 
            this.txtOrt.Location = new System.Drawing.Point(552, 137);
            this.txtOrt.Name = "txtOrt";
            this.txtOrt.Size = new System.Drawing.Size(100, 22);
            this.txtOrt.TabIndex = 16;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(552, 85);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(189, 22);
            this.txtAd.TabIndex = 15;
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(552, 36);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(189, 22);
            this.txtNo.TabIndex = 14;
            // 
            // lblOrt
            // 
            this.lblOrt.AutoSize = true;
            this.lblOrt.Location = new System.Drawing.Point(473, 137);
            this.lblOrt.Name = "lblOrt";
            this.lblOrt.Size = new System.Drawing.Size(70, 17);
            this.lblOrt.TabIndex = 13;
            this.lblOrt.Text = "Ortalama:";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(473, 88);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(73, 17);
            this.lblAd.TabIndex = 12;
            this.lblAd.Text = "Ad Soyad:";
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Location = new System.Drawing.Point(473, 39);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(62, 17);
            this.lblNo.TabIndex = 11;
            this.lblNo.Text = "Numara:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Linked List:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Sıralı Liste:";
            // 
            // lblListeBos
            // 
            this.lblListeBos.AutoSize = true;
            this.lblListeBos.BackColor = System.Drawing.Color.LightCoral;
            this.lblListeBos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblListeBos.Location = new System.Drawing.Point(840, 122);
            this.lblListeBos.Name = "lblListeBos";
            this.lblListeBos.Padding = new System.Windows.Forms.Padding(50, 10, 50, 10);
            this.lblListeBos.Size = new System.Drawing.Size(166, 37);
            this.lblListeBos.TabIndex = 26;
            this.lblListeBos.Text = "Liste Boş";
            this.lblListeBos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Location = new System.Drawing.Point(822, 29);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(35, 7, 35, 7);
            this.label3.Size = new System.Drawing.Size(239, 65);
            this.label3.TabIndex = 27;
            this.label3.Text = "Numaraya göre silme\r\nişlemi için lütfen numarayı\r\nburaya giriniz.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(764, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 38);
            this.label4.TabIndex = 28;
            this.label4.Text = "←";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1096, 734);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblListeBos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.gbSilme);
            this.Controls.Add(this.gbBoyut);
            this.Controls.Add(this.gBListele);
            this.Controls.Add(this.gbEkle);
            this.Controls.Add(this.txtOrt);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.lblOrt);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.lblNo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödev";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSilme.ResumeLayout(false);
            this.gbSilme.PerformLayout();
            this.gbBoyut.ResumeLayout(false);
            this.gbBoyut.PerformLayout();
            this.gBListele.ResumeLayout(false);
            this.gBListele.PerformLayout();
            this.gbEkle.ResumeLayout(false);
            this.gbEkle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox gbSilme;
        private System.Windows.Forms.TextBox txtsira;
        private System.Windows.Forms.Label lblsira;
        private System.Windows.Forms.Button btnSilme;
        private System.Windows.Forms.RadioButton rbSiraSil;
        private System.Windows.Forms.RadioButton rbNoSil;
        private System.Windows.Forms.RadioButton rbTumSil;
        private System.Windows.Forms.RadioButton rbSonSil;
        private System.Windows.Forms.RadioButton rbBasSil;
        private System.Windows.Forms.GroupBox gbBoyut;
        private System.Windows.Forms.Button btnListeBoyutu;
        private System.Windows.Forms.GroupBox gBListele;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.RadioButton rbOrtListele;
        private System.Windows.Forms.RadioButton rbNoListele;
        private System.Windows.Forms.RadioButton rbAdListele;
        private System.Windows.Forms.GroupBox gbEkle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.RadioButton rbSonaEkle;
        private System.Windows.Forms.RadioButton rbSirayaEkle;
        private System.Windows.Forms.RadioButton rbBasaEkle;
        private System.Windows.Forms.TextBox txtOrt;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label lblOrt;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblListeBoyutu;
        private System.Windows.Forms.Label lblListeBos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

