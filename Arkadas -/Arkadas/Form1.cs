using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arkadas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            openFileDialog1.ShowDialog();
            System.IO.StreamReader inputstream = new System.IO.StreamReader(openFileDialog1.FileName);

            while (!inputstream.EndOfStream)
            {
                string satir = inputstream.ReadLine();
                string[] dizi = satir.Split(',');

                //Veriler Burda Giriş Yapar..


                data.networkRow r = data.network.NewnetworkRow();

                //string int pars edilecek. convert.toınt veya decimal olmadıgından bu çeşit bir yöntem kullanıldı
                int.TryParse(dizi[0], out int k);
                r.Id = k;
                int.TryParse(dizi[1], out k);
                r.A1 = k;
                int.TryParse(dizi[2], out k);
                r.A2 = k;
                int.TryParse(dizi[3], out k);
                r.A3 = k;
                int.TryParse(dizi[4], out k);
                r.A4 = k;
                int.TryParse(dizi[5], out k);
                r.A5 = k;
                int.TryParse(dizi[6], out k);
                r.A6 = k;
                int.TryParse(dizi[7], out k);
                r.A7 = k;
                int.TryParse(dizi[8], out k);
                r.A8 = k;
                int.TryParse(dizi[9], out k);
                r.A9 = k;
                int.TryParse(dizi[10], out k);
                r.A10 = k;
                    data.network.AddnetworkRow(r);
                    networkTableAdapter.Update(r);

            }

            openFileDialog1.ShowDialog();
            System.IO.StreamReader inputstream1 = new System.IO.StreamReader(openFileDialog1.FileName);


            while (!inputstream1.EndOfStream)
            {
                string satir = inputstream1.ReadLine();
                string[] dizi = satir.Split(',');

                //Veriler Burda Giriş Yapar..


                data.profilRow r = data.profil.NewprofilRow();

                //string int pars edilecek. convert.toınt veya decimal olmadıgından bu çeşit bir yöntem kullanıldı
                int.TryParse(dizi[0], out int k);
                r.Id = k;
                int.TryParse(dizi[1], out k);
                r.B1 = k;
                int.TryParse(dizi[2], out k);
                r.B2 = k;
                int.TryParse(dizi[3], out k);
                r.B3 = k;
                int.TryParse(dizi[4], out k);
                r.B4 = k;
                int.TryParse(dizi[5], out k);
                r.B5 = k;
                int.TryParse(dizi[6], out k);
                r.B6 = k;
                int.TryParse(dizi[7], out k);
                r.B7 = k;
                int.TryParse(dizi[8], out k);
                r.B8 = k;
                int.TryParse(dizi[9], out k);
                r.B9 = k;
                int.TryParse(dizi[10], out k);
                r.B10 = k;
                int.TryParse(dizi[11], out k);
                r.B11 = k;
                int.TryParse(dizi[12], out k);
                r.B12 = k;
                int.TryParse(dizi[13], out k);
                r.B13 = k;
                int.TryParse(dizi[14], out k);
                r.B14 = k;
                int.TryParse(dizi[15], out k);
                r.B15 = k;

                data.profil.AddprofilRow(r);
                profilTableAdapter.Update(r);

            }
             





            inputstream.Close();
                inputstream1.Close();

         
        } 

                      

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'data2.öneri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.öneriTableAdapter.Fill(this.data2.öneri);
            // TODO: Bu kod satırı 'data2.arkadas' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.arkadasTableAdapter.Fill(this.data2.arkadas);
            // TODO: Bu kod satırı 'data.profil' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.profilTableAdapter.Fill(this.data.profil);
            // TODO: Bu kod satırı 'data.network' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.networkTableAdapter.Fill(this.data.network);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            int.TryParse(s, out int id);
            data.networkRow r = data.network.FindById(id);

            Decimal[] arkadas = { r.A1, r.A2, r.A3, r.A4, r.A5, r.A6, r.A7, r.A8, r.A9, r.A10 };

            foreach (decimal a in arkadas)
            {
                if (a != 0)
                {

                    data.profilRow t = data.profil.FindById((int)a);
                    data.arkadasRow p = data.arkadas.NewarkadasRow();
                    p.Id = t.Id;
                    p.B1 = t.B1;
                    p.B2 = t.B2;
                    p.B3 = t.B3;
                    p.B4 = t.B4;
                    p.B5 = t.B5;
                    p.B6 = t.B6;
                    p.B7 = t.B7;
                    p.B8 = t.B8;
                    p.B9 = t.B9;
                    p.B10 = t.B10;
                    p.B11 = t.B11;
                    p.B12 = t.B12;
                    p.B13 = t.B13;
                    p.B14 = t.B14;
                    p.B15 = t.B15;

                    p.LABEL = 1;
                    t.ALINDI = 1;
                    data.arkadas.AddarkadasRow(p);
                    arkadasTableAdapter.Update(p);
                    profilTableAdapter.Update(t);

                }
            }


            int N = 90;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                if (Convert.ToDecimal(dataGridView2.Rows[i].Cells[16].Value) == 1)
                {
                    N = N - 1;
                }

            }
            MessageBox.Show(Convert.ToString(N));
            //üstteki komutlar kişinin arkasları dısında kaçtane seçenek var gösteriryor N
            //yarısını kullanacagımız N degerı asagıda kullanılacak ve alındısı=0 olan ilk n/2 kişiyi alalcagğız

            
            
            int sayac=0;// sayacın olma sebebı ılındısı 0 olan ılk N/2 kişiyi alacagız fakat arayada 1 ler karıstıgından for a yazamıyoruz

            for (int i = 0; i <dataGridView2.Rows.Count; i++)
            {
                if (Convert.ToDecimal(dataGridView2.Rows[i].Cells[16].Value) == 0)
                {
                    data.profilRow t = data.profil.FindById(Convert.ToDecimal(dataGridView2.Rows[i].Cells[0].Value));
                    data.arkadasRow p = data.arkadas.NewarkadasRow();
                     
                    p.Id = t.Id;
                    p.B1 = t.B1;
                    p.B2 = t.B2;
                    p.B3 = t.B3;
                    p.B4 = t.B4;
                    p.B5 = t.B5;
                    p.B6 = t.B6;
                    p.B7 = t.B7;
                    p.B8 = t.B8;
                    p.B9 = t.B9;
                    p.B10 = t.B10;
                    p.B11 = t.B11;
                    p.B12 = t.B12;
                    p.B13 = t.B13;
                    p.B14 = t.B14;
                    p.B15 = t.B15;

                    p.LABEL = 0;
                    t.ALINDI = 1;
                    data.arkadas.AddarkadasRow(p);
                    arkadasTableAdapter.Update(p);
                    profilTableAdapter.Update(t);
                    sayac++;

                }

                if (sayac == N / 2)    break ; 
            }

            MessageBox.Show("arkadas matrısıne alındısı 0 olan giden kişi sayısı " + sayac );


            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                if (Convert.ToDecimal(dataGridView2.Rows[i].Cells[16].Value) == 0) //alındısının 0 olanları belırler
                {
                    data.profilRow t = data.profil.FindById(Convert.ToDecimal(dataGridView2.Rows[i].Cells[0].Value));
                    data.öneriRow p = data.öneri.NewöneriRow();

                    p.Id = t.Id;
                    p.B1 = t.B1;
                    p.B2 = t.B2;
                    p.B3 = t.B3;
                    p.B4 = t.B4;
                    p.B5 = t.B5;
                    p.B6 = t.B6;
                    p.B7 = t.B7;
                    p.B8 = t.B8;
                    p.B9 = t.B9;
                    p.B10 = t.B10;
                    p.B11 = t.B11;
                    p.B12 = t.B12;
                    p.B13 = t.B13;
                    p.B14 = t.B14;
                    p.B15 = t.B15;

                    t.ALINDI = 1;
                    data.öneri.AddöneriRow(p); //öneri tablosu doldurulur
                    öneriTableAdapter.Update(p);
                    profilTableAdapter.Update(t);


                }


            }



        }
    }
}
