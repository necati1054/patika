// See https://aka.ms/new-console-template for more information

Console.WriteLine("******While******");
Console.WriteLine("lütfen bir sayı giriniz");
int s = int.Parse(Console.ReadLine());
int sayac = 1;
int t=0;
while (sayac<=s)
{
    t+=sayac;
    sayac++;
}
Console.WriteLine("ort:"+t/s);

// a-z arasını yazdır.
char k = 'a';
while(k<='z')
{
    Console.Write(k);
    k++;
}


Console.WriteLine("*******foreach******");
string[] arabalar = {"bmw","ford","toyota","nissan"};

foreach (var araba in arabalar)
{
    Console.WriteLine(araba);
}
