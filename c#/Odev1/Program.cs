//1.soru n sayıda girilen sayıların çift olanlarını ekrana yazdıran kod.

Console.WriteLine("lütfen bir sayı giriniz");
int s1 = int.Parse(Console.ReadLine());
int[] dizi1 = new int[s1];
for(int i=0;i<s1;i++)
{
    Console.WriteLine("lütfen {0}. sayıyı giriniz",i+1);
    dizi1[i] = int.Parse(Console.ReadLine());
}

foreach (var i in dizi1)
{
    if(i%2==0){
        Console.WriteLine(i);
    }
}

// 2.soru kullanıcıdan 2 adet sayı alın 1. sayı kadar tekrar sayı alın ve girilen 2. sayıya eşit yada tam bölünenleri yazdırın;

Console.WriteLine("lütfen bir sayı giriniz");
int n = int.Parse(Console.ReadLine());
int[] dizi2 = new int[n];

Console.WriteLine("lütfen bir sayı giriniz");
int m = int.Parse(Console.ReadLine());

for(int i=0;i<n;i++)
{
    Console.WriteLine("lütfen {0}. sayıyı giriniz",i+1);
    dizi2[i] = int.Parse(Console.ReadLine());
}

foreach (var i in dizi2)
{
    if(m%i==0){
        Console.WriteLine(i);
    }
    else if(m==i){
        Console.WriteLine(i);
    }
}

// 3.soru n adet girilen yazıları tersten yazdıran kod

Console.WriteLine("lütfen bir sayı giriniz");
int sn = int.Parse(Console.ReadLine());
string[] dizi3 = new string[sn];

for(int i=0;i<sn;i++){
    Console.WriteLine("lütfen {0}. kelimeyi giriniz",i+1);
    dizi3[i] = Console.ReadLine();
}

for(int i=sn-1;i>=0;i--){
    Console.WriteLine(dizi3[i]);
}

// 4.soru girilen cümlenin kelime ve harf sayısını bulan kod

string[] kelimeler;
Console.WriteLine("lütfen bir cümle giriniz");
string cümle = Console.ReadLine();
kelimeler = cümle.Split(" ");

Console.WriteLine("cümlede {0} kelime var",kelimeler.Length);
Console.WriteLine("cümlede {0} tane harf var",cümle.Length);
