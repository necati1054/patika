// See https://aka.ms/new-console-template for more information


// girilen sayıya kadar tek sayıyı console'e yazdır
Console.WriteLine("lütfen bir sayı giriniz");
int sayac = int.Parse(Console.ReadLine());

for (int i = 1; i < sayac; i++)
{
    if(i%2==1)
    {
        Console.WriteLine(i);
    }    
}

// 1-100 arası tek ve çift sayıların toplamı

int tekToplam=0,çiftToplam=0;

for(int i=1; i<=1000;i++)
{
    if(i%2==0)
    {
        çiftToplam +=i;
    }
    else
    {
        tekToplam +=i;
    }
}

Console.WriteLine("tek toplam :"+ tekToplam);
Console.WriteLine("çift toplam :"+ çiftToplam);

//break contuine 

for (int i = 1; i < 10; i++)
{
    if(i==4)
        break;
    Console.WriteLine(i); 
}

for (int i = 1; i < 10; i++)
{
    if(i==4)
        continue;
    Console.WriteLine(i); 
}