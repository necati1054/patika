Console.WriteLine(Gunler.pazar);
Console.WriteLine((int)Gunler.cumartesi);

int sıcaklık = 32;

if(sıcaklık<=(int)HavaDurumu.normal)
{
    Console.WriteLine("Dışarıya Çıkmak İçin Havanın Biraz Daha Isınmasını Bekleyelim. ");
}
else if(sıcaklık>=(int)HavaDurumu.Sıcak)
{
    Console.WriteLine("Dışarıya Çıkmak İçin Sıcak bir gün");
}
else if(sıcaklık>=(int)HavaDurumu.normal && sıcaklık<(int)HavaDurumu.ÇokSıcak)
{
    Console.WriteLine("Hadi Dışarıya Çıkalım");
}

enum Gunler
{
    pazartesi=1,
    salı,
    çarşamba,
    perşembe,
    cuma = 23,
    cumartesi,
    pazar   
}

enum HavaDurumu
{
    Soğuk = 5,
    normal = 20,
    Sıcak = 25,
    ÇokSıcak = 30
}