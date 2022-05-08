using System;
using System.Collections.Generic;

namespace PhoneBook
{
    class Operation
    {
        PhoneBook phoneBook = new PhoneBook();

        public void DefaultListe()
        {
            phoneBook.Add("necati","arman","5558889999");
            phoneBook.Add("ayşe","ayla","1112223333");
            phoneBook.Add("ali","veli","5554446666");
            phoneBook.Add("salih","olmaz","3334442222");
            phoneBook.Add("fatma","gül","9997778888");
        }

        public void start()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
            Console.WriteLine("(6) Programı Kapat");
        }

        public void Add()
        {
            Console.WriteLine("Kişi ekleme");
            Console.WriteLine("*******************************************");
            Console.WriteLine("Lütfen Bir İsim Giriniz = ");
            string İsim = Console.ReadLine();
            Console.WriteLine("Lütfen Bir Soyisim Giriniz = ");
            string Soyisim = Console.ReadLine();
            Console.WriteLine("Lütfen Bir TelefonNumarası Giriniz = ");
            string Telefon = Console.ReadLine();
            phoneBook.Add(İsim, Soyisim, Telefon);
            Console.WriteLine("İşlem Başarıyla Gerçekleşti");
        }

        public void List()
        {
            List<PhoneBookModel> list = phoneBook.Liste();
            Console.WriteLine("Telefon Rehberin");
            foreach (var item in list)
            {
                Console.WriteLine("İsim = {0}",item.Isim1);
                Console.WriteLine("Soyisim = {0}",item.Soyisim1);
                Console.WriteLine("TelefonNumarası = {0}",item.TelefonNo1);
                Console.WriteLine("****** ****** ****** ******");
            }
        }

        public void search()
        {
            List<PhoneBookModel> list = new List<PhoneBookModel>();
            Console.WriteLine("Kişi Arama");
            Console.WriteLine("*******************************************");
            Console.WriteLine("Lütfen arama türünü seçiniz");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            bool kontrol = true;
            while(kontrol)
            {
                string No = Console.ReadLine();
                if(No=="1")
                {
                    Console.WriteLine("Lütfen İsim veya Soyisim Giriniz");
                    string veri = Console.ReadLine();
                    list = phoneBook.Find(veri,veri,"");
                    kontrol = false;
                    continue;
                }
                if(No=="2")
                {
                    Console.WriteLine("Lütfen Telefon numarasını giriniz");
                    string veri = Console.ReadLine();
                    list = phoneBook.Find("","",veri);
                    kontrol = false;
                    continue;
                }
                else
                {
                    Console.WriteLine("Yanlış bir seçim yaptıınz 1 yada 2 giriniz");
                    continue;
                }
            }
            if(list.Count<=0)
            {
                Console.WriteLine("Kayıt Bulunamadı");
            }
            else
            {
                Console.WriteLine("Kayıt Bulundu");
                foreach (var item in list)
                {
                    Console.WriteLine("İsim= {0}",item.Isim1);
                    Console.WriteLine("Soyisim = {0}",item.Soyisim1);
                    Console.WriteLine("Telefon Numaraso = {0}",item.TelefonNo1);
                    Console.WriteLine("------ ------ ------ ------");
                }
            }
            Console.WriteLine("*******************************************");
        }

        public void Delete()
        {
            List<PhoneBookModel> list = new List<PhoneBookModel>();
            Console.WriteLine("Kişi Silme Bölümü");
            Console.WriteLine("*******************************************");
            Console.WriteLine("Silmek İstediğiniz Kişinin İsmini yada Soyismini Giriniz");
            String veri = Console.ReadLine();
            list = phoneBook.Find(veri,veri,"");
            if(list.Count<=0)
            {
                Console.WriteLine("Aradığınız Veri Bulunamadı");
                Console.WriteLine("Yeniden Denemek için: (1)");
                Console.WriteLine("İşlemi İptal ekmek için (2)");
                string sayı = Console.ReadLine();
                if(sayı=="1")
                {
                    Delete();
                }
                if(sayı=="2")
                {

                }
            }
            else
            {
                Console.WriteLine("{0} Kişiyi silmek istiyor musunuz Y/N",list[0].Isim1);
                string YN = Console.ReadLine();
                if(YN == "Y")
                {
                    phoneBook.Delete(list[0]);
                    Console.WriteLine("Kayıt Başarılı bir şekilde silindi");
                }
                else
                {
                    Console.WriteLine("İşlem Başarıyla iptal edildi");
                }
            }
        }

        public void Update()
        {
            List<PhoneBookModel> list = new List<PhoneBookModel>();
            Console.WriteLine("Kişi Güncelleme");
            Console.WriteLine("*******************************************");
            Console.WriteLine("Güncellemek İstediğiniz Kişinin İsmini yada Soyismini Giriniz");
            String veri = Console.ReadLine();
            list = phoneBook.Find(veri,veri,"");
            if(list.Count<=0)
            {
                Console.WriteLine("Aradığınız Veri Bulunamadı");
                Console.WriteLine("Yeniden Denemek için: (1)");
                Console.WriteLine("İşlemi İptal ekmek için (2)");
                string sayı = Console.ReadLine();
                if(sayı=="1")
                {
                    Update();
                }
                if(sayı=="2")
                {

                }
            }
            else
            {
                Console.WriteLine("Bilgiler");
                Console.WriteLine("İsim= {0}",list[0].Isim1);
                Console.WriteLine("Soyisim= {0}",list[0].Soyisim1);
                Console.WriteLine("Telefon Numarası={0}",list[0].TelefonNo1);
                Console.WriteLine("------ ------ ------ ------");
                Console.WriteLine("Güncelleme");
                Console.WriteLine("Lütfen Bir İsim Giriniz = ");
                string İsim = Console.ReadLine();
                Console.WriteLine("Lütfen Bir Soyisim Giriniz = ");
                string Soyisim = Console.ReadLine();
                Console.WriteLine("Lütfen Bir TelefonNumarası Giriniz = ");
                string Telefon = Console.ReadLine();
                list[0].Isim1 = İsim;
                list[0].Soyisim1 = Soyisim;
                list[0].TelefonNo1 = Telefon;
                Console.WriteLine("Kayıt Başarılı bir şekilde Güncellendi");
            }
        }
    }
}