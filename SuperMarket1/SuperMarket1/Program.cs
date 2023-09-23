using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            islem i = new islem();
            int un = 0;
            int adet = 0;
            double geneltoplam = 0;
            double kdvtoplam = 0;           
            string secenek = "e";
            string ka = "";
            string sifre = "";
            int hak = 3;
           
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("ERDAL SÜPER MARKETE HOŞGELDİNİZ");
            Console.ForegroundColor = ConsoleColor.White;
            string secenek1 = "e";

            while (secenek1 == "e")
            {
                Console.WriteLine("1)Yönetici Girişi\n2)Müşteri Girişi\n3)Müşteri Hizmetleri\n4)Çıkış Yap");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Lütfen Giriş Yapmak İstediğiniz Bölümü Seçiniz = ");
                Console.ForegroundColor = ConsoleColor.White;
                secenek = Console.ReadLine();
                Console.Clear();
                if (secenek == "1")
                {

                    while (hak >= 1)
                    {
                        hak--;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("Lütfen Kullanıcı Adını Giriniz = ");
                        Console.ForegroundColor = ConsoleColor.White;
                        ka = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("Lütfen Şifrenizi Giriniz = ");
                        Console.ForegroundColor = ConsoleColor.White;
                        sifre = Console.ReadLine();
                        Console.Clear();
                        if (ka == "Admin" && sifre == "1234")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Giriş Başarılı Yönetici Paneline Hoşgeldiniz");
                            Console.ForegroundColor = ConsoleColor.White;
                            secenek = "e";

                            while (secenek == "e")
                            {
                                Console.WriteLine("1)Ürün Ekleme\n2)Fiyat Güncelleme\n3)Çalışan Listeleme");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Write("Lütfen Yapmak İstediğiniz İşlemi Seçiniz = ");
                                Console.ForegroundColor = ConsoleColor.White;
                                secenek = Console.ReadLine();
                                hak = 0;
                                Console.Clear();


                                if (secenek == "1")
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("Ürün Ekleme Ekranına Hoşgeldiniz");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    secenek = "e";
                                    while (secenek == "e")
                                    {

                                        Console.WriteLine("1)Manav Reyonu\n2)Temel Yiyecekler Reyonu\n3)Telefon Reyonu\n4)Bilgisayar Reyonu");
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.Write("Ürün Eklemek İstediğiniz Kategoriyi Seçiniz = ");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        secenek = Console.ReadLine();
                                        Console.Clear();
                                        if (secenek == "1")
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("Manav Reyonu Ürün Ekleme Ekranına Hoşgeldiniz");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            secenek = "e";
                                            while (secenek == "e")
                                            {
                                                i.listelemanav();
                                                i.uruneklemanav();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.Write("Manav Reyonunda Ürün Eklemeye Devam Etmek İstiyor musunuz? e/h = ");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                secenek = Console.ReadLine();
                                                Console.Clear();
                                                if (secenek == "e")
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                    Console.WriteLine("Manav Reyonundan Devam Ediliyor");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                }

                                            }
                                        }
                                        else if (secenek == "2")
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("Temel Gıda Reyonu Ürün Ekleme Ekranına Hoşgeldiniz");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            secenek = "e";
                                            while (secenek == "e")
                                            {
                                                i.listelegıda();
                                                i.urunekleyiyecek();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.Write("Temel Gıda Reyonunda Ürün Eklemeye Devam Etmek İstiyor musunuz? e/h = ");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                secenek = Console.ReadLine();
                                                Console.Clear();
                                                if (secenek == "e")
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                    Console.WriteLine("Temel Gıda Reyonundan Devam Ediliyor");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                }

                                            }


                                        }
                                        else if (secenek == "3")
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("Telefon Ekleme Reyonuna Hoşgeldiniz");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            secenek = "e";
                                            while (secenek == "e")
                                            {
                                                i.listeletelefon();
                                                i.urunekletlf();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.Write("Yeni Telefon Modeli Eklemek İstiyor musunuz? e/h = ");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                secenek = Console.ReadLine();
                                                Console.Clear();
                                                if (secenek == "e")
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                    Console.WriteLine("Telefon Modeli Eklemeye Devam Ediliyor");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                }
                                            }


                                        }
                                        else if (secenek == "4")
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("Bilgisayar Ekleme Reyonuna Hoşgeldiniz");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            secenek = "e";
                                            while (secenek == "e")
                                            {
                                                i.listelepc();
                                                i.uruneklepc();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.Write("Yeni Bilgisayar Modeli Eklemeye Devam Edilsin mi? e/h = ");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                secenek = Console.ReadLine();
                                                Console.Clear();
                                                if (secenek == "e")
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                    Console.WriteLine("Bilgisayar Modeli Eklemeye Devam Ediliyor");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                }
                                            }

                                        }
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.Write("Ürün Ekleme İşlemine Devam Edilsin mi? e/h = ");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        secenek = Console.ReadLine();
                                        Console.Clear();
                                        if (secenek == "e")
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("Ürün Ekleme İşlemine Devam Ediliyor...");
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }
                                    }

                                }
                                else if (secenek == "2")
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("Ürün Fiyatı Güncelleme Ekranına Hoşgeldiniz");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    secenek = "e";
                                    while (secenek == "e")
                                    {

                                        Console.WriteLine("1)Manav Reyonu\n2)Temel Gıda Reyonu\n3)Telefon Reyonu\n4)Bilgisayar Reyonu");
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.Write("Fiyat Güncellemesi Yapılacak Reyonu Seçiniz = ");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        secenek = Console.ReadLine();
                                        Console.Clear();
                                        if (secenek == "1")
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("Manav Reyonu Fiyat Güncelleme Menüsüne Hoşgeldiniz");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            secenek = "e";
                                            while (secenek == "e")
                                            {
                                                i.listelemanav();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.Write("Güncelleme Yapmak İstediğiniz Ürünün Numarasını Giriniz = ");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                un = Convert.ToInt32(Console.ReadLine());
                                                i.fiyatguncellemanav(un);
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.Write("Manav Reyonu Fiyat Güncelleme İşlemine Devam Edilsin mi? e/h = ");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                secenek = Console.ReadLine();
                                                Console.Clear();
                                                if (secenek == "e")
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                    Console.WriteLine("Manav Reyonu Fiyat Güncelleme Menüsünden Devam Ediliyor");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                }
                                            }

                                        }
                                        else if (secenek == "2")
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("Temel Gıda Reyonu Fiyat Güncelleme Menüsüne Hoşgeldiniz");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            secenek = "e";
                                            while (secenek == "e")
                                            {
                                                i.listelegıda();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.Write("Güncelleme Yapmak İstediğiniz Ürünün Numarasını Giriniz = ");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                un = Convert.ToInt32(Console.ReadLine());
                                                i.fiyatgüncellegıda(un);
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.Write("Temel Gıda Reyonu Fiyat Güncelleme İşlemine Devam Edilsin mi? e/h = ");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                secenek = Console.ReadLine();
                                                Console.Clear();
                                                if (secenek == "e")
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                    Console.WriteLine("Temel Gıda Fiyat Güncelleme Menüsünden Devam Ediliyor");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                }
                                            }
                                        }
                                        else if (secenek == "3")
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("Telefon Fiyat Güncelleme Menüsüne Hoşgeldiniz");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            secenek = "e";
                                            while (secenek == "e")
                                            {
                                                i.listeletelefon();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.Write("Güncelleme Yapmak İstediğiniz Ürünün Numarasını Giriniz = ");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                un = Convert.ToInt32(Console.ReadLine());
                                                i.fiyatgüncelletlf(un);
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.Write("Telefon Fiyat Güncelleme İşlemine Devam Etmek İstiyor musunuz? e/h = ");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                secenek = Console.ReadLine();
                                                Console.Clear();
                                                if (secenek == "e")
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                    Console.WriteLine("Telefon Fiyat Güncelleme Menüsünden Devam Ediliyor");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                }
                                            }

                                        }
                                        else if (secenek == "4")
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("Bilgisayar Fiyat Güncelleme Menüsüne Hoşgeldiniz");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            secenek = "e";
                                            while (secenek == "e")
                                            {
                                                i.listelepc();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.Write("Güncelleme Yapmak İstediğiniz Ürünün Numarasını Giriniz = ");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                un = Convert.ToInt32(Console.ReadLine());
                                                i.fiyatgüncellepc(un);
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.Write("Bilgisayar Fiyat Güncelleme İşlemine Devam Etmek İstiyor musunuz? e/h = ");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                secenek = Console.ReadLine();
                                                Console.Clear();
                                                if (secenek == "e")
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                    Console.WriteLine("Bilgisayar Fiyat Güncelleme Menüsünden Devam Ediliyor");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                }
                                            }
                                        }
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.Write("Fiyat Güncelleme Menüsünden Devam Edilsin mi? e/h = ");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        secenek = Console.ReadLine();
                                        Console.Clear();
                                        if (secenek == "e")
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("Fiyat Güncelleme Menüsünden Devam Ediliyor...");
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }
                                    }


                                }
                                else if (secenek == "3")
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("Çalışanlar Menüsüne Hoşgeldiniz");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    secenek = "e";
                                    while (secenek == "e")
                                    {
                                        Console.WriteLine("1)Tüm Çalışanları Listele\n2)Reyona Göre Listele\n3)Departmana Göre Listele");
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.Write("Lütfen Yapmak İstediğiniz İşlemi Seçiniz = ");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        secenek = Console.ReadLine();
                                        Console.Clear();
                                        if (secenek == "1")
                                        {
                                            i.listelecalisan();
                                        }
                                        else if (secenek == "2")
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("Reyona Göre Listelemeye Hoşgeldiniz");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            secenek1 = "e";
                                            while (secenek1 == "e")
                                            {
                                                Console.WriteLine("1)Manav Reyonu\n2)Temel Gıda Reyonu\n3)Telefon Reyonu\n4)Bilgisayar Reyonu");
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.Write("Lütfen Reyon Seçer misiniz? = ");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                secenek = Console.ReadLine();
                                                Console.Clear();
                                                if (secenek == "1")
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                    Console.WriteLine("Manav Reyonu Çalışanları Listelendi\n");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                }
                                                else if (secenek == "2")
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                    Console.WriteLine("Temel Gıda Reyonu Çalışanları Listelendi\n");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                }
                                                else if (secenek == "3")
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                    Console.WriteLine("Telefon Reyonu Çalışanları Listelendi\n");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                }
                                                else if (secenek == "4")
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                    Console.WriteLine("Bilgisayar Reyonu Çalışanları Listelendi\n");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                }
                                                i.reyonlistele(secenek);
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.Write("Reyona Göre Listelemeye Devam Etmek İstiyor musunuz? = ");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                secenek1 = Console.ReadLine();
                                                Console.Clear();
                                                if (secenek1 == "e")
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                    Console.WriteLine("Reyona Göre Listelemeye Devam Ediliyor\n");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                }
                                            }


                                        }
                                        else if (secenek == "3")
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("Departmana Göre Listelemeye Hoşgeldiniz");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            secenek1 = "e";
                                            while (secenek1 == "e")
                                            {
                                                Console.WriteLine("1)Müşteri Temsilcilerini Listele\n2)Reyon Görevlilerini Listele");
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.Write("Lütfen Departman Seçer misiniz = ");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                secenek = Console.ReadLine();
                                                if (secenek == "1")
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                    Console.WriteLine("Müşteri Temsilcileri Listelendi\n");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                }
                                                else if (secenek == "2")
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                    Console.WriteLine("Reyon Görevlileri Listelendi\n");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                }
                                                i.departmanlistele(secenek);
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.Write("Departmana Göre Listelemeye Devam Edilsin mi? = ");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                secenek1 = Console.ReadLine();
                                                Console.Clear();
                                                if (secenek == "e")
                                                {                                                   
                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                    Console.Write("Departmana Göre Listelemeye Devam Ediliyor");
                                                    Console.ForegroundColor = ConsoleColor.White;                                                   
                                                }
                                            }
                                        }
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.Write("Çalışanlar Menüsünden Devam Edilsin mi? e/h = ");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        secenek = Console.ReadLine();
                                        Console.Clear();
                                        if (secenek == "e")
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("Çalışanlar Menüsünden Devam Ediliyor");
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }
                                    }
                                }
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Write("Yönetici Panelinden Devam Edilsin mi? e/h = ");
                                Console.ForegroundColor = ConsoleColor.White;
                                secenek = Console.ReadLine();
                                Console.Clear();
                                if (secenek == "e")
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("Yönetici Panelinden Devam Ediliyor");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                            }

                        }
                        else if (ka != "Admin" && sifre != "1234" && hak > 0)
                        {

                            Console.WriteLine("Giriş Başarısız");
                            Console.WriteLine(hak + "Hakkınız Kaldı");
                        }
                        else
                        {
                            Console.WriteLine("Giriş Başarısız Daha Sonra Tekrar Deneyiniz");
                        }

                    }


                }
                else if (secenek == "2")
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Alışveriş Menüsüne Hoşgeldiniz");
                    Console.ForegroundColor = ConsoleColor.White;
                    secenek = "e";
                    while (secenek == "e")
                    {

                        Console.WriteLine("1)Gıda Reyonu\n2)Teknoloji Reyonu");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("Görmek İstediğiniz Reyonu Seçiniz = ");
                        Console.ForegroundColor = ConsoleColor.White;
                        secenek = Console.ReadLine();
                        Console.Clear();
                        if (secenek == "1")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Gıda Reyonuna Hoşgeldiniz");
                            Console.ForegroundColor = ConsoleColor.White;
                            secenek = "e";
                            while (secenek == "e")
                            {
                                Console.WriteLine("1)Temel Gıda Reyonu\n2)Manav Reyonu");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Write("Görmek İstediğiniz Reyonu Seçiniz = ");
                                Console.ForegroundColor = ConsoleColor.White;
                                secenek = Console.ReadLine();
                                Console.Clear();
                                if (secenek == "1")
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("Temel Gıda Reyonuna Hoşgeldiniz");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    i.listelegıda();
                                }
                                else if (secenek == "2")
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("Manav Reyonuna Hoşgeldiniz");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    i.listelemanav();
                                }
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Write("Almak İstediğiniz Ürün Numarasını Yazınız = ");
                                Console.ForegroundColor = ConsoleColor.White;
                                un = Convert.ToInt32(Console.ReadLine());
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                i.isimbirimGetir(secenek, un);
                                Console.ForegroundColor = ConsoleColor.White;
                                adet = Convert.ToInt32(Console.ReadLine());
                                geneltoplam += i.hesap(secenek, un, adet);
                                kdvtoplam += i.kdvgıda(un, adet, secenek);
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Write("Gıda Reyonundan Devam Etmek İstiyor musunuz? e/h = ");
                                Console.ForegroundColor = ConsoleColor.White;
                                secenek = Console.ReadLine();
                                Console.Clear();
                                if (secenek == "e")
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("Gıda Reyonundan Devam Ediliyor");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                            }
                        }
                        else if (secenek == "2")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Teknoloji Reyonuna Hoşgeldiniz");
                            Console.ForegroundColor = ConsoleColor.White;
                            secenek = "e";
                            while (secenek == "e")
                            {
                                Console.WriteLine("1)Telefonlar\n2)Bilgisayarlar");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Write("Lütfen Kategori Seçiniz = ");
                                Console.ForegroundColor = ConsoleColor.White;
                                secenek = Console.ReadLine();
                                Console.Clear();
                                if (secenek == "1")
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("Telefon Reyonuna Hoşgeldiniz");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    i.listeletelefon();
                                }
                                else if (secenek == "2")
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("Bilgisayar Reyonuna Hoşgeldiniz");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    i.listelepc();

                                }
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Write("Almak İstediğiniz Ürün Numarasını Yazınız = ");
                                Console.ForegroundColor = ConsoleColor.White;
                                un = Convert.ToInt32(Console.ReadLine());
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                i.isimbirimtek(secenek, un);
                                Console.ForegroundColor = ConsoleColor.White;
                                adet = Convert.ToInt32(Console.ReadLine());
                                geneltoplam += i.hesap1(secenek, un, adet);
                                kdvtoplam += i.kdvtek(un, adet, secenek);
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Write("Teknoloji Reyonundan Devam Etmek İstiyor musunuz? e/h = ");
                                Console.ForegroundColor = ConsoleColor.White;
                                secenek = Console.ReadLine();
                                Console.Clear();
                                if (secenek == "e")
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("Teknoloji Reyonundan Devam Ediliyor");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                            }

                        }
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("Alışverişe Devam Etmek İstiyor musunuz? e/h = ");
                        Console.ForegroundColor = ConsoleColor.White;
                        secenek = Console.ReadLine();
                        Console.Clear();
                        if (secenek == "e")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Alışverişe Devam Ediliyor");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("HESAP");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Toplam = " + geneltoplam + "TL");
                    Console.WriteLine("Ara Toplam = " + (geneltoplam - kdvtoplam));
                    Console.WriteLine("KDV = " + kdvtoplam);

                }
                else if (secenek == "3")
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Merhaba Erdal Süper Market Müşteri Hizmetlerine Hoşgeldiniz");
                    Console.ForegroundColor = ConsoleColor.White;
                    secenek = "e";
                    while (secenek == "e")
                    {
                        Console.WriteLine("1)Müşteri Temsilcisiyle Görüşmek İstiyorum\n2)Şikayetim Var");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("Ben Asistanınız ErdalBot Yapabileceğiniz İşlemleri Yukarıdaki Listede Görebilirsiniz Nasıl Yardımcı Olabilirim? = ");
                        Console.ForegroundColor = ConsoleColor.White;
                        secenek = Console.ReadLine();
                        Console.Clear();
                        if (secenek == "1")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Müşteri Temsilcisi Bölümüne Hoşgeldiniz");
                            Console.ForegroundColor = ConsoleColor.White;
                            secenek = "e";
                            while (secenek == "e")
                            {
                                Console.WriteLine("1)Manav Reyonu\n2)Temel Gıda Reyonu\n3)Teknoloji Reyonu");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Write("Hoşgeldiniz Hangi Reyon Hakkında Konuşmak İstediğinizi Seçer misiniz? = ");
                                Console.ForegroundColor = ConsoleColor.White;
                                secenek = Console.ReadLine();
                                Console.Clear();
                                if (secenek == "1")
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("Manav Reyonu Müşteri Hizmetleri Bölümüne Hoşgeldiniz");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    secenek = "e";
                                    while (secenek == "e")
                                    {
                                        Console.WriteLine("1)Ürün Tazeliği\n2)Ürünlerin Temin Edilişi ve Güvenliği\n3)Artan, Satılmayan Ürünler Nereye Gidiyor");
                                        i.manavgorevli();
                                        secenek1 = Console.ReadLine();
                                        i.manavsoru(secenek1);
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write("Bu Reyona Ait Yardımcı Olabileceğim Başka Bir Konu Var mı? e/h = ");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        secenek = Console.ReadLine();
                                        Console.Clear();
                                        if (secenek == "e")
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Peki Hangi Konuda Yardımcı Olabilirim");
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }
                                    }
                                }
                                else if (secenek == "2")
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("Temel Gıda Reyonu Müşteri Hizmetleri Bölümüne Hoşgeldiniz");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    secenek = "e";
                                    while (secenek == "e")
                                    {

                                        Console.WriteLine("1)Tercih Edilen Markaların Kriterleri Nelerdir?\n2)Ürünlerde Problem Çıkması Halinde Nereye Başvuru Yapmalıyız?");
                                        i.gidagorevli();
                                        secenek1 = Console.ReadLine();
                                        i.gıdasoru(secenek1);
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write("Bu Reyona Ait Yardımcı Olabileceğim Başka Bir Konu Var mı? e/h = ");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        secenek = Console.ReadLine();
                                        Console.Clear();
                                        if (secenek == "e")
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Peki Hangi Konuda Bilgi Almak İstiyorsunuz?");
                                            Console.ForegroundColor = ConsoleColor.White;

                                        }
                                    }
                                }
                                else if (secenek == "3")
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("Teknoloji Reyonu Müşteri Hizmetleri Bölümüne Hoşgeldiniz");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    secenek = "e";
                                    while (secenek == "e")
                                    {
                                        Console.WriteLine("1)Ürünlerin Garanti Durumu Hakkında Bilgi Almak İstiyorum\n2)Mağazanızdan Aldığımız Ürünlerin Güvencesini Kim Sağlıyor\n3)Ürünlerde Problem Çıkması Halinde Nereye Başvuru Yapmalıyız\n4)Ürünü Garanti Dışı Bırakan Durumlar Nelerdir");
                                        i.tekgorevli();
                                        secenek1 = Console.ReadLine();
                                        i.teksoru(secenek1);
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write("Bu Reyona Ait Yardımcı Olabileceğim Başka Bir Konu Var mı? e/h = ");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        secenek = Console.ReadLine();
                                        Console.Clear();
                                        if (secenek == "e")
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Peki Hangi Konuda Bilgi Almak İstiyorsunuz?");
                                            Console.ForegroundColor = ConsoleColor.White;

                                        }
                                    }
                                }
                                Console.Write("Müşteri Temsilcisiyle Görüşmeye Devam Etmek İstiyor musunuz? e/h = ");
                                secenek = Console.ReadLine();
                                Console.Clear();
                            }
                        }
                        else if (secenek == "2")
                        {
                            Console.WriteLine("Merhaba Hoşgeldiniz");
                            secenek1 = "e";
                            while (secenek1 == "e")
                            {
                                Console.Write("Lütfen Şikayetinizi Yazar mısınız? = ");
                                secenek = Console.ReadLine();
                                Console.WriteLine("Teşekkürler şikayetiniz ilgili bölümlere iletilmiştir");
                                Console.Write("Başka Bir Şikayetiniz Var mı? e/h = ");
                                secenek1 = Console.ReadLine();
                            }
                        }
                        Console.WriteLine("Müşteri Hizmetleri Menüsünde Devam Etmek İstiyor musunuz? e/h = ");
                        secenek = Console.ReadLine();
                        Console.Clear();
                    }
                }
                else
                {
                    Console.WriteLine("Çıkış Yapılıyor");
                    break;
                }
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Başka Bir İşlem Yapmak İstiyor musunuz? e/h = ");
                Console.ForegroundColor = ConsoleColor.White;
                secenek1 = Console.ReadLine();
                Console.Clear();
                if (secenek1 == "h")
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Bizi Tercih Ettiğiniz İçin Teşekkür Ederiz...");
                }
                else if (secenek1 == "e")
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Yapmak İstediğiniz İşlemi Seçiniz");
                    Console.ForegroundColor = ConsoleColor.White;
                }


            }
        }
    }
}
