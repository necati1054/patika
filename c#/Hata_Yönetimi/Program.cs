using System;

try
{
Console.WriteLine("bir sayı giriniz");
int sayı = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("sayı:"+ sayı);
}
catch(Exception ex)
{
    Console.WriteLine("hata:"+ex.Message.ToString());
}
finally
{
    Console.WriteLine("İşlem tamamlandı");
}


try
{
    // int a = int.Parse(null);
    // int a = int.Parse("test");
    int a = int.Parse("-200000000000");
}
catch (ArgumentException ex)
{
    Console.WriteLine("boş değer dirdiniz!");
    Console.WriteLine(ex);
}
catch(FormatException ex){
    Console.WriteLine("veri tipi uygun değil!");
    Console.WriteLine(ex);
}
catch(OverflowException ex){
    Console.WriteLine("çok küyük yada çok büyük bir değer girdiniz!");
    Console.WriteLine(ex);
}
