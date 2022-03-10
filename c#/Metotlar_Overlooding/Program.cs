// out parametre

string sayi = "999";

bool sonuc =  int.TryParse(sayi,out int outSayi); // int outSayı dıştada tanımlana bilir

if(sonuc)
{
    Console.WriteLine("basarili");
    Console.WriteLine(outSayi);
}
else
{
    Console.WriteLine("Başarısız");

}

metotlar instance = new metotlar();
instance.topla(2,3, out int ToplamSonuc);
Console.WriteLine(ToplamSonuc);

// metot Overlooding -- aşırı yükleme

int ifade = 999;
instance.EkranaYazdır(ifade.ToString());
instance.EkranaYazdır(ifade);

// metot imzası 
// metat adı + parametre sayısı + parametre

instance.EkranaYazdır("necati","arman");


class metotlar 
{
    public void topla(int a, int b, out int toplam)
    {
        toplam = a+ b;
    }

    public void EkranaYazdır(string veri)
    {
        Console.WriteLine(veri);
    }

    public void EkranaYazdır(int veri)
    {
        Console.WriteLine(veri);
    }

    public void EkranaYazdır(string veri1,string veri2)
    {
        Console.WriteLine(veri1+veri2);
    }
}
