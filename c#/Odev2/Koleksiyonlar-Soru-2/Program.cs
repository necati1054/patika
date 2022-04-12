Console.WriteLine("deneme");
int[] sayilar = new int[20];
int[] minsayilar = new int[3];
int[] maxsayilar = new int[3];
double maxort = 0,minort=0;

for(int i=0;i<20;i++)
{
    Console.WriteLine("{0}. sayıyı giriniz",i+1);
    sayilar[i] = int.Parse(Console.ReadLine());
}

Array.Sort(sayilar);

for(int i=0;i<3;i++)
{
    minsayilar[i] = sayilar[i];
}

foreach (int item in minsayilar)
{
    minort+=item;
}

Array.Reverse(sayilar);

for(int i=0;i<3;i++)
{
    maxsayilar[i] = sayilar[i];
}

foreach (int item in maxsayilar)
{
    maxort+=item;
}

Console.WriteLine("girilen en büyük 3 adet sayı");

foreach (int item in maxsayilar)
{
    Console.WriteLine(item);
}

Console.WriteLine("girilen en büyük 3 adedin ortalaması= " +maxort/3 );

Console.WriteLine("girilen en küçük 3 adet sayı");

foreach (int item in minsayilar)
{
    Console.WriteLine(item);
}

Console.WriteLine("girilen en küçük 3 adedin ortalaması= " +minort/3 );

Console.WriteLine("sayıların ortalama toplamları = "+ ((minort/3) + (maxort/3)));