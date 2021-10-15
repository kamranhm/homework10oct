using System;

namespace Homework10oct
{
    class Program
    {
        static void Main(string[] args)
        {
            Adverstisement ad1 = new Adverstisement("iPhone 13 Pro", "Alma Store", 2899);
            Adverstisement ad2 = new Adverstisement("Samsung Galaxy S21 Ultra", "Kontakt Home", 2799);
            Adverstisement[] ads = { ad1, ad2 };
            foreach (var ad in ads)
            {
                Console.WriteLine(ad.GetPrice());
            }
            ads.Sum();
            Console.WriteLine(ads.Sum());
        }

    }
    static class Extensions
    {
        public static int Sum(this Adverstisement[] arr, int totalPrice = 0)
        {

            foreach (var item in arr)
            {
                totalPrice += item.Price;
            }
            return totalPrice ;
        }

    }



}
