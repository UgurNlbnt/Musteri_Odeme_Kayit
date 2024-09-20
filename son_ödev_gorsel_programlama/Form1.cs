using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace son_ödev_gorsel_programlama
{
    public partial class Form1 : Form
    {
        DataTable table = new DataTable();
        private DataRow rows;
        public Form1()
        {

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataColumn[] cols = { new DataColumn("Kimden Alindi", typeof(String)),
                                  new DataColumn("Ödeme Yöntemi", typeof(String)),
                                  new DataColumn("Miktarı", typeof(Decimal)),
                                  new DataColumn("Ödeme Tarihi", typeof(DateTime)),
                                  new DataColumn("Fatura No", typeof(Decimal)),
                                  new DataColumn("Şehir", typeof(String)),
                                  new DataColumn("Fatura Türü", typeof(String)),
                                  new DataColumn("Ödeme Kontrolü", typeof(bool))
            };
            table.Columns.AddRange(cols);

            Object[] rows = { new object[] {"Melek Sarıcaoğlu", "Havale", 258,"12.09.2023",3023,"Trabzon","Bireysel",true },
            new Object[] { "Meltem Vural","Banka Kartı", 697, "02.05.2021", 5008, "Rize", "Bireysel", false },
            new Object[] { "Yaşiye Turgut","EFT", 2500, "21.11.2019", 10020, "Elazığ", "Kurumsal", true },
            new Object[] {"Uğur Nalbant","Banka Kartı",104,"02.06.2023",8023,"Mersin","Bireysel",true },
            new Object[] {"Ayten Kocamaz","Kredi Kartı",1550,"28.09.2017",0023,"Mersin","Kurumsal",true },
            new Object[] {"Esra Karayel","Banka Kartı", 291,"13.02.2022",2023,"Zonguldak","Bireysel",false },
            new Object[] {"Mustafa Nalbant","EFT", 658,"29.03.2022",9487,"İstanbul","Kurumsal",true },
            new Object[] {"Orhan Bakırtaş","Havale", 1438,"09.12.2023",5001,"Gaziantep","Kurumsal",false },
            new Object[] {"Ümit Karabekmez","Kredi Kartı", 1136,"12.08.2022",0698,"Sakarya","Bireysel",false }
            };
            foreach (Object[] row in rows)
            {
                table.Rows.Add(row);
            }
            dgrid.DataSource = table;
            txt_fatura.Enabled = false;
        }

        private void txt_no_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int64 faturano;
            Random rnd = new Random();
            faturano = rnd.Next(100, 10000);
            txt_fatura.Text = faturano.ToString();
            if (cmb_kimden.Text != "" && txt_miktar.Text != "")
            {
                rows = table.NewRow();
                rows["Kimden Alindi"] = cmb_kimden.Text;
                rows["Miktarı"] = txt_miktar.Text;
                rows["Ödeme Yöntemi"] = cmb_yöntem.Text;
                rows["Ödeme Tarihi"] = dateTimePicker1.Value;
                rows["Fatura No"] = faturano;
                rows["Şehir"] = cmb_sehir.Text;
                rows["Fatura Türü"] = cmn_faturatür.Text;
                rows["Ödeme Kontrolü"] = chk_kontrol.Checked;
                table.Rows.Add(rows);
                dgrid.DataSource = table;
            }
            else
            {
                MessageBox.Show("Müşteri bilgisini ve Ödeme Tutarını eksiksiz giriniz!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string seciliSehir = txt_sehir.Text;
            DataView dv = table.DefaultView;
            dv.RowFilter = $"Şehir = '{seciliSehir}'";
            dgrid.DataSource = dv.ToTable();
        }
    }
}