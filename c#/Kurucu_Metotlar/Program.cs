//class sınıfadi
//{
//    [Erişim Belirleyici][Veri Tipi] ÖzellikAdı;
//    [Erişim Belirleyici][Geri Dönüş Değerinin Tipi] MetotAdi([Parametreler])
//    {
//        //Metot Gövdesi
//    }
//}

// public
// private
// Internal
// Protected

//kurucu metodun adı sınıf metodunun adı ile aynı olmalıdır.
//erişim belirleyiciler public dir geri dönümü yoktur. (void bile yazılmıyor).
Console.WriteLine("********** Çalışan1 **********");
Çalışan çalışan1 = new Çalışan("ayşe","ayla",25874136,"Başkan Yardımcısı");
çalışan1.ÇalışanBilgileri();

Console.WriteLine("********** Çalışan2 **********");

Çalışan çalışan2 = new Çalışan();
çalışan2.Ad = "Necati";
çalışan2.Soyad = "Arman";
çalışan2.No = 56321475;
çalışan2.Departman = "Başkan";
çalışan2.ÇalışanBilgileri();

Console.WriteLine("********** Çalışan3 **********");
Çalışan çalışan3 = new Çalışan("Engin","Topuz");
çalışan3.ÇalışanBilgileri();

class Çalışan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public Çalışan(string ad, string soyad, int no,string departman)
    {
        this.Ad = ad;
        this.Soyad = soyad;
        this.No = no;
        this.Departman = departman;
    }
    public Çalışan(string ad, string soyad)
    {
        this.Ad = ad;
        this.Soyad = soyad;
    }

    public Çalışan()
    {

    }

    public void ÇalışanBilgileri()
    {
        Console.WriteLine("Çalışan Adı= {0}",Ad);
        Console.WriteLine("Çalışan Soyadı= {0}",Soyad);
        Console.WriteLine("Çalışan Numarası= {0}",No);
        Console.WriteLine("Çalışan Departmanı= {0}",Departman); 

    }
}