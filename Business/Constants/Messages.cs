using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    //static koyduğumuz için new lemelere ihtiyaç yoktur.
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductofCountOfError = "bu kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "bu isimde zaten başka bir ürün var";
        public  static string CategoryLimitExceded="kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied = "Yetkiniz yok";
    }
}
