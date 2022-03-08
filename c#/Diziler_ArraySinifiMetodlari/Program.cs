// See https://aka.ms/new-console-template for more information


int [] sayilar = {23,12,4,86,72,3,11,17};
Console.WriteLine("******SIRASIZ******");
foreach (var sayi in sayilar)
{
    Console.WriteLine(sayi);
}

//Sort
Console.WriteLine("******SIRALI******");
Array.Sort(sayilar);
foreach (var sayi in sayilar)
{
    Console.WriteLine(sayi);
}

//Clear
Console.WriteLine("******CLEAR******");
Array.Clear(sayilar,2,2);
foreach (var sayi in sayilar)
{
    Console.WriteLine(sayi);
}

//reverse
Console.WriteLine("******REVERSE******");
Array.Reverse(sayilar);
foreach (var sayi in sayilar)
{
    Console.WriteLine(sayi);
}

//indexof
Console.WriteLine("******İNDEX OF******");
Console.WriteLine(Array.IndexOf(sayilar,23));

//Resize
Console.WriteLine("******RESİZE******");
Array.Resize<int>(ref sayilar,9);
sayilar[8]=99;
foreach (var sayi in sayilar)
{
    Console.WriteLine(sayi);
}