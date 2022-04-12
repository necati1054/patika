using System;
using System.Collections;

islem islem = new islem();
ArrayList sayi = new ArrayList();
ArrayList asal = new ArrayList();
ArrayList asaldeğil = new ArrayList();
try
{
    for(int i=0; i<20;i++)
    {
        Console.WriteLine("{0}. sayıyı gir",i+1);
        int s = int.Parse(Console.ReadLine());
        if(s>0)
        {
            sayi.Add(s);
        }
        else
        {
            Console.WriteLine("lütfen pozitif bir değer gir");
            break;  
        }
    }
}
catch(Exception)
{
    Console.WriteLine("lütfen pozitif bir sayı gir");
}

Console.WriteLine("****** ****** ****** ****** ****** ****** ****** ****** ****** ****** ******");

foreach (int s in sayi)
{
    int kontrol = 0;
    for(int i=2; i<=s; i++)
    {
        if(s%i == 0)
        {
            kontrol++;
        }
    }
        if(kontrol == 1)
        {
            asal.Add(s);
        }
        else
        {
            asaldeğil.Add(s);
        }
}

Console.WriteLine("asal sayıları büyükten küçüğe sıralanmış hali");
islem.sıralama(asal);
Console.WriteLine("asal olan sayıların adadi= " + asal.Count);
Console.WriteLine("asalolmayan sayıları büyükten küçüğe sıralanmış hali");
islem.sıralama(asaldeğil);
Console.WriteLine("asal olan sayıların adadi= " + asaldeğil.Count);


public class islem 
{
    public ArrayList sıralama(ArrayList arrL)
    {
        arrL.Sort();
        arrL.Reverse();
        foreach (int item in arrL)
        {
            Console.WriteLine(item);
        }
        return arrL;
    }

    public ArrayList ortalama(ArrayList arrL)
    {
        int toplam=0;
        foreach (int item in arrL)
        {
            toplam+=item;
        }
        decimal ort = toplam / arrL.Count;
        Console.WriteLine("ortalama= "+ort);
        return arrL;
    }
}