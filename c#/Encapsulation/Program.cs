Öğrenci öğrenci1 = new Öğrenci();
öğrenci1.Ismi = "Necati";
öğrenci1.Soyismi = "ARMAN";
öğrenci1.Ogrno = 21332;
öğrenci1.Sinif = 1;
öğrenci1.ÖğrenciBilgileriniGetir();

öğrenci1.SınıfDüşür();
öğrenci1.ÖğrenciBilgileriniGetir();

Öğrenci öğrenci2 = new Öğrenci("Ayşe Betlü","Ayla",21330,1);
öğrenci2.SınıfAtlat();
öğrenci2.ÖğrenciBilgileriniGetir();




class Öğrenci
{
    private string ismi;
    private string soyismi;
    private int ogrno;
    private int sinif;

    public string Ismi 
    {
        get {return ismi;}  
        set {ismi = value;} 
    }
    public string Soyismi { get => soyismi; set => soyismi = value; }
    public int Ogrno { get => ogrno; set => ogrno = value; }
    public int Sinif 
    { 
        get => sinif; 
        set
        {
            if(value<=1)
            {
                sinif = 1;
            }
            else
            {
                sinif = value;
            }
        }  
    }

    public Öğrenci(string ısmi, string soyismi, int ogrno, int sinif)
    {
        Ismi = ısmi;
        Soyismi = soyismi;
        Ogrno = ogrno;
        Sinif = sinif;
    }

    public Öğrenci(){}

    public void ÖğrenciBilgileriniGetir()
    {
        Console.WriteLine("********** Öğrenci Bilgieri **********");
        Console.WriteLine("Öğrenci Adı      = {0}",this.Ismi);
        Console.WriteLine("Öğrenci Soyismi  = {0}",this.Soyismi);
        Console.WriteLine("Öğrenci No       = {0}",this.Ogrno);
        Console.WriteLine("Öğrenci Sınıfı   = {0}",this.Sinif);
    }

    public void SınıfAtlat()
    {
        this.Sinif = this.Sinif + 1;
    }

    public void SınıfDüşür()
    {
        this.Sinif = this.Sinif - 1;
    }
}