using System;
using System.Collections.Generic; //bu şekilde getirtilir

//List<T> class
//T --> Object Türünde

List<int> SayiList = new List<int>();
SayiList.Add(23);
SayiList.Add(10);
SayiList.Add(4);
SayiList.Add(5);
SayiList.Add(92);
SayiList.Add(34);

List<string> RenkListesi = new List<string>();
RenkListesi.Add("kırmızı");
RenkListesi.Add("mavi");
RenkListesi.Add("turuncu");
RenkListesi.Add("sarı");
RenkListesi.Add("yeşil");

//Count
Console.WriteLine(RenkListesi.Count);
Console.WriteLine(SayiList.Count);

//ForEach ve ListForAech ile eleman erişim
foreach (var sayi in SayiList)
{
    Console.WriteLine(sayi);
}

foreach (var renk in RenkListesi)
{
    Console.WriteLine(renk);
}

SayiList.ForEach(sayi => Console.WriteLine(sayi));
RenkListesi.ForEach(renk => Console.WriteLine(renk));

//Listeden eleman çıkarma

SayiList.Remove(4);
RenkListesi.Remove("yeşil");

SayiList.ForEach(sayi => Console.WriteLine(sayi));
RenkListesi.ForEach(renk => Console.WriteLine(renk));

SayiList.RemoveAt(0);
RenkListesi.RemoveAt(1);

SayiList.ForEach(sayi => Console.WriteLine(sayi));
RenkListesi.ForEach(renk => Console.WriteLine(renk));

//Lİste içerisinde arama

if(SayiList.Contains(10))
{
    Console.WriteLine("10 Liste içerisinde bulundu");
}

//eleman ile index e erişme

Console.WriteLine(RenkListesi.BinarySearch("sari"));

//diziyi listeye çevirme 
string[] hayvanlar = {"kedi","köpek","kuş"};

List<string> hayvanList = new List<string>(hayvanlar); 

//listeyi nasıl temizlenir
hayvanList.Clear();

//liste içerisinde nesne tutma

List <kullanicilar> kullanicilarList = new List<kullanicilar>();
kullanicilar kullanici1 = new kullanicilar();
kullanici1.Isim = "Necati";
kullanici1.Soyisim = "ARMAN";
kullanici1.Yas = 20;

kullanicilar kullanici2 = new kullanicilar();
kullanici2.Isim = "Ayşe betül";
kullanici2.Soyisim = "Ayla";
kullanici2.Yas = 19;

kullanicilarList.Add(kullanici1);
kullanicilarList.Add(kullanici2);

List<kullanicilar> YeniList = new List<kullanicilar>();
YeniList.Add(new kullanicilar(){Isim="Deniz",Soyisim="Arda",Yas=16});

foreach (var kullanıcı in kullanicilarList)
{
    Console.WriteLine("kullanıcı adı = " + kullanıcı.Isim);
    Console.WriteLine("kullanıcı soyisim = " + kullanıcı.Soyisim);
    Console.WriteLine("kullanıcı yas = " + kullanıcı.Yas);
}

YeniList.Clear();
public class kullanicilar
{
    private string isim;
    private string soyisim;
    private int yas;

    public string Isim {get => isim; set => isim = value;}
    public string Soyisim {get => soyisim; set => soyisim = value;}
    public int Yas {get => yas; set => yas = value;}
}




