string değişken = "Dersimiz CSharp, Hoşgeldiniz!";
string değişken2 = "Dersimiz CSharp";

//Length -- uzunluk
Console.WriteLine(değişken.Length);

//ToUpper -> hepsi büyük, ToLower -> hepsi küçük

Console.WriteLine(değişken.ToUpper());
Console.WriteLine(değişken.ToUpper());

//Concat --> birleştirme yapar
Console.WriteLine(string.Concat(değişken,"merhaba"));

//compare compareTo
Console.WriteLine(değişken.CompareTo(değişken2)); // 0,1,-1
Console.WriteLine(string.Compare(değişken,değişken2,true)); //true olması büyük küçük harf duyarlı demek
Console.WriteLine(string.Compare(değişken,değişken2,false));

//Contains
Console.WriteLine(değişken.Contains(değişken2)); //değişkenin içinde değişken iki var mı
Console.WriteLine(değişken.EndsWith("Hoşgeldiniz!")); //değişken Hoşgeldiniz ile bitiyor mu
Console.WriteLine(değişken.StartsWith("merhaba")); // değişken merhaba ile başlıyor mu

//İndexOf

Console.WriteLine(değişken.IndexOf("CSharp")); //içinde varsa ilk değerin index numarasını döner
Console.WriteLine(değişken.IndexOf("necati")); // yoksa 0 dööner

//İnsert
Console.WriteLine(değişken.Insert(0,"Merhaba")); //0. index ten başlar string i ekler

//LastIndexOF
Console.WriteLine(değişken.LastIndexOf("i")); //en son index i verir

//PadLeft PadRight

Console.WriteLine(değişken + değişken2.PadLeft(30));
Console.WriteLine(değişken + değişken2.PadLeft(30,'*'));

Console.WriteLine(değişken.PadRight(50) + değişken2);
Console.WriteLine(değişken.PadRight(50,'-') + değişken2);

//Remove
Console.WriteLine(değişken.Remove(10));
Console.WriteLine(değişken.Remove(5,3));
Console.WriteLine(değişken.Remove(0,1));

//Replace
Console.WriteLine(değişken.Replace("CSharp","c#"));  //CSharp ı c# olarak değiştirir
Console.WriteLine(değişken.Replace(" ","*")); // boşlukları * yapar

//Split
Console.WriteLine(değişken.Split(' ')[1]);

//Substring
Console.WriteLine(değişken.Substring(5)); // 5. index den başlar sonuna kadar getirir
Console.WriteLine(değişken.Substring(5,8)); // 5. index den başlar 8. index'e kadar getirir
