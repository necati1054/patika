using System;
using System.Collections.Generic;

namespace ToDo
{
    public class Operation
    {
        ToDo toDo = new ToDo();
        person person = new person();


        public void DefaultPerson()
        {
            person.Add("1","Necati","Arman");
            person.Add("2","Ayşe","Ayla");
        }

        public void DefaultCard()
        {
            toDo.Add("Ders","Todo Tamamlanacak","1","2");
            toDo.Add("Derss","Sınavlar Çalışılacak","1","3");
        }
        public void start()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");    
            Console.WriteLine("*******************************************");    
            Console.WriteLine("(1) Board Listelemek");    
            Console.WriteLine("(2) Board'a Kart Eklemek");    
            Console.WriteLine("(3) Board'dan Kart Silmek");    
            Console.WriteLine("(4) Kart Taşımak");    
            Console.WriteLine("(5) Programı Kapat");    
        }

        public void add()
        {
            Console.WriteLine("Card Ekleme Bölümü");
            Console.WriteLine("*******************************************");    
            Console.WriteLine("Kart Başlığını Giriniz");
            string baslik = Console.ReadLine();
            Console.WriteLine("Kart İçeriğini Giriniz");
            string içerik = Console.ReadLine();
            i:
            Console.WriteLine("Kart Sahibinin İD'sini Giriniz");
            string id = Console.ReadLine();
            if(!person.varmı(id))
            {
                Console.WriteLine("Yanlış bir id girdiniz");
                goto i;
            }
            b:
            Console.WriteLine("Kart Büyüklüğünü Giriniz --> XS(1),S(2),M(3),L(4),XL(5)");
            string boy = Console.ReadLine();
            if(int.Parse(boy)<1 || int.Parse(boy)>5)
            {
                Console.WriteLine("yanlış bir büyüklük girdiğiniz 1-5 arasında seçim yapınız");
                goto b;
            }
            toDo.Add(baslik,içerik,id,boy);
            Console.WriteLine("İşlem Başarıyla Gerçekleşti");
        }

        public void listele()
        {
            List<CardModel> list = toDo.Liste();
            Console.WriteLine("Kartları Görüntüleme Bölümü");
            Console.WriteLine("*******************************************");
            Console.WriteLine("TODO Line");
            Console.WriteLine("*******************************************");
            foreach (var item in list)
            {
                if(item.Durum1==0)
                {
                    Console.WriteLine("Başlık =  {0}",item.Baslik1);
                    Console.WriteLine("İçerik  = {0}",item.İçerik1);
                    Console.WriteLine("Kart Sahibi = {0}",person.Find(item.KartSahibi1));
                    Console.WriteLine("kart Büyüklüğü = {0}",(Büyüklük)int.Parse(item.Büyüklük1)); 
                    Console.WriteLine("");
                }
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("*******************************************");
            foreach (var item in list)
            {
                if(item.Durum1==1)
                {
                    Console.WriteLine("Başlık =  {0}",item.Baslik1);
                    Console.WriteLine("İçerik  = {0}",item.İçerik1);
                    Console.WriteLine("Kart Sahibi = {0}",item.KartSahibi1);
                    Console.WriteLine("kart Büyüklüğü = {0}",item.Büyüklük1);
                }
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" DONE Line");
            Console.WriteLine("*******************************************");
            foreach (var item in list)
            {
                if(item.Durum1==2)
                {
                    Console.WriteLine("Başlık =  {0}",item.Baslik1);
                    Console.WriteLine("İçerik  = {0}",item.İçerik1);
                    Console.WriteLine("Kart Sahibi = {0}",item.KartSahibi1);
                    Console.WriteLine("kart Büyüklüğü = {0}",item.Büyüklük1);
                }
            }
            
        }

        public void Delete()
        {
            List<CardModel> list = new List<CardModel>();
            Console.WriteLine("Kartları Silme Bölümü");
            Console.WriteLine("*******************************************");
            Console.WriteLine("Silmek istediğiniz kartın başlığını giriniz");
            String veri = Console.ReadLine();
            list = toDo.Find(veri,"","","");
            if(list.Count<=0)
            {
                Console.WriteLine("Aradığınız Card Bulunamadı");
                Console.WriteLine("Tekrar Denemek İçin (1)");
                Console.WriteLine("İşlemi İptal etmek için (2)");
                int sayi = int.Parse(Console.ReadLine());
                if(sayi==1)
                {
                    Delete();
                }
                if(sayi==2)
                {

                }
            }
            else
            {
                Console.WriteLine("{0} kart ı silmek istiyor musunuz Y/N",list[0].Baslik1);
                string YN = Console.ReadLine();
                if(YN == "Y")
                {
                    toDo.Delete(list[0]);
                    Console.WriteLine("İşlem Başarıyla Gerçekleşti");
                }
                else
                {
                    Console.WriteLine("İşlem Başarıyla İptal Edildi");
                }
            }
        }

        public void transfer()
        {
            List<CardModel> list = new List<CardModel>();
            Console.WriteLine("Kart Taşıma Bölümü");
            Console.WriteLine("*******************************************");
            Console.WriteLine("Taşımak istediğiniz kartın kart başlığını giriniz");
            string veri = Console.ReadLine();
            list = toDo.Find(veri,"","","");
            if(list.Count<=0)
            {
                Console.WriteLine("Aradığınız Card Bulunamadı");
                Console.WriteLine("Tekrar Denemek İçin (1)");
                Console.WriteLine("İşlemi İptal etmek için (2)");
                int sayi = int.Parse(Console.ReadLine());
                if(sayi==1)
                {
                    transfer();
                }
                if(sayi==2)
                {

                }
            }
            else
            {
                Console.WriteLine("Bulunan kart bilgiler");
                Console.WriteLine("*******************************************");
                foreach (var item in list)
                {
                    Console.WriteLine("Başlık =  {0}",item.Baslik1);
                    Console.WriteLine("İçerik  = {0}",item.İçerik1);
                    Console.WriteLine("Kart Sahibi = {0}",item.KartSahibi1);
                    Console.WriteLine("kart Büyüklüğü = {0}",item.Büyüklük1);
                    Console.WriteLine("Durum = {0}",item.Durum1);
                    Console.WriteLine("****** ****** ****** ******");
                    l:
                    Console.WriteLine("Lütfen taşımak istediğiniz Durum'u seçiniz");
                    Console.WriteLine("(0) TODO");
                    Console.WriteLine("(1) IN PROGRESS");
                    Console.WriteLine("(2) DONE");

                    int sayi = int.Parse(Console.ReadLine());
                    if(sayi<0 || sayi >2)
                    {
                        Console.WriteLine("Yanlış bir Büyüklük seçtiniz");
                        goto l;
                    }
                    item.Durum1 = sayi;
                }
            }
        }
    }
}