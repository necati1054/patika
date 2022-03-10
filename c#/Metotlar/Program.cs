//erişim_belirteci geri_donus_tipi motatadı(parametreler)
//{
    //komut
//}
static int Topla (int deger1 , int deger2)
{
    return deger1 + deger2;
}

int s1 = 2;
int s2 = 3;

Console.WriteLine(s1+s2);

int sonuc = Topla(s1,s2);
Console.WriteLine(sonuc);

metotlar ornek = new metotlar();
ornek.ekranayazdır(sonuc.ToString());

int sonuc2 = ornek.ArttırVeTopla(ref s1,ref s2);
Console.WriteLine(sonuc2);
ornek.ekranayazdır((s1+s2).ToString());


class metotlar 
{
    public void ekranayazdır(string veri)
    {
        Console.WriteLine(veri);
    }

    public int ArttırVeTopla(ref int deger1, ref int deger2)
    {
        deger1+=1;
        deger2+=1;
        return deger1+deger2;
    }
}