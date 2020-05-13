/**************************************************************************** 
**                  SAKARYA ÜNİVERSİTESİ 
**        BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ 
**         BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
**            NESNEYE DAYALI PROGRAMLAMA DERSİ 
**                 2019-2020 BAHAR DÖNEMİ 
**    PROJE NUMARASI.........: 
**    ÖĞRENCİ ADI............: Ahmed Gazihan Birincioğlu 
**    ÖĞRENCİ NUMARASI.......: b191200004
**    DERSİN ALINDIĞI GRUP...: Bilişim Sitemleri Mühendisliği
****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EU4_Battle_Simulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        



        private void button1_Click_1(object sender, EventArgs e) // savaş başlat butonuna basınca başlayacak işlemler //
        {
            double salpiysay, salsuvsay, saltopsay, savpiysay, savsuvsay, savtopsay; // savunan piyade-suvari-topçu ve saldıran piyade-suvari-topcu sayılarının int değerleri //

            double savpip=0 , salpip=0 ; // saldıran ve savunannın temel pipe değeri //
            double salmorbon, savmorbon, roll, savdisbon, saldisbon, salpiypip, salsuvpip, saltoppip, savpiypip, savsuvpip, savtoppip; // ordunun yenilip yenilmeyeceğini belirlyen kısım, sal=saldıran,sav=savunan //
            double savdisbonC,saldisbonC,salmorbonC,savmorbonC; // moral bonusları //
           
            salpiysay = Convert.ToDouble(SalPiySay.Text);
            salsuvsay = Convert.ToDouble(SalSuvSay.Text);
            saltopsay = Convert.ToDouble(SalTopSay.Text);     // yazılan asker sayılarının sayıya dönüştürülmesi //
            savpiysay = Convert.ToDouble(SavPiySay.Text);
            savsuvsay = Convert.ToDouble(SavSuvSay.Text);
            savtopsay = Convert.ToDouble(SavTopSay.Text);
            roll = 6;
            salmorbonC = Convert.ToDouble(SalMorBon.Text);
            savmorbonC = Convert.ToDouble(SavMorBon.Text);
            saldisbonC = Convert.ToDouble(SalDisBon.Text);         // savunan ve saldıranların disiplin ve moral bonuslarının değerlerini double a dönüştürülmesi //
            savdisbonC = Convert.ToDouble(SavDisBon.Text);

            savmorbon = 100 + savmorbonC;
            salmorbon = 100 + salmorbonC;                 //moral ordunun savaşa devam etme gücüdür disiplin ise aldığı hasarı azaltır //
            saldisbon = 100 + saldisbonC;              // moral ve disiplinin temel bonusu 100 dür, girilen bonus kadar artar yada azalır//
            savdisbon = 100 + savdisbonC;
            
            
            if (WG1.Checked == true) //Saldıran western orduların yıllara göre güçleri
            {
                if (Y1.Checked == true)
                {
                    salpiypip = (salpiysay * 1 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 2 * salmorbon / 100) - savdisbon / 100;         // 1444-1500 arası western seçiliyse ordu gücü //
                    saltoppip = (saltopsay * 1 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y2.Checked == true)
                {
                    salpiypip = (salpiysay * 2 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 2 * salmorbon / 100) - savdisbon / 100;         // 1500-1550 arası western seçiliyse ordu gücü //
                    saltoppip = (saltopsay * 2 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y3.Checked == true)
                {
                    salpiypip = (salpiysay * 5 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 4 * salmorbon / 100) - savdisbon / 100;         // 1550-1600 arası western seçiliyse ordu gücü //
                    saltoppip = (saltopsay * 3 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y4.Checked == true)
                {
                    salpiypip = (salpiysay * 6 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 3 * salmorbon / 100) - savdisbon / 100;         // 1600-1650 arası western seçiliyse ordu gücü //
                    saltoppip = (saltopsay * 6 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y5.Checked == true)
                {
                    salpiypip = (salpiysay * 10 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 6 * salmorbon / 100) - savdisbon / 100;        // 1650-1700 arası western seçiliyse ordu gücü //
                    saltoppip = (saltopsay * 8 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y6.Checked == true)
                {
                    salpiypip = (salpiysay * 12 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 10 * salmorbon / 100) - savdisbon / 100;       // 1700-1750 arası western seçiliyse ordu gücü //
                    saltoppip = (saltopsay * 10 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y7.Checked == true)
                {
                    salpiypip = (salpiysay * 14 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 12 * salmorbon / 100) - savdisbon / 100;       // 1750-1821 arası western seçiliyse ordu gücü //
                    saltoppip = (saltopsay * 12 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else
                {
                    MessageBox.Show("Lütfen bir yıl aralığı seçiniz");
                }
            }
            else if (EG1.Checked == true) // Saldıran Eastern orduların yıllara göre güçleri //
            {
                if (Y1.Checked == true)
                {
                    salpiypip = (salpiysay * 1 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 2 * salmorbon / 100) - savdisbon / 100;        // 1444-1500 arası eastern seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 1 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y2.Checked == true)
                {
                    salpiypip = (salpiysay * 3 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 4 * salmorbon / 100) - savdisbon / 100;        // 1500-1550 arası eastern seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 2 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y3.Checked == true)
                {
                    salpiypip = (salpiysay * 5 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 4 * salmorbon / 100) - savdisbon / 100;        // 1550-1600 arası eastern seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 3 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y4.Checked == true)
                {
                    salpiypip = (salpiysay * 6 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 4 * salmorbon / 100) - savdisbon / 100;        // 1600-1650 arası eastern seçildiyse ordu gücü //  
                    saltoppip = (saltopsay * 6 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y5.Checked == true)
                {
                    salpiypip = (salpiysay * 8 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 8 * salmorbon / 100) - savdisbon / 100;        // 1650-1700 arası eastern seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 8 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y6.Checked == true)
                {
                    salpiypip = (salpiysay * 10 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 14 * salmorbon / 100) - savdisbon / 100;       // 1700-1750 arası eastern seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 10 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y7.Checked == true)
                {
                    salpiypip = (salpiysay * 12 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 14 * salmorbon / 100) - savdisbon / 100;      // 1750-1821 arası eastern seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 12 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else
                {
                    MessageBox.Show("Lütfen bir yıl aralığı seçiniz");
                }
            }
            else if (ANAG1.Checked == true) // Saldıran Anatoilan Orduların Yıllara Göre Güçleri //
            {
                if (Y1.Checked == true)
                {
                    salpiypip = (salpiysay * 3 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 4 * salmorbon / 100) - savdisbon / 100;        // 1444-1500 arası anatolian seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 3 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y2.Checked == true)
                {
                    salpiypip = (salpiysay * 5 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 6 * salmorbon / 100) - savdisbon / 100;        // 1500-1550 arası anatolian seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 4 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y3.Checked == true)
                {
                    salpiypip = (salpiysay * 6 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 6 * salmorbon / 100) - savdisbon / 100;        // 1550-1600 arası anatolian seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 4 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y4.Checked == true)
                {
                    salpiypip = (salpiysay * 6 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 8 * salmorbon / 100) - savdisbon / 100;        // 1600-1650 arası anatolian seçildiyse ordu gücü //  
                    saltoppip = (saltopsay * 6 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y5.Checked == true)
                {
                    salpiypip = (salpiysay * 8 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 8 * salmorbon / 100) - savdisbon / 100;      // 1650-1700 arası anatolian seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 8 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y6.Checked == true)
                {
                    salpiypip = (salpiysay * 10 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 10 * salmorbon / 100) - savdisbon / 100;      // 1700-1750 arası anatolian seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 8 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y7.Checked == true)
                {
                    salpiypip = (salpiysay * 11 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 10 * salmorbon / 100) - savdisbon / 100;      // 1750-1821 arası anatolian seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 10 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else
                {
                    MessageBox.Show("Lütfen bir yıl aralığı seçiniz");
                }

            }
            else if (MG1.Checked == true) // Saldıran Muslim Orduların Yıllara Göre Güçleri //
            {
                if (Y1.Checked == true)
                {
                    salpiypip = (salpiysay * 2 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 3 * salmorbon / 100) - savdisbon / 100;        // 1444-1500 arası muslim seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 1 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y2.Checked == true)
                {
                    salpiypip = (salpiysay * 3 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 4 * salmorbon / 100) - savdisbon / 100;        // 1500-1550 arası muslim seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 1 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y3.Checked == true)
                {
                    salpiypip = (salpiysay * 4 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 4 * salmorbon / 100) - savdisbon / 100;        // 1550-1600 arası muslim seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 2 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y4.Checked == true)
                {
                    salpiypip = (salpiysay * 5 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 4 * salmorbon / 100) - savdisbon / 100;        // 1600-1650 arası muslim seçildiyse ordu gücü //  
                    saltoppip = (saltopsay * 4 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y5.Checked == true)
                {
                    salpiypip = (salpiysay * 7 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 6 * salmorbon / 100) - savdisbon / 100;      // 1650-1700 arası muslim seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 6 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y6.Checked == true)
                {
                    salpiypip = (salpiysay * 8 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 8 * salmorbon / 100) - savdisbon / 100;      // 1700-1750 arası muslim seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 6 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y7.Checked == true)
                {
                    salpiypip = (salpiysay * 10 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 10 * salmorbon / 100) - savdisbon / 100;      // 1750-1821 arası muslim seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 8 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else
                {
                    MessageBox.Show("Lütfen bir yıl aralığı seçiniz");
                }
            }
            else if (IG1.Checked == true) // Saldıran Indian Orduların Yıllara Göre Güçleri //
            {
                if (Y1.Checked == true)
                {
                    salpiypip = (salpiysay * 2 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 4 * salmorbon / 100) - savdisbon / 100;        // 1444-1500 arası Indian seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 1 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y2.Checked == true)
                {
                    salpiypip = (salpiysay * 3 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 4 * salmorbon / 100) - savdisbon / 100;        // 1500-1550 arası Indian seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 1 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y3.Checked == true)
                {
                    salpiypip = (salpiysay * 4 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 5 * salmorbon / 100) - savdisbon / 100;        // 1550-1600 arası Indian seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 2 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y4.Checked == true)
                {
                    salpiypip = (salpiysay * 5 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 5 * salmorbon / 100) - savdisbon / 100;        // 1600-1650 arası Indian seçildiyse ordu gücü //  
                    saltoppip = (saltopsay * 4 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y5.Checked == true)
                {
                    salpiypip = (salpiysay * 8 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 7 * salmorbon / 100) - savdisbon / 100;      // 1650-1700 arası Indian seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 6 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y6.Checked == true)
                {
                    salpiypip = (salpiysay * 8 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 9 * salmorbon / 100) - savdisbon / 100;      // 1700-1750 arası Indian seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 6 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y7.Checked == true)
                {
                    salpiypip = (salpiysay * 12 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 10 * salmorbon / 100) - savdisbon / 100;      // 1750-1821 arası Indian seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 8 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else
                {
                    MessageBox.Show("Lütfen bir yıl aralığı seçiniz");
                }
            }
            else if (NG1.Checked==true) // Saldıran Nomad Orduların Yıllara Göre Güçleri //
            {
                if (Y1.Checked == true)
                {
                    salpiypip = (salpiysay * 4 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 6 * salmorbon / 100) - savdisbon / 100;        // 1444-1500 arası Nomad seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 1 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y2.Checked == true)
                {
                    salpiypip = (salpiysay * 4 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 6 * salmorbon / 100) - savdisbon / 100;        // 1500-1550 arası Nomad seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 1 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y3.Checked == true)
                {
                    salpiypip = (salpiysay * 4 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 6 * salmorbon / 100) - savdisbon / 100;        // 1550-1600 arası Nomad seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 2 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y4.Checked == true)
                {
                    salpiypip = (salpiysay * 4 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 6 * salmorbon / 100) - savdisbon / 100;        // 1600-1650 arası Nomad seçildiyse ordu gücü //  
                    saltoppip = (saltopsay * 4 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y5.Checked == true)
                {
                    salpiypip = (salpiysay * 5 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 8 * salmorbon / 100) - savdisbon / 100;      // 1650-1700 arası Nomad seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 6 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y6.Checked == true)
                {
                    salpiypip = (salpiysay * 7 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 8 * salmorbon / 100) - savdisbon / 100;      // 1700-1750 arası Nomad seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 6 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y7.Checked == true)
                {
                    salpiypip = (salpiysay * 8 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 10 * salmorbon / 100) - savdisbon / 100;      // 1750-1821 arası Nomad seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 8 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else
                {
                    MessageBox.Show("Lütfen bir yıl aralığı seçiniz");
                }
            }
            else if (AFRG1.Checked==true) // Saldıran African Orduların Yıllara Göre Güçleri //
            {
                if (Y1.Checked == true)
                {
                    salpiypip = (salpiysay * 2 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 3 * salmorbon / 100) - savdisbon / 100;        // 1444-1500 arası African seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 1 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y2.Checked == true)
                {
                    salpiypip = (salpiysay * 4 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 3 * salmorbon / 100) - savdisbon / 100;        // 1500-1550 arası African seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 1 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y3.Checked == true)
                {
                    salpiypip = (salpiysay * 4 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 3 * salmorbon / 100) - savdisbon / 100;        // 1550-1600 arası African seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 2 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y4.Checked == true)
                {
                    salpiypip = (salpiysay * 4 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 4 * salmorbon / 100) - savdisbon / 100;        // 1600-1650 arası African seçildiyse ordu gücü //  
                    saltoppip = (saltopsay * 4 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y5.Checked == true)
                {
                    salpiypip = (salpiysay * 6 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 4 * salmorbon / 100) - savdisbon / 100;      // 1650-1700 arası African seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 6 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y6.Checked == true)
                {
                    salpiypip = (salpiysay * 6 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 6 * salmorbon / 100) - savdisbon / 100;      // 1700-1750 arası African seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 6 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y7.Checked == true)
                {
                    salpiypip = (salpiysay * 8 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 6 * salmorbon / 100) - savdisbon / 100;      // 1750-1821 arası African seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 8 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else
                {
                    MessageBox.Show("Lütfen bir yıl aralığı seçiniz");
                }
            }
            else if (CG1.Checked==true) // Saldıran Chinese Orduların Yıllara Göre Güçleri //
            {
                if (Y1.Checked == true)
                {
                    salpiypip = (salpiysay * 1 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 1 * salmorbon / 100) - savdisbon / 100;        // 1444-1500 arası Chinese seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 1 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y2.Checked == true)
                {
                    salpiypip = (salpiysay * 2 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 1 * salmorbon / 100) - savdisbon / 100;        // 1500-1550 arası Chinese seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 2 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y3.Checked == true)
                {
                    salpiypip = (salpiysay * 4 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 1 * salmorbon / 100) - savdisbon / 100;        // 1550-1600 arası Chinese seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 3 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y4.Checked == true)
                {
                    salpiypip = (salpiysay * 4 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 2 * salmorbon / 100) - savdisbon / 100;        // 1600-1650 arası Chinese seçildiyse ordu gücü //  
                    saltoppip = (saltopsay * 5 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y5.Checked == true)
                {
                    salpiypip = (salpiysay * 7 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 2 * salmorbon / 100) - savdisbon / 100;      // 1650-1700 arası Chinese seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 6 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y6.Checked == true)
                {
                    salpiypip = (salpiysay * 10* salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 4 * salmorbon / 100) - savdisbon / 100;      // 1700-1750 arası Chinese seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 6 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y7.Checked == true)
                {
                    salpiypip = (salpiysay * 12* salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 6 * salmorbon / 100) - savdisbon / 100;      // 1750-1821 arası Chinese seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 8 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else
                {
                    MessageBox.Show("Lütfen bir yıl aralığı seçiniz");
                }
            }
            else if (NA1.Checked==true) // Saldıran Native American Orduların Yıllara Göre Güçleri //
            {
                if (Y1.Checked == true)
                {
                    salpiypip = (salpiysay * 1 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 1 * salmorbon / 100) - savdisbon / 100;        // 1444-1500 arası Native American seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 1 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y2.Checked == true)
                {
                    salpiypip = (salpiysay * 1 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 1 * salmorbon / 100) - savdisbon / 100;        // 1500-1550 arası Native American seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 1 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y3.Checked == true)
                {
                    salpiypip = (salpiysay * 1 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 1 * salmorbon / 100) - savdisbon / 100;        // 1550-1600 arası Native American seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 1 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y4.Checked == true)
                {
                    salpiypip = (salpiysay * 3 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 1 * salmorbon / 100) - savdisbon / 100;        // 1600-1650 arası Native American seçildiyse ordu gücü //  
                    saltoppip = (saltopsay * 1 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y5.Checked == true)
                {
                    salpiypip = (salpiysay * 6 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 1 * salmorbon / 100) - savdisbon / 100;      // 1650-1700 arası Native American seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 2 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y6.Checked == true)
                {
                    salpiypip = (salpiysay * 8 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 4 * salmorbon / 100) - savdisbon / 100;      // 1700-1750 arası Native American seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 6 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y7.Checked == true)
                {
                    salpiypip = (salpiysay * 10 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 6 * salmorbon / 100) - savdisbon / 100;      // 1750-1821 arası Native American seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 8 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else
                {
                    MessageBox.Show("Lütfen bir yıl aralığı seçiniz");
                }
            }else if (HA1.Checked==true) // Saldıran High American Orduların Yıllara Göre Güçleri //
            {
                if (Y1.Checked == true)
                {
                    salpiypip = (salpiysay * 3 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 1 * salmorbon / 100) - savdisbon / 100;        // 1444-1500 arası High American seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 1 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y2.Checked == true)
                {
                    salpiypip = (salpiysay * 4 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 1 * salmorbon / 100) - savdisbon / 100;        // 1500-1550 arası High American seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 1 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y3.Checked == true)
                {
                    salpiypip = (salpiysay * 6 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 1 * salmorbon / 100) - savdisbon / 100;        // 1550-1600 arası High American seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 1 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y4.Checked == true)
                {
                    salpiypip = (salpiysay * 7 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 1 * salmorbon / 100) - savdisbon / 100;        // 1600-1650 arası High American seçildiyse ordu gücü //  
                    saltoppip = (saltopsay * 4 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y5.Checked == true)
                {
                    salpiypip = (salpiysay * 12 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 1 * salmorbon / 100) - savdisbon / 100;      // 1650-1700 arası High American seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 6 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y6.Checked == true)
                {
                    salpiypip = (salpiysay * 14 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 4 * salmorbon / 100) - savdisbon / 100;      // 1700-1750 arası High American seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 8 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else if (Y7.Checked == true)
                {
                    salpiypip = (salpiysay * 16 * salmorbon / 100) - savdisbon / 100;
                    salsuvpip = (salsuvsay * 6 * salmorbon / 100) - savdisbon / 100;      // 1750-1821 arası High American seçildiyse ordu gücü //
                    saltoppip = (saltopsay * 10 * salmorbon / 100) - savdisbon / 100;
                    salpip = salpiypip + salsuvpip + saltoppip;
                }
                else
                {
                    MessageBox.Show("Lütfen bir yıl aralığı seçiniz");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir teknoloji grubu seçiniz");
            }
            // saldıran taraf burda bitti //
           
            
            if (WG2.Checked == true)  // savunan Western ordularının yıllara göre güçleri //
            {
                if (Y1.Checked == true)
                {
                    savpiypip = (savpiysay * 1 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 2 * savmorbon / 100) - saldisbon / 100;       // 1444-1500 arası Western seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 1 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y2.Checked == true)
                {
                    savpiypip = (savpiysay * 2 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 2 * savmorbon / 100) - saldisbon / 100;       // 1500-1550 arası Western seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 2 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y3.Checked == true)
                {
                    savpiypip = (savpiysay * 5 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 4 * savmorbon / 100) - saldisbon / 100;       // 1550-1600 arası Western seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 3 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y4.Checked == true)
                {
                    savpiypip = (savpiysay * 6 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 3 * savmorbon / 100) - saldisbon / 100;       // 1600-1650 arası Western seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 6 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y5.Checked == true)
                {
                    savpiypip = (savpiysay * 10 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 6 * savmorbon / 100) - saldisbon / 100;       // 1650-1700 arası Western seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 8 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y6.Checked == true)
                {
                    savpiypip = (savpiysay * 12 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 10 * savmorbon / 100) - saldisbon / 100;       // 1700-1750 arası Western seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 10 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y7.Checked == true)
                {
                    savpiypip = (savpiysay * 14 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 12 * savmorbon / 100) - saldisbon / 100;       // 1750-1821 arası Western seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 12 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else
                {
                    MessageBox.Show("Lütfen bir yıl aralığı seçiniz");
                }
            }
            else if (EG2.Checked == true) // savunan Eastern ordularının yıllara göre güçleri //
            {
                if (Y1.Checked == true)
                {
                    savpiypip = (savpiysay * 1 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 2 * savmorbon / 100) - saldisbon / 100;      // 1444-1500 arası Eastern seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 1 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y2.Checked == true)
                {
                    savpiypip = (savpiysay * 3 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 4 * savmorbon / 100) - saldisbon / 100;      // 1500-1550 arası Eastern seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 2 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y3.Checked == true)
                {
                    savpiypip = (savpiysay * 5 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 4 * savmorbon / 100) - saldisbon / 100;       // 1550-1600 arası Eastern seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 3 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y4.Checked == true)
                {
                    savpiypip = (savpiysay * 6 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 4 * savmorbon / 100) - saldisbon / 100;      // 1600-1650 arası Eastern seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 6 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y5.Checked == true)
                {
                    savpiypip = (savpiysay * 8 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 8 * savmorbon / 100) - saldisbon / 100;      // 1650-1700 arası Eastern seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 8 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y6.Checked == true)
                {
                    savpiypip = (savpiysay * 10 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 14 * savmorbon / 100) - saldisbon / 100;      // 1700-1750 arası Eastern seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 10 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y7.Checked == true)
                {
                    savpiypip = (savpiysay * 12 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 14 * savmorbon / 100) - saldisbon / 100;      // 1750-1821 arası Eastern seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 12 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else
                {
                    MessageBox.Show("Lütfen bir yıl aralığı seçiniz");
                }
            }
            else if (ANAG2.Checked == true) // savunan Anatolian ordularının yıllara göre güçleri //
            {
                if (Y1.Checked == true)
                {
                    savpiypip = (savpiysay * 3 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 4 * savmorbon / 100) - saldisbon / 100;      // 1444-1500 arası Anatolian seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 3 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y2.Checked == true)
                {
                    savpiypip = (savpiysay * 5 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 6 * savmorbon / 100) - saldisbon / 100;      // 1500-1550 arası Anatolian seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 4 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y3.Checked == true)
                {
                    savpiypip = (savpiysay * 6 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 6 * savmorbon / 100) - saldisbon / 100;       // 1550-1600 arası Anatolian seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 4 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip * savsuvpip + savtoppip;
                }
                else if (Y4.Checked == true)
                {
                    savpiypip = (savpiysay * 6 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 8 * savmorbon / 100) - saldisbon / 100;      // 1600-1650 arası Anatolian seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 6 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y5.Checked == true)
                {
                    savpiypip = (savpiysay * 8 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 8 * savmorbon / 100) - saldisbon / 100;      // 1650-1700 arası Anatolian seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 8 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y6.Checked == true)
                {
                    savpiypip = (savpiysay * 10 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 10 * savmorbon / 100) - saldisbon / 100;      // 1700-1750 arası Anatolian seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 8 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y7.Checked == true)
                {
                    savpiypip = (savpiysay * 11 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 10 * savmorbon / 100) - saldisbon / 100;      // 1750-1821 arası Anatolian seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 10 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else
                {
                    MessageBox.Show("Lütfen bir yıl aralığı seçiniz");
                }
            }
            else if (MG2.Checked == true) // savunan Muslim ordularının yıllara göre güçleri //
            {
                if (Y1.Checked == true)
                {
                    savpiypip = (savpiysay * 2 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 3 * savmorbon / 100) - saldisbon / 100;      // 1444-1500 arası Muslim seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 1 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y2.Checked == true)
                {
                    savpiypip = (savpiysay * 3 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 4 * savmorbon / 100) - saldisbon / 100;      // 1500-1550 arası Muslim seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 1 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y3.Checked == true)
                {
                    savpiypip = (savpiysay * 4 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 4 * savmorbon / 100) - saldisbon / 100;       // 1550-1600 arası Muslim seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 2 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y4.Checked == true)
                {
                    savpiypip = (savpiysay * 5 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 4 * savmorbon / 100) - saldisbon / 100;      // 1600-1650 arası Muslim seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 4 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y5.Checked == true)
                {
                    savpiypip = (savpiysay * 7 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 6 * savmorbon / 100) - saldisbon / 100;      // 1650-1700 arası Muslim seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 6 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y6.Checked == true)
                {
                    savpiypip = (savpiysay * 8 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 8 * savmorbon / 100) - saldisbon / 100;      // 1700-1750 arası Muslim seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 6 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y7.Checked == true)
                {
                    savpiypip = (savpiysay * 10 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 10 * savmorbon / 100) - saldisbon / 100;      // 1750-1821 arası Muslim seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 8 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else
                {
                    MessageBox.Show("Lütfen bir yıl aralığı seçiniz");
                }
            }
            else if (IG2.Checked == true) // savunan Indian ordularının yıllara göre güçleri //
            {
                if (Y1.Checked == true)
                {
                    savpiypip = (savpiysay * 2 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 4 * savmorbon / 100) - saldisbon / 100;      // 1444-1500 arası Indian seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 1 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y2.Checked == true)
                {
                    savpiypip = (savpiysay * 3 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 4 * savmorbon / 100) - saldisbon / 100;      // 1500-1550 arası Indian seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 1 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y3.Checked == true)
                {
                    savpiypip = (savpiysay * 4 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 5 * savmorbon / 100) - saldisbon / 100;       // 1550-1600 arası Indian seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 2 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y4.Checked == true)
                {
                    savpiypip = (savpiysay * 5 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 5 * savmorbon / 100) - saldisbon / 100;      // 1600-1650 arası Indian seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 4 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y5.Checked == true)
                {
                    savpiypip = (savpiysay * 8 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 7 * savmorbon / 100) - saldisbon / 100;      // 1650-1700 arası Indian seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 6 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y6.Checked == true)
                {
                    savpiypip = (savpiysay * 8 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 9 * savmorbon / 100) - saldisbon / 100;      // 1700-1750 arası Indian seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 6 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y7.Checked == true)
                {
                    savpiypip = (savpiysay * 12 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 10 * savmorbon / 100) - saldisbon / 100;      // 1750-1821 arası Indian seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 8 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else
                {
                    MessageBox.Show("Lütfen bir yıl aralığı seçiniz");
                }
            }
            else if (NG2.Checked == true) // savunan Nomad ordularının yıllara göre güçleri //
            {
                if (Y1.Checked == true)
                {
                    savpiypip = (savpiysay * 4 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 6 * savmorbon / 100) - saldisbon / 100;      // 1444-1500 arası Nomad seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 1 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y2.Checked == true)
                {
                    savpiypip = (savpiysay * 4 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 6 * savmorbon / 100) - saldisbon / 100;      // 1500-1550 arası Nomad seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 1 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y3.Checked == true)
                {
                    savpiypip = (savpiysay * 4 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 6 * savmorbon / 100) - saldisbon / 100;       // 1550-1600 arası Nomad seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 2 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y4.Checked == true)
                {
                    savpiypip = (savpiysay * 4 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 6 * savmorbon / 100) - saldisbon / 100;      // 1600-1650 arası Nomad seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 4 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y5.Checked == true)
                {
                    savpiypip = (savpiysay * 5 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 8 * savmorbon / 100) - saldisbon / 100;      // 1650-1700 arası Nomad seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 6 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y6.Checked == true)
                {
                    savpiypip = (savpiysay * 7 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 8 * savmorbon / 100) - saldisbon / 100;      // 1700-1750 arası Nomad seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 6 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y7.Checked == true)
                {
                    savpiypip = (savpiysay * 8 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 10 * savmorbon / 100) - saldisbon / 100;      // 1750-1821 arası Nomad seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 8 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else
                {
                    MessageBox.Show("Lütfen bir yıl aralığı seçiniz");
                }
            }
            else if (AFRG2.Checked == true) // savunan African ordularının yıllara göre güçleri //
            {
                if (Y1.Checked == true)
                {
                    savpiypip = (savpiysay * 2 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 3 * savmorbon / 100) - saldisbon / 100;      // 1444-1500 arası African seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 1 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y2.Checked == true)
                {
                    savpiypip = (savpiysay * 4 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 3 * savmorbon / 100) - saldisbon / 100;      // 1500-1550 arası African seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 1 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y3.Checked == true)
                {
                    savpiypip = (savpiysay * 4 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 3 * savmorbon / 100) - saldisbon / 100;       // 1550-1600 arası African seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 2 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y4.Checked == true)
                {
                    savpiypip = (savpiysay * 4 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 4 * savmorbon / 100) - saldisbon / 100;      // 1600-1650 arası African seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 4 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y5.Checked == true)
                {
                    savpiypip = (savpiysay * 6 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 4 * savmorbon / 100) - saldisbon / 100;      // 1650-1700 arası African seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 6 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y6.Checked == true)
                {
                    savpiypip = (savpiysay * 6 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 6 * savmorbon / 100) - saldisbon / 100;      // 1700-1750 arası African seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 6 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y7.Checked == true)
                {
                    savpiypip = (savpiysay * 8 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 6 * savmorbon / 100) - saldisbon / 100;      // 1750-1821 arası African seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 8 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else
                {
                    MessageBox.Show("Lütfen bir yıl aralığı seçiniz");
                }
            }
            else if (CG2.Checked == true) // savunan Chinese ordularının yıllara göre güçleri //
            {
                if (Y1.Checked == true)
                {
                    savpiypip = (savpiysay * 1 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 1 * savmorbon / 100) - saldisbon / 100;      // 1444-1500 arası Chinese seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 1 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y2.Checked == true)
                {
                    savpiypip = (savpiysay * 2 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 1 * savmorbon / 100) - saldisbon / 100;      // 1500-1550 arası Chinese seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 2 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y3.Checked == true)
                {
                    savpiypip = (savpiysay * 4 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 1 * savmorbon / 100) - saldisbon / 100;       // 1550-1600 arası Chinese seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 3 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y4.Checked == true)
                {
                    savpiypip = (savpiysay * 4 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 2 * savmorbon / 100) - saldisbon / 100;      // 1600-1650 arası Chinese seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 5 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y5.Checked == true)
                {
                    savpiypip = (savpiysay * 7 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 2 * savmorbon / 100) - saldisbon / 100;      // 1650-1700 arası Chinese seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 6 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y6.Checked == true)
                {
                    savpiypip = (savpiysay * 10 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 4* savmorbon / 100) - saldisbon / 100;      // 1700-1750 arası Chinese seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 6 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y7.Checked == true)
                {
                    savpiypip = (savpiysay * 12 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 6 * savmorbon / 100) - saldisbon / 100;      // 1750-1821 arası Chinese seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 8 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else
                {
                    MessageBox.Show("Lütfen bir yıl aralığı seçiniz");
                }
            }
            else if (NA2.Checked == true) // savunan Native American ordularının yıllara göre güçleri //
            {
                if (Y1.Checked == true)
                {
                    savpiypip = (savpiysay * 1 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 1 * savmorbon / 100) - saldisbon / 100;      // 1444-1500 arası Native American seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 1 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y2.Checked == true)
                {
                    savpiypip = (savpiysay * 1 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 1 * savmorbon / 100) - saldisbon / 100;      // 1500-1550 arası Native American seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 1 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y3.Checked == true)
                {
                    savpiypip = (savpiysay * 1 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 1 * savmorbon / 100) - saldisbon / 100;       // 1550-1600 arası Native American seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 1 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y4.Checked == true)
                {
                    savpiypip = (savpiysay * 3 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 1 * savmorbon / 100) - saldisbon / 100;      // 1600-1650 arası Native American seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 1 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y5.Checked == true)
                {
                    savpiypip = (savpiysay * 6 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 1 * savmorbon / 100) - saldisbon / 100;      // 1650-1700 arası Native American seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 2 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y6.Checked == true)
                {
                    savpiypip = (savpiysay * 8 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 4 * savmorbon / 100) - saldisbon / 100;      // 1700-1750 arası Native American seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 6 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y7.Checked == true)
                {
                    savpiypip = (savpiysay * 10 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 6 * savmorbon / 100) - saldisbon / 100;      // 1750-1821 arası Native American seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 8 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else
                {
                    MessageBox.Show("Lütfen bir yıl aralığı seçiniz");
                }
            }
            else if (HG2.Checked == true) // savunan High American ordularının yıllara göre güçleri //
            {
                if (Y1.Checked == true)
                {
                    savpiypip = (savpiysay * 3 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 1 * savmorbon / 100) - saldisbon / 100;      // 1444-1500 arası High American seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 1 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y2.Checked == true)
                {
                    savpiypip = (savpiysay * 4 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 1 * savmorbon / 100) - saldisbon / 100;      // 1500-1550 arası High American seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 1 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y3.Checked == true)
                {
                    savpiypip = (savpiysay * 6 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 1 * savmorbon / 100) - saldisbon / 100;       // 1550-1600 arası High American seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 1 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y4.Checked == true)
                {
                    savpiypip = (savpiysay * 7 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 1 * savmorbon / 100) - saldisbon / 100;      // 1600-1650 arası High American seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 4 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y5.Checked == true)
                {
                    savpiypip = (savpiysay * 12 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 1 * savmorbon / 100) - saldisbon / 100;     // 1650-1700 arası High American seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 6 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y6.Checked == true)
                {
                    savpiypip = (savpiysay * 14 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 4 * savmorbon / 100) - saldisbon / 100;      // 1700-1750 arası High American seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 8 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else if (Y7.Checked == true)
                {
                    savpiypip = (savpiysay * 16 * savmorbon / 100) - saldisbon / 100;
                    savsuvpip = (savsuvsay * 6  * savmorbon / 100) - saldisbon / 100;       // 1750-1821 arası High American seçildiyse ordu gücü //
                    savtoppip = (savtopsay * 10 * savmorbon / 100) - saldisbon / 100;
                    savpip = savpiypip + savsuvpip + savtoppip;
                }
                else
                {
                    MessageBox.Show("Lütfen bir yıl aralığı seçiniz");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir teknoloji grubu seçiniz");
            }

            // savunan tarafın ordusu burda bitiyor //
           
            double arazi =0; // arazinin değeri burda hesaba katılıyor //
           
            if (AB1.Checked == true)
            {
                arazi = 0;
            }else if (AB2.Checked == true)    // 0=düzlük arazi; -1=tepelik,bataklık,ormanlık arazi; -2= dağlık,çöl,buzul arazi //
            {
                arazi = - 1;
            }else if (AB3.Checked == true)
            {
                arazi = - 2;
            }
            else
            {
                arazi = arazi + 0;
            }
           
            if(NV.Checked==true)  // nehir geçidi olup olamamasını kontrol edildiği yer, varsa arazi -1 azalır ve savunan dah avantajlı olur //
            {
                arazi = arazi - 1;
            }
            else if(NY.Checked==true)
            {
                arazi = arazi + 0;
            }
            else
            {
                arazi = arazi + 0;
            }

            if (M1.Checked == true)  // mevsimleri kontrol eden bölüm; ilk bahar ve yaz saldırana, son bahar ve kış savunana bonus verir //
            {
                arazi = arazi - 0.5;
            }
            else if (M2.Checked == true)
            {
                arazi = arazi + 0.5;
            }
            else if (M3.Checked == true)
            {
                arazi = arazi + 1;
            }
            else if (M4.Checked == true)
            {
                arazi = arazi - 1;
            }
            else{
                arazi = arazi + 0;
            }
           
            if (H1.Checked == true)   // hava durumunu kontrol eden bölüm; güneşli,bulutlu,sisli saldırana bonus verir, yağmurlu,karlı,sağnak yağmurlu, rüzgarlı savunana bonus verir //
            {
                arazi = arazi - 0.25;
            }
            else if (H2.Checked == true)
            {
                arazi = arazi + 0.25;
            }
            else if (H3.Checked == true)
            {
                arazi = arazi - 0.3;
            }
            else if (H4.Checked == true)
            {
                arazi = arazi + 0.3;
            }
            else if (H5.Checked == true)
            {
                arazi = arazi + 0.25;
            }
            else if (H6.Checked == true)
            {
                arazi = arazi - 0.25;
            }
            else if (H7.Checked == true)
            {
                arazi = arazi - 0.5;
            }
            else
            {
                arazi = arazi + 0;
            }
           double savunankomutan=0;
            double saldırankomutan = 0;
            if (SALK1.Checked == true)
            {
                saldırankomutan = 0.5;
            }else if (SALK2.Checked == true)
            {
                saldırankomutan = 0.75;
            }
        else if (SALK3.Checked == true)
            {
                saldırankomutan = 1;
            }else
            {
                saldırankomutan = 0;

            }
            if (SAVK1.Checked == true)
            {
                savunankomutan = 0.5;
            }
            else if (SAVK2.Checked == true)
            {
                savunankomutan = 0.75;
            }
            else if (SAVK3.Checked == true)
            {
                savunankomutan = 1;
            }
            else
            {
                savunankomutan = 0;
            }                                 
            if (salpip * (roll + arazi+saldırankomutan) > savpip * (roll+savunankomutan))
            {
                MessageBox.Show("Saldıran Kazandı.");
            }else if(salpip * (roll + arazi+saldırankomutan) < savpip * (roll+savunankomutan))
            {
                MessageBox.Show("Savunan Kazandı.");
            }
            else
            {
                MessageBox.Show("Berabere.");
            }
        }
        private void Cıkıs_Click(object sender, EventArgs e) // programı kapatan buton //
        {
            this.Close();          
        }
        private void Form1_Load(object sender, EventArgs e)   // başlangıç yazısını //
        {
            MessageBox.Show("EU4 Battle Simulator programına hoşgeldiniz, bu program sizlere Europa Universalis 4 oyununda savaşların sonuçlarını oyunda savaş yapmadan sonucu tahmin etmekte yardımcı olur."); // giriş mesajı //
        }

        private void button2_Click(object sender, EventArgs e) // Bilgi Alma Bölümü // 
        {
            if (B1.Checked == true)
            {
                MessageBox.Show("Western: Batı Avrupa ülkeleridir oyun başı güçsüz ama yıllar geçtikçe teknolojilerini artıran devletlerdir.");     
            }
            else if (B2.Checked == true)
            {
                MessageBox.Show("Eastern: Doğu Avrupa ülkeleridir oyuna başı güçsüz başlarlar, son 2 çağda güçlüdürler.");   
            }
            else if (B3.Checked == true)
            {
                MessageBox.Show("Indian: Hindistan ülkeleridir, oyuna normal başlayıp yavaş yavaş güçlenip son 2 çağda güçsüzleşirler.");
            }
            else if (B4.Checked == true)
            {
                MessageBox.Show("Nomad: Göçebe ülkelerdir, oyuna çok güçlü başlayıp yavaş yavaş güçsüzleşirler.");
            }
            else if (B5.Checked == true)
            {
                MessageBox.Show("High American: Maya-Aztek-İnka medeniyetleridirler, ilk çağlar süvari ve topları kötüdür, sonradan güçlenirler.");
            }
            else if (B6.Checked == true)
            {
                MessageBox.Show("Anatolian: Anadolu ülkelerdir, ilk 3 çağ orduları güçlüdür sonraki çağlarda yavaş yavaş güçsüzleşirler.");
            }
            else if (B7.Checked == true)
            {
                MessageBox.Show("Muslim: İran,Arabistan ve Kuze Afrikadaki ülkelerdir, oyuna normal güçte başlayıp yavaş yavaş güçsüzleşirler.");
            }
            else if (B8.Checked == true)
            {
                MessageBox.Show("African: Güney-Batı-Doğu Afrika ülkeleridirler, ilk 2 çağ dışında güçsüzdürler.");
            }
            else if (B9.Checked == true)
            {
                MessageBox.Show("Chinese: Uzak Doğu ülkeleridirler, oyuna güçsüz başlayıp yavaş yavaş güçlenirler.");
            }
            else if (B10.Checked == true)
            {
                MessageBox.Show("Native American: Gelişmemiş Amerika yerlileridirler, son çağlara kadar orduları çok güçsüzdür.");
            }
            else if (YB1.Checked == true)
            {
                MessageBox.Show("Avrupada Papa yönetimine karşı eylemler hızlanmaya başladı, yeni dünya keşvedildi ama daha etkisi görünmedi,İstanbulun fethi İtalyada rönesans hareketlerinin filizlenmesine rol açtı .");
            }
            else if (YB2.Checked == true)
            {
                MessageBox.Show("İspanya ve Portekiz yeni keşfedilen kıtaya akın ediyor daha şimdiden topraklar paylaşıldı bile, Protestanlık ortaya çıktı, Türklerin baharat ve ipek yolunu komple eline almaları Avrupanın keşiflere verdiği önemi arttırdı,Babür ve Safevi Kuruldu, Rusalar kuzeyi hakimiyet altına aldı.");
            }
            else if (YB3.Checked == true)
            {
                MessageBox.Show("Kutsal Roma İmparatorluğu içindeki prensliklerde protestanlık ciddi derecede arttı savaş kaçınılmaz noktaya varıyor, Meksika ve Peruda kurulan kolonilerden Avrupaya çok fazla altın geliyor, Osmanlı duraklama dönemine girdi ama hala Avrupayı korkutuyor.");
            }
            else if (YB4.Checked == true)
            {
                MessageBox.Show("Avrupada 30 yıl savaşları patlak verdi Avrupadaki nerdeyse her ülke bu savaşa dolaylıda olsa katıldı, İngiltere ve Fransa yeni kıtaya adım attı, Hollandalılar Afrika ve Asyada gelişirken İspanyolarla büyük bir mücahadeleye girdi, İsveç Krallığı büyüyor, Qing hanedanlığı çini ele geçirdi yüzlerce yıllık Ming hanedanlığı çöktü .");
            }
            else if (YB5.Checked == true)
            {
                MessageBox.Show("Amerikadaki ve Afrikadaki koloni bölgeleri için savaşlar çıkmaya başladı, Hollanda ve Portekiz Hindistan ve doğu asyada ciddi güç edindi, Ruslar sibiryayı komple kolonize etti, Osmanlı Viyana önlerinde büyük bir mağlubiyet aldı ve gerilemeye başladı.");
            }
            else if (YB6.Checked == true)
            {
                MessageBox.Show("Kuzey Almanya Prusyanın etkisinde eski kalabalık prenslikler git gide azalmaya başladı, İspanyada asya üzerine yoğunlaşmaya başlaıdı, İngiltere ve Fransa Amerika için mücahadele ediyor, saniyileşmenin adımları atılıyor, Avrupa artık dünyanın en zengin bölgesi.");
            }
            else if (YB7.Checked == true)
            {
                MessageBox.Show("Fransa Kanadadaki topraklarını İngiltereye kaptırdı ama hemen ardından 13 Koloni bölgesi isyan edip Birleşik devletleri kurdu ve İngiltere ile kanlı bir savaşa girdi, sanayileşme hızlanmaya başladı artık kömür sanayide kullanıldığı için çok değerli, İspanyanın kolonilerinde isyan alarmları var, İngiltere Hindistana adım atıp hızla büyüdü, Fransada bir devrim yaşandı ve bunun etkisiyle çok kültürlü avrupa ülkeleri büyük isyan riski içinde, Napolyon Fransaya altın çağını yaşattı ama yükselişi nasılsa çöküşüde öyle oldu büyük koalsiyon fransayı yendi.");
            }
        }
    }

}
