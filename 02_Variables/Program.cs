using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //double applePrice, tomatoPrice, potatoPrice, lemonPrice;
            //applePrice = 15.45;
            //tomatoPrice = 9.95;
            //potatoPrice = 10.0;
            //lemonPrice = 35.25;

            //Console.WriteLine(" Apple Price:"+applePrice+
            //    " Tomato Price:"+tomatoPrice+
            //    " Potato Price:"+potatoPrice+
            //    " Lemon Price:"+lemonPrice);
            //double appleGram, tomatoGram, potatoGram, lemonGram;
            //appleGram = 1.250;
            //tomatoGram = 1.440;
            //potatoGram = 0.740;
            //lemonGram = 0.450;

            //double appleTotalPrice = appleGram * applePrice;
            //double tomatoTotalPrice = tomatoGram *tomatoPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double lemonTotalPrice = lemonGram * lemonPrice;

            //Console.WriteLine("Elmanın Toplam Fiyatı : "+appleTotalPrice);
            //Console.WriteLine("Domatesin Toplam Fiyatı : "+tomatoTotalPrice);
            //Console.WriteLine("Patatesin Toplam Fiyatı : "+potatoTotalPrice);
            //Console.WriteLine("Limonun Toplam Fiyatı : "+lemonTotalPrice);

            #endregion

            #region Char Değişkenler

            //char symbol;
            //symbol = 'o';
            //Console.WriteLine(symbol);





            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler


            //Console.WriteLine("c# hava yolları yolcu bilgisi");
            //Console.WriteLine();

            //string passengerName, passengerSurname,passengerDistrict;

            //Console.Write("Yolcu ismi : ");
            //passengerName = Console.ReadLine();            

            //Console.Write("Yolcu soyismi : ");
            //passengerSurname = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("Yolcunun ismi : "+passengerName+" Yolcunun soy ismi : "+passengerSurname);


            #endregion

            #region Klavyeden İnteger Girişleri ve Dönüşümleri

            //int computerPrice;
            //computerPrice = 20000;
            //int computerCount;

            //Console.WriteLine("Kaç adet bilgisayar alacaksınız?");
            //computerCount = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Toplam bilgisayar tutarı :"+computerPrice*computerCount);


            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2,result;

            //Console.Write("Lütfen ilk sınavı giriniz.");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen ikinci sınavı giriniz.");
            //exam2 = double.Parse(Console.ReadLine());
            //result = (exam1 + exam2) / 2;

            //Console.WriteLine("Sınav ortalaması : "+result);

            #endregion



            Console.Read();

        }
    }
}
