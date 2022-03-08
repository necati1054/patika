// See https://aka.ms/new-console-template for more information

//dizi tanımlama

string[] renkler = new String[5];

string[] hayvanlar = {"kedi","köpek","kuş","maymun"};

int[] dizi;
dizi = new int[5];

//diziye değer atama ve erişim

renkler[0] = "mavi";
dizi[3] = 10;

Console.WriteLine(hayvanlar[1]);
Console.WriteLine(dizi[3]);
Console.WriteLine(renkler[0]);

//döngüler dizi kullanımı
//klavyeden girilen n tane sayının ortalamasını hesaplayın

Console.WriteLine("lütfen dizinin eleman sayısın giriniz");
int diziUzunluğu = int.Parse(Console.ReadLine());
int[] sayıDizisi = new int[diziUzunluğu];

for (int i = 0; i < diziUzunluğu; i++)
{
    Console.WriteLine("lütfen {0}. sayıyı giriniz",i+1);
    sayıDizisi[i]=int.Parse(Console.ReadLine());
}

int toplam=0;
foreach (var sayı in sayıDizisi)
{
    toplam+=sayı;
}
Console.WriteLine("ortalma:"+ toplam/sayıDizisi.Length);