Dikdortgen dikdortgen = new Dikdortgen();
dikdortgen.Kisakenar=3;
dikdortgen.Uzunkenar=4;
Console.WriteLine("Class Alan Hesabı = {0}",dikdortgen.AlanHesapla());

Dikdörtgen_Struct dikdörtgen_Struct = new Dikdörtgen_Struct(3,4); //struct da new ile oluşturmaya gerek yok.
Console.WriteLine("Class/struct Alan Hesabı = {0}",dikdörtgen_Struct.AlanHesapla());


class Dikdortgen
{
    public int Kisakenar;
    public int Uzunkenar;


    public Dikdortgen(){
        Kisakenar = 3;
        Uzunkenar = 4;
    }
    public long AlanHesapla()
    {
        return this.Kisakenar * this.Uzunkenar;

    }
    
}

struct Dikdörtgen_Struct
{
    public int Kisakenar;
    public int Uzunkenar;

    public Dikdörtgen_Struct(int uzunkenar, int kisakenar)
    {
        Uzunkenar = uzunkenar;
        Kisakenar = kisakenar;
    }

    public long AlanHesapla()
    {
        return this.Kisakenar * this.Uzunkenar;

    }
    
}