using System;

int month = DateTime.Now.Month;

switch (month)
{
    case 1 :
        Console.WriteLine("ocak ayındasınız");
        break;
    case 2 :
        Console.WriteLine("Şubat ayındasınız");
        break;
    case 3 :
        Console.WriteLine("mart  ayındasınız");
        break;
    case 4 :
        Console.WriteLine("nisan ayındasınız");
        break;
    default:
        Console.WriteLine("yanlış veri girişi");
        break;
}

switch(month)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("Kış mevsimindesiniz");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("ilk bahar mevsimindesiniz");
        break;
}