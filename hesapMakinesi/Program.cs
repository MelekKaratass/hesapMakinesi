﻿double sayi1, sayi2, sonuc;
char islem;


Console.WriteLine("1.sayıyı giriniz.");
sayi1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("2.sayıyı giriniz.");
sayi2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Yapmak istediğiniz işlemi seçiniz. * / + - %");
islem = Convert.ToChar(Console.ReadLine());

if (islem == '+')
    sonuc = sayi1 + sayi2;
else if (islem == '-')
    sonuc = sayi1 - sayi2;
else if (islem == '*')
    sonuc = sayi1 * sayi2;
else if (islem == '/')
    sonuc = sayi1 / sayi2;
else
    sonuc = sayi1 % sayi2;


Console.WriteLine("{0}{1}{2}={3}",sayi1,islem,sayi2,sonuc);

