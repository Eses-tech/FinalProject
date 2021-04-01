using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Urun eklendi.";
        public static string ProductNameInvalid = "Urun ismi gecersiz.";
        public static string MaintenanceTime = "Bakim zamani.";
        public static string ProductsListed = "Urunler listelendi.";
        public static string ProductCountOfCategoryError = "Bir kategorideki urun sayısı alarmı!";
        public static string ProductNameAlreadyExists;
        public static string CategoryLimitExceeded;
    }
}
