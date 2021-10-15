using System;
using System.Collections.Generic;
using System.Text;

namespace Homework10oct
{
    class Adverstisement
    {
        public string Name { get; set; }
        public string SellerName { get; set; }
        public int Price { get; set; }
        public int AdCount { get; set; }
      
        public Adverstisement(string name, string sellerName, int price)
        {
            this.Name = name;
            this.SellerName = sellerName;
            this.Price = price;
        }
        public string GetInfo()
        {
            return $"{Name} {SellerName} {Price}";
        }
        public int GetPrice()
        {
            return Price;
        }


        public static bool operator < (Adverstisement ad1, Adverstisement ad2)
        {
            return ad1.Price < ad2.Price;
        }
        public static bool operator > (Adverstisement ad1, Adverstisement ad2)
        {
            return ad1.Price > ad2.Price;
        }
        
        



    }
    enum Categories
    {
        CatIOS, CatAndroid
    }









}
