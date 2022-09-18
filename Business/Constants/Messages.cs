using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
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
        public static string CarListCapacity= "Maksimum ilan sayısını aşamazsınız.";
        public static string AuthorizationDenied="yetkiniz yok";
        public static string UserRegistered="Kayıt olundu";
        public static string UserNotFound="kullanıcı bulunamadı";
        public static string PasswordError="parola hatalı";
        public static string SuccessfulLogin="giriş başarılı";
        public static string UserAlreadyExists="kullanıcı mevcut";
        public static string AccessTokenCreated="token olusturuldu";
    }
}
