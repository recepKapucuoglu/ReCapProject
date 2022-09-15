using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {

        public static string ProductAdded = "Ürün Eklendi";  //public olan degişken isimleri PascalCase yazılır.
        public static string ProductNameInvaid = "Ürün ismi gecersiz.";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "ürünler listelendi";
        public static string PriceFilter = "Hatalı girdiniz fiyat 0 dan küçük olamaz";
        public static string CarImageAddded="Resim eklendi";
        public static string CarImageNumberError="resim sayisi 5 i geçemez...";
        internal static string CarListCapacity= "Maksimum ilan sayısını aşamazsınız.";
    }
}
