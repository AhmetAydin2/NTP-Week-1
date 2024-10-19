// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Değişken kullanımı ve Değer Okuma-Yazma İşlemleri (6 uygulama)

int ıd = 231041012;
byte x = 12;

Console.WriteLine("İsminizi giriniz:");
string name = Console.ReadLine();
Console.WriteLine(name);
Console.WriteLine("Soyisminizi giriniz:");
string surname = Console.ReadLine();
Console.WriteLine(surname);


//İki sayının farkını bulan c# kodu

Console.WriteLine("Büyük sayıyı giriniz:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Küçük sayıyı giriniz:"); 
int num2 = Convert.ToInt32(Console.ReadLine());
int substraction = 0;

substraction = (num1 - num2);
Console.WriteLine("Fark:"+substraction);



// 5 sayısının karesini bulan c# kodu

int num = 5;
int square = 0;

square = (num ^ 2);
Console.WriteLine(square);


// 10 sayısının 3`e bölümünden kalanı bulan cc# kodu

int num3 = 10;
int num4 = 3;
int remaining = 0;
int section = 0;

section = (num3 / num4);
remaining = (num3 - (num4 * section));
Console.WriteLine(remaining);


// Klavyeden girilen 4 sayının toplamını ve çarpımını bulan c# kodu

Console.WriteLine("Birinci sayıyı giriniz");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("İkinci sayıyı giriniz");
int Num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Üçüncü sayıyı giriniz");
int Num3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Dördüncü sayıyı giriniz");
int Num4 = Convert.ToInt32(Console.ReadLine());

int total = 0;  
int product =0;

total = (Num1+Num2+Num3+Num4);
product = (Num1*Num2*Num3*Num4);

Console.WriteLine("Toplam:"+total);
Console.WriteLine("Çarpım:"+product);



// Klavyeden girilen iki sayının bölümünü bulan c# kodu

Console.WriteLine("Büyük sayıyı giriniz");
int Num5 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Küçük sayıyı giriniz");
int Num6 = Convert.ToInt32(Console.ReadLine());

int division = 0;
division = (Num5 / Num6);
Console.WriteLine("Bölüm:"+division);

// Klavyeden kenarları girilen dikdörtgenler prizmasının hacmini hesaplayın

Console.WriteLine("Tabanın uzun kenarını girinzi");
int longedge= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Tabanın kısa kenarını giriniz");
int shortedge =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Yüksekliği giriniz");
int h = Convert.ToInt32(Console.ReadLine());

int capacity = 0;
capacity = ((longedge * shortedge * h) / 2);
Console.WriteLine("Dikdörtgenler prizmasının hacmi"+capacity);


Console.ReadKey();  