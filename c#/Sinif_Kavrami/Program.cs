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

Çalışan çalışan1 = new Çalışan();
çalışan1.ad = "Ayşe";
çalışan1.soyad = "ayla";
çalışan1.no = 25874136;
çalışan1.departman = "Başkan Yardımcısı";
çalışan1.ÇalışanBilgileri();

Console.WriteLine("********** ********** **********");

Çalışan çalışan2 = new Çalışan();
çalışan2.ad = "Necati";
çalışan2.soyad = "Arman";
çalışan2.no = 56321475;
çalışan2.departman = "Başkan";
çalışan2.ÇalışanBilgileri();    

class Çalışan
{

    public string ad;
    public string soyad;
    public int no;
    public string departman;

    public void ÇalışanBilgileri()
    {
        Console.WriteLine("Çalışan Adı= {0}",ad);
        Console.WriteLine("Çalışan Soyadı= {0}",soyad);
        Console.WriteLine("Çalışan Numarası= {0}",no);
        Console.WriteLine("Çalışan Departmanı= {0}",departman); 

    }
}