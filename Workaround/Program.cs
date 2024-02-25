using System;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();

            Vatandas vatandas1 = new Vatandas();

            SelamVer(isim:"Engin");
            SelamVer(isim: "Hilal");
            SelamVer();


            int sonuc = Topla(3,6);

            //Diziler /Arrays

            string ogrenci1 = "Engin";
            string ogrenci2 = "Hilal";
            string ogrenci3 = "Eda";

            Console.WriteLine(ogrenci1);  //tek tek ekrana yazdırmak yerine for döngüsü kullandık
            Console.WriteLine(ogrenci2);
            Console.WriteLine(ogrenci3);


            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Hilal";
            ogrenciler[2] = "Eda";

            //Stack ve Heap yapısı. Referans tipleri tanımlamadan kullanamazsın. Heap te tanımlanır.

            //ogrenciler=new string[3]; //tekrar new leyince heap te yeni adrese tutundu. yazdırınca Büşrayı tek yazdı. 
            //ogrenciler[3] = "Büşra"; //eski adresi tutan olmayınca Garbage Collector(çöp toplayıcı) gelir bellekten atar.

            //REFERANS TİPLER: ARRAY, CLASS, INTERFACE, ABSTRACT 

            for (int i = 1; i < ogrenciler.Length; i++) //  Length : ELEMAN SAYISI DEMEK
            {
                Console.WriteLine(ogrenciler[i]);
            }

            //DEĞER TİPLERDEOLAYIN HEPSİ STACK YAPISINDA DEĞERİ ATAR BİTER OLAY, TUTUNMA OLAYLARI YOK. İNT, DOUBLE, BOOL.

            string[] sehirler1= new[] {"Ankara", "İstnabul", "İzmir"};
            string[] sehirler2 = new[] {"Bursa","Antalya","Diyarbakır"};

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            Person person1 = new Person();
            person1.FirstName = "Engin";
            person1.LastName = "Demiroğ";
            person1.DataOfBirthYear = 1985;
            person1.NationalIdentity = 123;

            Person person1 = new Person();
            person2.FirstName = "Murat";

            foreach (string sehir in sehirler1) 
            {
                Console.WriteLine(sehir);
            }

            List<string> yeniSehirler1 = new List<string> { "Ankara1", "İstanbul1", "İzmir1" };
            yeniSehirler1.Add("Adana1");
            foreach ( var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager=new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
            
             
            Console.ReadLine();
        }

        static void SelamVer(string isim="isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1=8, int sayi2=5)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : " +sonuc.ToString());
            return sonuc;
        }

        private static void Degiskenler()
        {
            string mesaj = "Selam";
            double tutar = 100000; //db den gelir
            int sayi = 100;
            bool girisYapmisMi = false;

            string ad = "Engin";
            string soyad = "Demiroğ";
            int dogumYili = 1998;
            long tcNo = 12345678910;


            Console.WriteLine("Hello Word!");

            Console.WriteLine(mesaj);

            Console.WriteLine(tutar * 1.18);
        }

        //pascal casing
        public class Vatandas
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public int DogumYili { get; set;}
            public long TcNo { get; set;}
        }


        
    }
}