using Business.Concrete;
using Entities.Concrete;

Person person1 = new Person();

person1.NationalIdentity = 10597361484;
person1.FirstName = "OĞUZHAN";
person1.LastName = "KÜREKSİZ";
person1.DateOfBirthYear = 2000;

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);


/*
 * Degiskenler();

SelamVer("Oğuzhan");
SelamVer("Burkay");
SelamVer();

int sonuc = Topla(5, 25);
Console.WriteLine(sonuc);

Diziler / Arrays

string[] ogrenciler = new string[3];
ogrenciler[0] = "Oğuzhan";
ogrenciler[1] = "Burkay";
ogrenciler[2] = "Alican";
ogrenciler[3] = "Yusuf";

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}


List<string> yeniSehirler = new List<string> { "Adana", "Bursa","İzmir" };
yeniSehirler.Add("Muğla");
foreach (var item in yeniSehirler)
{
    Console.WriteLine(item);
}


Console.ReadLine();
static void SelamVer(string isim="isimsiz")//default parametre
{
    Console.WriteLine("Merhaba " + isim);
}
static int Topla(int sayi1, int sayi2)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam : " + sonuc);
    return sonuc;
}
*/