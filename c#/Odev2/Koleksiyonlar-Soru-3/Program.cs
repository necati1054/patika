string[] sesli = new string[]{"a","e","ı","i","o","ö","u","ü"};
string[] girilen = new string[8];
Console.WriteLine("girilen cümledeki sesli harflari bulma");
Console.WriteLine("lütfen bir kelime giriniz");
string kelime = Console.ReadLine();
int knt=0;
foreach (var i in sesli)
{
    if(kelime.IndexOf(i)>=0)
    {
        girilen[knt] = i;
        knt++;
    }
}

foreach (var item in girilen)
{
    Console.WriteLine(item);   
}