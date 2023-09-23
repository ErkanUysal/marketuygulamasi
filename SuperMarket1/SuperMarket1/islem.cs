using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket1
{
    public class islem
    {
        List<gıdaurun> manav = new List<gıdaurun>();
        List<gıdaurun> gıda = new List<gıdaurun>();
        List<teknolojiurun> tlf = new List<teknolojiurun>();
        List<teknolojiurun> pc = new List<teknolojiurun>();
        List<calisanlar> kisi = new List<calisanlar>();       
        public islem()
        {
            #region GIDA

            #region Manav

            manav.Add(new gıdaurun() { Isim = "Domates", birim = "KG", stok = 100, fiyat = 35, kdv = 0.01 });
            manav.Add(new gıdaurun() { Isim = "Soğan", birim = "KG", stok = 100, fiyat = 50, kdv = 0.01 });
            manav.Add(new gıdaurun() { Isim = "Biber", birim = "KG", stok = 100, fiyat = 30, kdv = 0.01 });
            manav.Add(new gıdaurun() { Isim = "Patlıcan", birim = "KG", stok = 100, fiyat = 42, kdv = 0.01 });
            manav.Add(new gıdaurun() { Isim = "Limon", birim = "KG", stok = 150, fiyat = 55, kdv = 0.01 });
            manav.Add(new gıdaurun() { Isim = "Elma", birim = "KG", stok = 50, fiyat = 45, kdv = 0.01 });
            manav.Add(new gıdaurun() { Isim = "Armut", birim = "KG", stok = 70, fiyat = 34, kdv = 0.01 });
            manav.Add(new gıdaurun() { Isim = "Erik", birim = "KG", stok = 50, fiyat = 145, kdv = 0.01, });
            manav.Add(new gıdaurun() { Isim = "Üzüm", birim = "KG", stok = 20, fiyat = 60, kdv = 0.01 });
            manav.Add(new gıdaurun() { Isim = "Portakal", birim = "KG", stok = 50, fiyat = 80, kdv = 0.01 });

            #endregion

            #region Yiyecek

            gıda.Add(new gıdaurun() { Isim = "Makarna", birim = "Paket", stok = 300, fiyat = 70, kdv = 0.01 });
            gıda.Add(new gıdaurun() { Isim = "Bulgur", birim = "Paket", stok = 200, fiyat = 80, kdv = 0.01 });
            gıda.Add(new gıdaurun() { Isim = "Yumurta", birim = "Tane", stok = 1500, fiyat = 3, kdv = 0.01 });
            gıda.Add(new gıdaurun() { Isim = "Sosis", birim = "Paket", stok = 1500, fiyat = 45, kdv = 0.01, });
            gıda.Add(new gıdaurun() { Isim = "Çay", birim = "Paket", stok = 500, fiyat = 52, kdv = 0.01, });
            gıda.Add(new gıdaurun() { Isim = "Sucuk", birim = "KG", stok = 100, fiyat = 90, kdv = 0.01, });
            gıda.Add(new gıdaurun() { Isim = "Salam", birim = "Paket", stok = 90, fiyat = 50, kdv = 0.01, });
            gıda.Add(new gıdaurun() { Isim = "Yoğurt", birim = "KG", stok = 50, fiyat = 40, kdv = 0.01, });
            gıda.Add(new gıdaurun() { Isim = "Peynir", birim = "KG", stok = 50, fiyat = 45, kdv = 0.01, });
            gıda.Add(new gıdaurun() { Isim = "Zeytin", birim = "KG", stok = 50, fiyat = 75, kdv = 0.01, });

            #endregion



            #endregion

            #region TEKNOLOJİ
            #region Telefon

            tlf.Add(new teknolojiurun() { Marka = "Apple", Model = "İphone 14", Stok = 5, Fiyat = 44199, kdv = 0.20 });
            tlf.Add(new teknolojiurun() { Marka = "Apple", Model = "İphone 14 Plus", Stok = 5, Fiyat = 46999, kdv = 0.20 });
            tlf.Add(new teknolojiurun() { Marka = "Apple", Model = "İphone 14 Pro", Stok = 3, Fiyat = 60498, kdv = 0.20 });
            tlf.Add(new teknolojiurun() { Marka = "Apple", Model = "İphone 14 Pro Max", Stok = 3, Fiyat = 77999, kdv = 0.20 });
            tlf.Add(new teknolojiurun() { Marka = "Apple", Model = "İphone 13", Stok = 5, Fiyat = 40499, kdv = 0.20 });
            tlf.Add(new teknolojiurun() { Marka = "Apple", Model = "İphone 13 Mini", Stok = 5, Fiyat = 40400, kdv = 0.20 });
            tlf.Add(new teknolojiurun() { Marka = "Apple", Model = "İphone 13 Pro", Stok = 4, Fiyat = 59499, kdv = 0.20 });
            tlf.Add(new teknolojiurun() { Marka = "Apple", Model = "İphone 13 Pro Max", Stok = 4, Fiyat = 69000, kdv = 0.20 });
            tlf.Add(new teknolojiurun() { Marka = "Apple", Model = "İphone 12", Stok = 7, Fiyat = 34998, kdv = 0.20 });
            tlf.Add(new teknolojiurun() { Marka = "Apple", Model = "İphone 11", Stok = 10, Fiyat = 24498, kdv = 0.20 });

            #endregion

            #region Bilgisayar

            pc.Add(new teknolojiurun() { Marka = "Apple", Model = "Macbook Air M1", Stok = 10, Fiyat = 25999, kdv = 0.20 });
            pc.Add(new teknolojiurun() { Marka = "Apple", Model = "Macbook Air Pro 16 M1", Stok = 3, Fiyat = 67999, kdv = 0.20 });
            pc.Add(new teknolojiurun() { Marka = "Apple", Model = "Macbook Air M2", Stok = 15, Fiyat = 34195, kdv = 0.20 });
            pc.Add(new teknolojiurun() { Marka = "Monster", Model = "Abra A7 V17.6.2", Stok = 10, Fiyat = 39299, kdv = 0.20 });
            pc.Add(new teknolojiurun() { Marka = "Monster", Model = "Abra A7 V13.2.7", Stok = 20, Fiyat = 26899, kdv = 0.20 });
            pc.Add(new teknolojiurun() { Marka = "Monster", Model = "Abra A5 V20.3.1", Stok = 10, Fiyat = 37099, kdv = 0.20 });
            pc.Add(new teknolojiurun() { Marka = "Monster", Model = "Abra A5 V20.2.1", Stok = 15, Fiyat = 32799, kdv = 0.20 });
            pc.Add(new teknolojiurun() { Marka = "Monster", Model = "Abra A5 V17.4.3", Stok = 20, Fiyat = 30999, kdv = 0.20 });

            #endregion



            #endregion

            #region Calışanlar
            kisi.Add(new calisanlar() { Isim = "Erkan", Soyisim = "Uysal", Reyon = "Manav", CalisanNo = "10" , uzmanlık = "Müşteri Temsilcisi" });
            kisi.Add(new calisanlar() { Isim = "Ahmet", Soyisim = "Can", Reyon = "Gıda", CalisanNo = "27" , uzmanlık = "Müşteri Temsilcisi" });
            kisi.Add(new calisanlar() { Isim = "İbrahim", Soyisim = "Sarıkaya", Reyon = "Teknoloji", CalisanNo = "14", uzmanlık = "Müşteri Temsilcisi" });
            kisi.Add(new calisanlar() { Isim = "Mehmet", Soyisim = "Kaya", Reyon = "Telefon", CalisanNo = "14", uzmanlık = "Reyon Görevlisi" });
            kisi.Add(new calisanlar() { Isim = "Doğan", Soyisim = "Kara", Reyon = "Manav", CalisanNo = "18" , uzmanlık = "Reyon Görevlisi" });
            kisi.Add(new calisanlar() { Isim = "Leyla", Soyisim = "Ak", Reyon = "Gıda", CalisanNo = "47", uzmanlık = "Reyon Görevlisi" });
            kisi.Add(new calisanlar() { Isim = "Ayşe", Soyisim = "Altın", Reyon = "Bilgisayar", CalisanNo = "79", uzmanlık = "Reyon Görevlisi" });

            #endregion


        }

        public void listelemanav()
        {
           
            for (int i = 0; i < manav.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {manav[i].Isim} {manav[i].fiyat} TL");

            }
            for (int j = 0; j < kisi.Count; j++)
            {
                if (kisi[j].Reyon == "Manav" && kisi[j].uzmanlık == "Reyon Görevlisi")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Reyon Görevlisi = {kisi[j].Isim} {kisi[j].Soyisim}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
        public void listelegıda()
        {
           
            for (int i = 0; i < gıda.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {gıda[i].Isim} {gıda[i].fiyat} TL");
            }
            for (int j = 0; j < kisi.Count; j++)
            {
                if (kisi[j].Reyon == "Gıda" && kisi[j].uzmanlık == "Reyon Görevlisi")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Reyon Görevlisi = {kisi[j].Isim} {kisi[j].Soyisim}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
        public void listeletelefon()
        {
           
            for (int i = 0; i < tlf.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {tlf[i].Marka} {tlf[i].Model} {tlf[i].Fiyat} TL");
            }
            for (int j = 0; j < kisi.Count; j++)
            {
                if (kisi[j].Reyon == "Telefon" && kisi[j].uzmanlık == "Reyon Görevlisi")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Reyon Görevlisi = {kisi[j].Isim} {kisi[j].Soyisim}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
        public void listelepc()
        {
           
            for (int i = 0; i < pc.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {pc[i].Marka} {pc[i].Model} {pc[i].Fiyat} TL");
            }
            for (int j = 0; j < kisi.Count; j++)
            {
                if (kisi[j].Reyon == "Bilgisayar" && kisi[j].uzmanlık == "Reyon Görevlisi")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Reyon Görevlisi = {kisi[j].Isim} {kisi[j].Soyisim}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
        public void listelecalisan()
        {
            Console.WriteLine("Merhaba Bütün Çalışanlarımız Aşağıda Listelenmiştir");
            for (int i = 0;i < kisi.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"{kisi[i].CalisanNo} Numaralı Çalışan");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"İsim = {kisi[i].Isim}\nSoyisim = {kisi[i].Soyisim}\nReyon = {kisi[i].Reyon}\nUzmanlık Alanı = {kisi[i].uzmanlık}\n");
            }
        }
        public void reyonlistele(string secenek)
        {
            
            for (int i = 0; i < kisi.Count; i++)
            {
                
                if (secenek == "1" && kisi[i].Reyon == "Manav")
                {                 
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{kisi[i].CalisanNo} Numaralı Çalışan");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"İsim = {kisi[i].Isim}\nSoyisim = {kisi[i].Soyisim}\nReyon = {kisi[i].Reyon}\nUzmanlık Alanı = {kisi[i].uzmanlık}\n");                                      
                }
                else if (secenek == "2" && kisi[i].Reyon == "Gıda")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{kisi[i].CalisanNo} Numaralı Çalışan");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"İsim = {kisi[i].Isim}\nSoyisim = {kisi[i].Soyisim}\nReyon = {kisi[i].Reyon}\nUzmanlık Alanı = {kisi[i].uzmanlık}\n");
                }
                else if (secenek == "3" && kisi[i].Reyon == "Telefon")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{kisi[i].CalisanNo} Numaralı Çalışan");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"İsim = {kisi[i].Isim}\nSoyisim = {kisi[i].Soyisim}\nReyon = {kisi[i].Reyon}\nUzmanlık Alanı = {kisi[i].uzmanlık}\n");
                }
                else if (secenek == "4" && kisi[i].Reyon == "Bilgisayar")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{kisi[i].CalisanNo} Numaralı Çalışan");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"İsim = {kisi[i].Isim}\nSoyisim = {kisi[i].Soyisim}\nReyon = {kisi[i].Reyon}\nUzmanlık Alanı = {kisi[i].uzmanlık}\n");
                }
            }          
        }
        public void departmanlistele(string secenek)
        {
            for (int i = 0; i < kisi.Count; i++)
            {
                if (secenek == "1" && kisi[i].uzmanlık == "Müşteri Temsilcisi")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{kisi[i].CalisanNo} Numaralı Çalışan");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"İsim = {kisi[i].Isim}\nSoyisim = {kisi[i].Soyisim}\nReyon = {kisi[i].Reyon}\n");
                }
                else if (secenek == "2" && kisi[i].uzmanlık == "Reyon Görevlisi")
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{kisi[i].CalisanNo} Numaralı Çalışan");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"İsim = {kisi[i].Isim}\nSoyisim = {kisi[i].Soyisim}\nReyon = {kisi[i].Reyon}\n");
                }

            }
        }
        public string isimbirimGetir(string secenek, int un)
        {
            if (secenek == "1")
            {

                Console.Write($"Kaç {gıda[un - 1].birim} {gıda[un - 1].Isim} Almak İstiyorsunuz? = ");

            }
            else if (secenek == "2")
            {
                Console.Write($"Kaç {manav[un - 1].birim} {manav[un - 1].Isim} Almak İstiyorsunuz? = ");

            }

            return secenek;
        }
        public string isimbirimtek(string secenek, int un)
        {
            if (secenek == "1")
            {
                Console.Write($"Kaç Adet {tlf[un - 1].Marka} {tlf[un - 1].Model} Almak İstiyorsunuz? = ");
            }
            else if (secenek == "2")
            {
                Console.Write($"Kaç Adet {pc[un - 1].Marka} {pc[un - 1].Model}  Almak İstiyorsunuz? = ");
            }
            return secenek;
        }
        public double hesap(string secenek, int un, int adet)
        {
            double toplamfiyat = 0;

            if (secenek == "1")
            {
                toplamfiyat += gıda[un - 1].fiyat * adet;
            }
            else
            {
                toplamfiyat += manav[un - 1].fiyat * adet;
            }

            return toplamfiyat;
        }
        public double hesap1(string secenek, int un, int adet)
        {
            double toplamfiyat = 0;
            if (secenek == "1")
            {
                toplamfiyat += tlf[un - 1].Fiyat * adet;
            }
            else
            {
                toplamfiyat += pc[un - 1].Fiyat * adet;
            }
            return toplamfiyat;
        }
        public void uruneklepc()
        {
            Console.WriteLine("Eklemek İstediğiniz Ürünü Girin");
            Console.Write("Marka = ");
            string marka = Console.ReadLine();
            Console.Write("Model = ");
            string model = Console.ReadLine();
            Console.Write("Stok = ");
            int stok = Convert.ToInt32(Console.ReadLine());
            Console.Write("Fiyat = ");
            double fiyat = Convert.ToDouble(Console.ReadLine());
            Console.Write("KDV = ");
            double kdv = Convert.ToDouble(Console.ReadLine());
            pc.Add(new teknolojiurun() { Marka = marka, Model = model, Stok = stok, Fiyat = fiyat, kdv = kdv });
        }
        public void urunekletlf()
        {
            Console.WriteLine("Eklemek İstediğiniz Ürünü Girin");
            Console.Write("Marka = ");
            string marka = Console.ReadLine();
            Console.Write("Model = ");
            string model = Console.ReadLine();
            Console.Write("Stok = ");
            int stok = Convert.ToInt32(Console.ReadLine());
            Console.Write("Fiyat = ");
            double fiyat = Convert.ToDouble(Console.ReadLine());
            Console.Write("KDV = ");
            double kdv = Convert.ToDouble(Console.ReadLine());
            tlf.Add(new teknolojiurun() { Marka = marka, Model = model, Stok = stok, Fiyat = fiyat, kdv = kdv });
        }
        public void uruneklemanav()
        {
            Console.WriteLine("Eklemek İstediğiniz Ürün Bilgilerini Giriniz");
            Console.Write("İsim = ");
            string isim = Console.ReadLine();
            Console.Write("Fiyat = ");
            double fiyat = Convert.ToDouble(Console.ReadLine());
            Console.Write("Birim = ");
            string birim = Console.ReadLine();
            Console.Write("Stok = ");
            int stok = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kdv = ");
            double kdv = Convert.ToDouble(Console.ReadLine());
            manav.Add(new gıdaurun() { Isim = isim, fiyat = fiyat, birim = birim, stok = stok, kdv = kdv });
        }
        public void urunekleyiyecek()
        {
            Console.WriteLine("Eklemek İstediğiniz Ürün Bilgilerini Giriniz");
            Console.Write("İsim = ");
            string isim = Console.ReadLine();
            Console.Write("Fiyat = ");
            double fiyat = Convert.ToDouble(Console.ReadLine());
            Console.Write("Birim = ");
            string birim = Console.ReadLine();
            Console.Write("Stok = ");
            int stok = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kdv = ");
            double kdv = Convert.ToDouble(Console.ReadLine());
            gıda.Add(new gıdaurun() { Isim = isim, fiyat = fiyat, birim = birim, stok = stok, kdv = kdv });
        }
        public double fiyatguncellemanav(int urunno)
        {
            double guncelfiyat = 0;
            Console.Write($"{manav[urunno - 1].Isim} Yeni Fiyatını Giriniz = ");
            guncelfiyat = Convert.ToDouble(Console.ReadLine());
            manav[urunno - 1].fiyat = guncelfiyat;
            return guncelfiyat;
        }
        public double fiyatgüncellegıda(int urunno)
        {
            double guncelfiyat = 0;
            Console.Write($"{gıda[urunno - 1].Isim} Yeni Fiyatını Giriniz = ");
            guncelfiyat = Convert.ToDouble(Console.ReadLine());
            gıda[urunno - 1].fiyat = guncelfiyat;
            return guncelfiyat;
        }
        public double fiyatgüncellepc(int urunno)
        {
            double guncelfiyat = 0;
            Console.Write($"{pc[urunno - 1].Marka} {pc[urunno - 1].Model} Yeni Fiyatını Giriniz = ");
            guncelfiyat = Convert.ToDouble(Console.ReadLine());
            pc[urunno - 1].Fiyat = guncelfiyat;
            return guncelfiyat;
        }
        public double fiyatgüncelletlf(int urunno)
        {
            double guncelfiyat = 0;
            Console.Write($"{tlf[urunno - 1].Marka} {tlf[urunno - 1].Model} Yeni Fiyatını Giriniz = ");
            guncelfiyat = Convert.ToDouble(Console.ReadLine());
            tlf[urunno - 1].Fiyat = guncelfiyat;
            return guncelfiyat;
        }
        public double kdvgıda(int urunno, int adet, string secenek)
        {
            double kdvtoplam = 0;
            double toplam = 0;
            double kdv = 0;
            if (secenek == "2")
            {
                toplam = manav[urunno - 1].fiyat * adet;
                kdv = toplam * manav[urunno - 1].kdv;
                kdvtoplam += kdv;
            }
            else if (secenek == "1")
            {
                toplam = gıda[urunno - 1].fiyat * adet;
                kdv = toplam * gıda[urunno - 1].kdv;
                kdvtoplam += kdv;
            }
            return kdvtoplam;

        }
        public double kdvtek(int urunno, int adet, string secenek)
        {
            double kdvtoplam = 0;
            double toplam = 0;
            double kdv = 0;
            if (secenek == "1")
            {
                toplam = tlf[urunno - 1].Fiyat * adet;
                kdv = toplam * tlf[urunno - 1].kdv;
                kdvtoplam += kdv;
            }
            else if (secenek == "2")
            {
                toplam = pc[urunno - 1].Fiyat * adet;
                kdv = toplam * pc[urunno - 1].kdv;
                kdvtoplam += kdv;
            }
            return kdvtoplam;
        }
        public void manavgorevli()
        {
            for (int i = 0; i < kisi.Count; i++)
            {
                if (kisi[i].Reyon == "Manav" && kisi[i].uzmanlık == "Müşteri Temsilcisi")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"Merhaba Ben Reyon Sorumlusu {kisi[i].Isim} Yukarıdaki Listeden Size Yardımcı Olabileceğim Konuyu Seçer misiniz? = ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
               
            }
           
        }
        public void manavsoru(string secenek)
        {
            if (secenek == "1")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Manav Reyonundaki Ürünlerimiz hergün 07:00'da yenileniyor ve bu sayede her gün sizlere taze ürün sunmaya devam ediyoruz.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (secenek == "2")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ürünlerimizi yetişme şartlarına göre ülkemizin 4 bir yanında kendi tarlalarımızda yetiştiriyor anlaşmalı şirketlerle düzenli denetleme yaparak taşımasını gerçekleştiriyor ve sizlere en güzel ürünü sunmaya çalışıyoruz.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (secenek == "3")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Manav reyonunda günlük tazeliğe önem verdiğimiz için satılamayan ancak halen taze olanları kendi vakıflarımız aracılığıyla ihtiyaç sahiplerine yönlendiriyoruz.");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public void gidagorevli()
        {
            for (int i = 0;i < kisi.Count;i++)
            {
                if (kisi[i].Reyon == "Gıda" && kisi[i].uzmanlık == "Müşteri Temsilcisi")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"Merhaba Ben Reyon Sorumlusu {kisi[i].Isim} Yukarıdaki Listeden Size Yardımcı Olabileceğim Konuyu Seçer misiniz? = ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
        public void gıdasoru(string secenek)
        {
            if (secenek == "1")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Gıda ürünlerimizde tercih ettiğimiz markaların hepsi kendi sektörlerinde lider markalardır ve gerekli kalite testlerinden başarıyla geçmişlerdir.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (secenek == "2")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("GIda ürünlerimizde problem çıkması halinde buradan ya da şikayetim var kısmından yetkili arkadaşlara bildirebilirsiniz");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public void tekgorevli()
        {
            for (int i = 0; i < kisi.Count;i++)
            {
                if (kisi[i].Reyon == "Teknoloji" && kisi[i].uzmanlık == "Müşteri Temsilcisi")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"Merhaba Ben Reyon Sorumlusu {kisi[i].Isim} Yukarıdaki Listeden Size Yardımcı Olabileceğim Konuyu Seçer misiniz? = ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
        public void teksoru(string secenek)
        {
            if ( secenek == "1")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Her ürünümüz belirli şartlara göre belirli sürede garanti sürelerine sahiptir ve bu sürede üründe kullanıcı hataları hariç herhangi bir sorun meydana gelmesi durumunda tamir olarak ücretsiz karşılanmaktadır.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (secenek == "2")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ürünlerimiz hem kendi markaları altında hemde bizim güvencemizle belirli sürelerle garanti altındadır ve isteğe bağlı olarak ek ücretle beraber bu garanti süresi ve kapsama alanı uzatılabilmektedir.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (secenek == "3")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ürünlerinizde bir problem olması durumunda Erdal Süper Market şubelerine veya gerekli markaların yetkili servislerine götürülebilir.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (secenek == "4")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("CEVAP :\nÜrünlerimizin her birinin belirli garanti süreleri vardır ancak bazı durumlarda garanti kapsamı dışına çıkabilir bunlardan bazılarını aşağıda sizin için sıralıyorum.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1)Kullanıcının kendi hatası dolayısıyla herhangi bir yerinde kırılma çatlama oluşması.\n2)Belirtilen basınç üstünde suya sokulması düşürülmesi\n3)Yetkili olmayan bir yerde tamir,parça değişimi yapılması\nGibi durumlarda cihazınız garanti dışı kalabilir ancak belirli ücret karşılığında kapsamlı garanti kampanyamız altında her türlü arızada ücretsiz hizmet alabilirsiniz.");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
      
    }
}
