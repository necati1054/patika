using System;
using System.Collections;
using System.Collections.Generic;

//system.collections namespace

ArrayList Liste = new ArrayList();
Liste.Add("ayşe");
Liste.Add(2);
Liste.Add(true);
Liste.Add('A');

//verilerine erişme
Console.WriteLine(Liste[1]);

foreach (var item in Liste)
{
    Console.WriteLine(item);
}

//AddRange
Console.WriteLine("****** AddRange ******");
string[] renkler = {"kırmızı","sarı","yeşil"};
List<int> sayılar = new List<int>(){1,8,3,7,9,92,5};
Liste.AddRange(renkler);
Liste.AddRange(sayılar);

foreach (var item in Liste)
{
    Console.WriteLine(item);
}

//sort
Console.WriteLine("****** Sort ******");
Liste.Sort(); //yazarken hata vermeye bilir ama çalıştığında patlıyacak -- sadece int türü olması gerek 

//binary search
Console.WriteLine("****** binary search ******");
Console.WriteLine(Liste.BinarySearch(9));

//reverse

Console.WriteLine("****** Reverse *******");

Liste.Reverse();

foreach (var item in Liste)
{
    Console.WriteLine(item);
}

//clear
Console.WriteLine("****** Clear *******");
Liste.Clear();