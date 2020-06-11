using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kelime_Bulma_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection n = new SqlConnection("Server=DESKTOP-R5P3ANL\\SQLEXPRESS;Database=KelimeBulma;trusted_connection=true;");
        DataSet daset = new DataSet();
        public static double secondsTaken = 0;
        string kelime;
        int j;
        int x;
        int toplampuan = 0;

        private void btn_bul_Click(object sender, EventArgs e)
        {
            


            KelimeBulucu();

        }

        private void KelimeBulucu()
        {
            string[] harf = new string[9];

            DateTime startTime = DateTime.Now;

            while (true)
            {
                SqlCommand comm = new SqlCommand("SELECT F1 FROM Sayfa1$ ORDER BY LEN(F1) DESC", n);

                n.Open();

                SqlDataReader dr = comm.ExecuteReader();

                while (dr.Read())
                {
                    
                    harf[0] = txt_bir.Text;
                    harf[1] = txt_iki.Text;
                    harf[2] = txt_uc.Text;
                    harf[3] = txt_dort.Text;
                    harf[4] = txt_bes.Text;
                    harf[5] = txt_alti.Text;
                    harf[6] = txt_yedi.Text;
                    harf[7] = txt_sekiz.Text;
                    
                    j = 0;

                    kelime = Convert.ToString(dr["F1"]);
                    char[] ayir = kelime.ToCharArray();
                    for (int i = 0; i < kelime.Length; i++)
                    {
                        if(Array.IndexOf(harf,ayir[i].ToString())==-1)
                        {
                            x = i;
                            j++;
                        }
                        else
                        {
                            for (int b = 0; b < 8; b++)
                            {
                                if (harf[b] == ayir[i].ToString())
                                {
                                    harf[b] = " ";
                                    break;
                                }
                            }
                        }
                        
                    }
                    if(j==0)
                    {
                        harf[8] = ayir[x].ToString();
                        txt_bulunankelime.Text = kelime;
                        PuanHesapla();
                        break;
                    }
                    else if(j==1)
                    {
                        harf[8] = ayir[x].ToString();
                        txt_jkr.Text = harf[8];
                        txt_bulunankelime.Text = kelime;
                        PuanHesapla();
                        break;
                    }
                   

                }

                dr.Close();
                n.Close();
                secondsTaken = (DateTime.Now - startTime).TotalSeconds;
                txt_gecensure.Text = secondsTaken.ToString();
                break;
            }
      
        }

        private void PuanHesapla()
        {
            if (txt_bulunankelime.Text.Length == 9)
            {
                txt_kazanılanpuan.Text = 15.ToString();
            }
            else if (txt_bulunankelime.Text.Length == 8)
            {
                txt_kazanılanpuan.Text = 11.ToString();
            }
            else if (txt_bulunankelime.Text.Length == 7)
            {
                txt_kazanılanpuan.Text = 9.ToString();
            }
            else if (txt_bulunankelime.Text.Length == 6)
            {
                txt_kazanılanpuan.Text = 7.ToString();
            }
            else if (txt_bulunankelime.Text.Length == 5)
            {
                txt_kazanılanpuan.Text = 5.ToString();
            }
            else if (txt_bulunankelime.Text.Length == 4)
            {
                txt_kazanılanpuan.Text = 4.ToString();
            }
            else if (txt_bulunankelime.Text.Length == 3)
            {
                txt_kazanılanpuan.Text = 3.ToString();
            }

            toplampuan += Convert.ToInt32(txt_kazanılanpuan.Text);
            txt_toplampuan.Text = toplampuan.ToString();
        }

        private void rdb_rndm_CheckedChanged(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            string[] uret = new string[8];
            string harfler = "abcçdefgğhıijklmnoöprsştuüvyz";
            for (int i = 0; i < 8; i++)
            {
                uret[i] = "";
            }
            for (int x = 0; x < 8; x++)
            {
                uret[x] += harfler[rastgele.Next(harfler.Length)];
            }
            txt_bir.Text = uret[0];
            txt_iki.Text = uret[1];
            txt_uc.Text = uret[2];
            txt_dort.Text = uret[3];
            txt_bes.Text = uret[4];
            txt_alti.Text = uret[5];
            txt_yedi.Text = uret[6];
            txt_sekiz.Text = uret[7];
            txt_jkr.Text = "?";
        }

        private void rdb_kndn_CheckedChanged(object sender, EventArgs e)
        {
            txt_bir.Text = "";
            txt_iki.Text = "";
            txt_uc.Text = "";
            txt_dort.Text = "";
            txt_bes.Text = "";
            txt_alti.Text = "";
            txt_yedi.Text = "";
            txt_sekiz.Text = "";
            txt_jkr.Text = "?";
        }
    }
}
