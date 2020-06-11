using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yazılım_Yapmı_Ödev_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int c;
        int toplam_puan = 0;
        int puan=10;
        int gecicipuan;
        Random rnd = new Random();
        public static double secondsTaken = 0;
        public static int bestSoFar = 0;
        private void Hesaplama()
        {
            int[] teksayi = new int[6];
            teksayi[0] = Convert.ToInt32(mtxt_tek1.Text);
            teksayi[1] = Convert.ToInt32(mtxt_tek2.Text);
            teksayi[2] = Convert.ToInt32(mtxt_tek3.Text);
            teksayi[3] = Convert.ToInt32(mtxt_tek4.Text);
            teksayi[4] = Convert.ToInt32(mtxt_tek5.Text);
            teksayi[5] = Convert.ToInt32(mtxt_cift.Text);
            int hedefsayi = Convert.ToInt32(mtxt_hedef.Text);
            DateTime startTime = DateTime.Now;
            while (true)
            {
                secondsTaken = (DateTime.Now - startTime).TotalSeconds;
                
                int num = rnd.Next(6);
                int temp = teksayi[num];
                teksayi[num] = teksayi[0];
                teksayi[0] = temp;

                int thisTotal = teksayi[0];

                string solution = teksayi[0].ToString();

                int numbersToUse = rnd.Next(1, 7);

                for (int i = 1; i < numbersToUse; i++)
                {

                    int operation = rnd.Next(4);
                    if (operation == 0)
                    {
                        thisTotal += teksayi[i];
                        solution += " + " + teksayi[i].ToString();
                    }
                    if (operation == 1)
                    {
                        thisTotal -= teksayi[i];
                        solution += " - " + teksayi[i].ToString();
                    }
                    if (operation == 2)
                    {
                        thisTotal *= teksayi[i];
                        solution += " x " + teksayi[i].ToString();
                    }
                    if (operation == 3)
                    {
                        if (thisTotal % teksayi[i] != 0) continue;
                        thisTotal /= teksayi[i];
                        solution += " / " + teksayi[i].ToString();
                    }

                }

                solution += " = " + thisTotal.ToString();

                if (secondsTaken >= 10)
                {
                    if (Math.Abs(hedefsayi - bestSoFar) < 10)
                    {
                        gecicipuan = puan - Math.Abs(hedefsayi - bestSoFar);
                        txt_kpuan.Text = Convert.ToString(gecicipuan);
                        toplam_puan += gecicipuan;
                        txt_toplampuan.Text = Convert.ToString(toplam_puan);
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Çözüm Bulunamadı");
                        break;
                    }
                }


                if (Math.Abs(hedefsayi - thisTotal) < Math.Abs(hedefsayi - bestSoFar))
                {
                    bestSoFar = thisTotal;
                    txt_cozum.Text = solution;
                    
                }
                
                if (thisTotal == hedefsayi)
                {
                    txt_cozum.Text = solution;
                    txt_kpuan.Text = Convert.ToString(puan);
                    toplam_puan += puan;
                    txt_toplampuan.Text = Convert.ToString(toplam_puan);
                    break;
                }              
            }
            txt_sure.Text = Convert.ToString(secondsTaken);
        }
        private int Kontrol()
        {
            c = 0;
            if (mtxt_tek1.Text.Length < 1 || Convert.ToInt32(mtxt_tek1.Text) < 1)
            {
                MessageBox.Show("1.Sayıyı Hatalı Girdiniz");
                c++;
            }
            if (mtxt_tek2.Text.Length < 1 || Convert.ToInt32(mtxt_tek2.Text) < 1)
            {
                MessageBox.Show("2.Sayıyı Hatalı Girdiniz");
                c++;
            }
            if (mtxt_tek3.Text.Length < 1 || Convert.ToInt32(mtxt_tek3.Text) < 1)
            {
                MessageBox.Show("3.Sayıyı Hatalı Girdiniz");
                c++;
            }
            if (mtxt_tek4.Text.Length < 1 || Convert.ToInt32(mtxt_tek4.Text) < 1)
            {
                MessageBox.Show("4.Sayıyı Hatalı Girdiniz");
                c++;
            }
            if (mtxt_tek5.Text.Length < 1 || Convert.ToInt32(mtxt_tek5.Text) < 1)
            {
                MessageBox.Show("5.Sayıyı Hatalı Girdiniz");
                c++;
            }
            if (mtxt_cift.Text.Length != 2 || Convert.ToInt32(mtxt_cift.Text) < 10)
            {
                MessageBox.Show("6.Sayıyı Hatalı Girdiniz");
                c++;
            }
            else if (Convert.ToInt32(mtxt_cift.Text) % 10 != 0)
            {
                MessageBox.Show("6.Sayı 10 veya 10`un Katı Olmalıdır");
                c++;
            }
            if (mtxt_hedef.Text.Length != 3 || Convert.ToInt32(mtxt_hedef.Text) < 100)
            {
                MessageBox.Show("Hedef Sayıyı Hatalı Girdiniz");
                c++;
            }

            return c;
        }
        private void TextEneble(bool a)
        {
            mtxt_cift.Enabled = a;
            mtxt_tek1.Enabled = a;
            mtxt_tek2.Enabled = a;
            mtxt_tek3.Enabled = a;
            mtxt_tek4.Enabled = a;
            mtxt_tek5.Enabled = a;
            mtxt_hedef.Enabled = a;
            if (a == true)
            {
                mtxt_cift.Clear();
                mtxt_tek1.Clear();
                mtxt_tek2.Clear();
                mtxt_tek3.Clear();
                mtxt_tek4.Clear();
                mtxt_tek5.Clear();
                mtxt_hedef.Clear();
            }
        }
        private void rdb_random_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_random.Checked == true)
            {
                TextEneble(false);
                int[] rteksayi = new int[6];

                for (int i = 1; i < 6; i++)
                {
                    rteksayi[i] = rnd.Next(1, 10);
                }
                mtxt_tek1.Text = rteksayi[1].ToString();
                mtxt_tek2.Text = rteksayi[2].ToString();
                mtxt_tek3.Text = rteksayi[3].ToString();
                mtxt_tek4.Text = rteksayi[4].ToString();
                mtxt_tek5.Text = rteksayi[5].ToString();

                int rciftsayi = rnd.Next(10, 99);
                rciftsayi = rciftsayi - rciftsayi % 10;
                mtxt_cift.Text = rciftsayi.ToString();

                int rhedefsayi = rnd.Next(100, 999);
                mtxt_hedef.Text = rhedefsayi.ToString();
            }

        }
        private void rdb_manuel_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_manuel.Checked == true)
            {
                TextEneble(true);
            }
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {

            Kontrol();
            if (c > 0)
            {
                MessageBox.Show("Hatalı Sayıları Düzeltin");
            }
            else
            {
                Hesaplama();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        
           
    }
}
