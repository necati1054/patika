//DateTime
Console.WriteLine(DateTime.Now);
Console.WriteLine(DateTime.Now.Date);
Console.WriteLine(DateTime.Now.Day);
Console.WriteLine(DateTime.Now.Month);
Console.WriteLine(DateTime.Now.Year);
Console.WriteLine(DateTime.Now.Hour);
Console.WriteLine(DateTime.Now.Minute);
Console.WriteLine(DateTime.Now.Second);

Console.WriteLine(DateTime.Now.DayOfWeek);
Console.WriteLine(DateTime.Now.DayOfYear);

Console.WriteLine(DateTime.Now.ToLongDateString());
Console.WriteLine(DateTime.Now.ToShortDateString());
Console.WriteLine(DateTime.Now.ToLongTimeString());
Console.WriteLine(DateTime.Now.ToShortTimeString());

Console.WriteLine(DateTime.Now.AddDays(2));
Console.WriteLine(DateTime.Now.AddHours(3));
Console.WriteLine(DateTime.Now.AddSeconds(30));
Console.WriteLine(DateTime.Now.AddMonths(5));
Console.WriteLine(DateTime.Now.AddYears(10));
Console.WriteLine(DateTime.Now.AddMilliseconds(50));

//DateTime Format

Console.WriteLine(DateTime.Now.ToString("dd")); //20
Console.WriteLine(DateTime.Now.ToString("ddd")); //paz
Console.WriteLine(DateTime.Now.ToString("dddd")); //pazar


Console.WriteLine(DateTime.Now.ToString("MM")); //03
Console.WriteLine(DateTime.Now.ToString("MMM")); //mar
Console.WriteLine(DateTime.Now.ToString("MMMM")); //mart

Console.WriteLine(DateTime.Now.ToString("yy")); //22
Console.WriteLine(DateTime.Now.ToString("yyyy")); //2022

//Math Kütüphanesi

Console.WriteLine(Math.Abs(-25)); //mutlak değer alır
Console.WriteLine(Math.Sin(10)); //sinus karşılığı
Console.WriteLine(Math.Cos(10)); //cos karşılığı
Console.WriteLine(Math.Tan(10)); //tan karşılığı

Console.WriteLine(Math.Ceiling(10.3)); // her zaman yukarı
Console.WriteLine(Math.Round(10.3)); // hangisine daha yakınsa 22
Console.WriteLine(Math.Round(10.7)); // hangisine daha yakınsa 23
Console.WriteLine(Math.Floor(10.7)); // her zaman aşağı

Console.WriteLine(Math.Max(2,6));
Console.WriteLine(Math.Min(2,6));

Console.WriteLine(Math.Pow(3,4)); // 3^4 = 81
Console.WriteLine(Math.Sqrt(9)); // karekök alır 3

Console.WriteLine(Math.Log(9)); // 9 un e tabanındaki log karşılığı

Console.WriteLine(Math.Exp(3)); // e üzeri 3 verir

Console.WriteLine(Math.Log10(10)); // 10 un log10 tabanındaki karşılığı

