using System;
using System.Collections.Generic;

//keyler tekil olmalı

Dictionary<int,string> kullanıcılar = new Dictionary<int, string>();

kullanıcılar.Add(10,"Necati");
kullanıcılar.Add(11,"Ayşe");
kullanıcılar.Add(18,"deniz");
kullanıcılar.Add(20,"özcan");

//dizinin elemanlarına erişim 
Console.WriteLine("****** Elemanlara Erişim ******");
Console.WriteLine(kullanıcılar[10]);

foreach (var item in kullanıcılar)
{
    Console.WriteLine(item);
}

//count
Console.WriteLine("****** Count ******");
Console.WriteLine(kullanıcılar.Count);

//Contains
Console.WriteLine("****** Contains ******");
Console.WriteLine(kullanıcılar.ContainsKey(10));
Console.WriteLine(kullanıcılar.ContainsValue("necati arman"));

//remove
Console.WriteLine("****** Remove ******");
kullanıcılar.Remove(20);
foreach (var item in kullanıcılar)
{
    Console.WriteLine(item);
}

//Keys 
Console.WriteLine("****** Keys ******");
foreach (var item in kullanıcılar.Keys)
{
    Console.WriteLine(item);
}

//Values
Console.WriteLine("****** Values ******");
foreach (var item in kullanıcılar.Values)
{
    Console.WriteLine(item);
}