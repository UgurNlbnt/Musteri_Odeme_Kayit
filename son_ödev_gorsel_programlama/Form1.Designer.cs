namespace son_ödev_gorsel_programlama
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_miktar = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmb_yöntem = new System.Windows.Forms.ComboBox();
            this.cmb_kimden = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_fatura = new System.Windows.Forms.TextBox();
            this.chk_kontrol = new System.Windows.Forms.CheckBox();
            this.cmb_sehir = new System.Windows.Forms.ComboBox();
            this.cmn_faturatür = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgrid = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_sehir = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.txt_miktar);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.cmb_yöntem);
            this.groupBox1.Controls.Add(this.cmb_kimden);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(23, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Ödeme Bilgileri";
            // 
            // txt_miktar
            // 
            this.txt_miktar.Location = new System.Drawing.Point(141, 86);
            this.txt_miktar.Name = "txt_miktar";
            this.txt_miktar.Size = new System.Drawing.Size(232, 24);
            this.txt_miktar.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(141, 166);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(239, 24);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // cmb_yöntem
            // 
            this.cmb_yöntem.FormattingEnabled = true;
            this.cmb_yöntem.Items.AddRange(new object[] {
            "Havale",
            "EFT",
            "Banka Kartı",
            "Kredi Kartı"});
            this.cmb_yöntem.Location = new System.Drawing.Point(153, 124);
            this.cmb_yöntem.Name = "cmb_yöntem";
            this.cmb_yöntem.Size = new System.Drawing.Size(220, 26);
            this.cmb_yöntem.TabIndex = 3;
            // 
            // cmb_kimden
            // 
            this.cmb_kimden.FormattingEnabled = true;
            this.cmb_kimden.Location = new System.Drawing.Point(141, 41);
            this.cmb_kimden.Name = "cmb_kimden";
            this.cmb_kimden.Size = new System.Drawing.Size(232, 26);
            this.cmb_kimden.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ödeme Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ödeme Yöntemi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Miktarı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kimden Alındı";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.txt_fatura);
            this.groupBox2.Controls.Add(this.chk_kontrol);
            this.groupBox2.Controls.Add(this.cmb_sehir);
            this.groupBox2.Controls.Add(this.cmn_faturatür);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(575, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 224);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fatura Bilgileri";
            // 
            // txt_fatura
            // 
            this.txt_fatura.Location = new System.Drawing.Point(145, 86);
            this.txt_fatura.Name = "txt_fatura";
            this.txt_fatura.ReadOnly = true;
            this.txt_fatura.Size = new System.Drawing.Size(202, 27);
            this.txt_fatura.TabIndex = 6;
            this.txt_fatura.Tag = "";
            this.txt_fatura.TextChanged += new System.EventHandler(this.txt_no_TextChanged);
            // 
            // chk_kontrol
            // 
            this.chk_kontrol.AutoSize = true;
            this.chk_kontrol.Location = new System.Drawing.Point(303, 169);
            this.chk_kontrol.Name = "chk_kontrol";
            this.chk_kontrol.Size = new System.Drawing.Size(18, 17);
            this.chk_kontrol.TabIndex = 7;
            this.chk_kontrol.UseVisualStyleBackColor = true;
            // 
            // cmb_sehir
            // 
            this.cmb_sehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_sehir.FormattingEnabled = true;
            this.cmb_sehir.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman\t",
            "Afyonkarahisar",
            "Ağrı\t\t",
            "Amasya",
            "Ankara\t",
            "Antalya\t",
            "Artvin\t",
            "Aydın",
            "Balıkesir\t",
            "Bilecik\t",
            "Bingöl",
            "Bitlis\t",
            "Bolu\t",
            "Burdur\t",
            "Bursa\t",
            "Çanakkale\t",
            "Çankırı",
            "Çorum\t",
            "Denizli\t",
            "Diyarbakır\t",
            "Edirne",
            "Elazığ\t",
            "Erzincan\t",
            "Erzurum\t",
            "Eskişehir",
            "Gaziantep\t",
            "Giresun",
            "Gümüşhane\t",
            "Hakkari",
            "Hatay\t",
            "Isparta\t",
            "Mersin",
            "İstanbul\t",
            "İzmir",
            "Kars\t",
            "Kastamonu\t",
            "Kayseri",
            "Kırklareli\t",
            "Kırşehir\t",
            "Kocaeli\t",
            "Konya\t",
            "Kütahya\t",
            "Malatya\t",
            "Manisa\t",
            "Kahramanmaraş\t\t     ",
            "Mardin",
            "Muğla\t",
            "Muş\t",
            "Nevşehir\t",
            "Niğde",
            "Ordu\t",
            "Rize\t",
            "Sakarya\t",
            "Samsun\t",
            "Siirt\t",
            "Sinop\t",
            "Sivas\t",
            "Tekirdağ\t",
            "Tokat",
            "Trabzon\t",
            "Tunceli\t",
            "Şanlıurfa",
            "Uşak",
            "Van\t",
            "Yozgat",
            "Zonguldak",
            "Aksaray\t\t",
            "Bayburt\t\t",
            "Karaman\t",
            "Kırıkkale\t",
            "Batman\t\t",
            "Şırnak\t\t",
            "Bartın\t",
            "Ardahan\t",
            "Iğdır",
            "Yalova\t",
            "Karabük\t",
            "Kilis",
            "Osmaniye\t",
            "Düzce"});
            this.cmb_sehir.Location = new System.Drawing.Point(135, 127);
            this.cmb_sehir.Name = "cmb_sehir";
            this.cmb_sehir.Size = new System.Drawing.Size(202, 26);
            this.cmb_sehir.TabIndex = 7;
            // 
            // cmn_faturatür
            // 
            this.cmn_faturatür.FormattingEnabled = true;
            this.cmn_faturatür.Items.AddRange(new object[] {
            "Bireysel",
            "Kurumsal"});
            this.cmn_faturatür.Location = new System.Drawing.Point(145, 50);
            this.cmn_faturatür.Name = "cmn_faturatür";
            this.cmn_faturatür.Size = new System.Drawing.Size(202, 28);
            this.cmn_faturatür.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Ödeme Kontrolü";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Şehir";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Fatura No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Fatura Türü";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(436, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgrid
            // 
            this.dgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid.Location = new System.Drawing.Point(0, 327);
            this.dgrid.Name = "dgrid";
            this.dgrid.RowHeadersWidth = 51;
            this.dgrid.RowTemplate.Height = 24;
            this.dgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid.Size = new System.Drawing.Size(1270, 327);
            this.dgrid.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(1049, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 91);
            this.button2.TabIndex = 4;
            this.button2.Text = "Şehire Göre Filtrele";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_sehir
            // 
            this.txt_sehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sehir.Location = new System.Drawing.Point(1122, 53);
            this.txt_sehir.Name = "txt_sehir";
            this.txt_sehir.Size = new System.Drawing.Size(136, 24);
            this.txt_sehir.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(974, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Şehiri Giriniz:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1270, 654);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_sehir);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgrid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MÜŞTERİ ÖDEME";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_miktar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmb_yöntem;
        private System.Windows.Forms.ComboBox cmb_kimden;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_fatura;
        private System.Windows.Forms.CheckBox chk_kontrol;
        private System.Windows.Forms.ComboBox cmb_sehir;
        private System.Windows.Forms.ComboBox cmn_faturatür;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgrid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_sehir;
        private System.Windows.Forms.Label label9;
    }
}

