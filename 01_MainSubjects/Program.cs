using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdirmaKomutları
            //Console.Write("Merhaba Dünya ");
            //Console.WriteLine("selamlar :D ");

            //Console.WriteLine("***Yemek Kategorileri***");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıç");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine();
            //Console.WriteLine("***Yemek Kategorileri***");
            #endregion

            #region StringDeğişkenler


            //string
            // değiskenin_türü değişken_adi

            //string name;
            //name = "Ozan";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "ozan";
            //customerSurname = "durgut";
            //customerPhone = "+90 111 111 11 11";
            //customerEmail = "denememail@mail.com";
            //district = "kepez";
            //city = "antalya";

            //Console.WriteLine("*** Rezervasyon Kartı ***");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("Müşteri : "+ customerName + " " + customerSurname);
            //Console.WriteLine("İletişim : "+ customerPhone);
            //Console.WriteLine("Email Adresi : "+ customerEmail);
            //Console.WriteLine("Adres : "+ district+"/"+city);
            //Console.WriteLine("-----------------------------");






            #endregion

            #region IntDeğişkenler

            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonade = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("---- Hamburger : " + hamburgerPrice + " TL ");
            Console.WriteLine("---- Pizza : " + pizzaPrice + " TL ");
            Console.WriteLine("---- Kola : " + cokePrice + " TL ");
            Console.WriteLine("---- Limonata : " + lemonade + " TL ");
            Console.WriteLine("---- Kızartma : " + friesPrice + " TL ");
            Console.WriteLine("---- Su : " + waterPrice + " TL " );
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı ****");

            int hamburgercount;
            int pizzacount;
            int totalPrice = 0;

            hamburgercount = 3;
            pizzacount = 3;




            #endregion

            Console.Read();
        }
    }
}
