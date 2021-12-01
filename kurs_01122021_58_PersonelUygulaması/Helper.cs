using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurs_01122021_58_PersonelUygulaması
{
    public static class Helper
    {
        //static olarak işaretlenmiş classlar örneklenemez.
        //Helper H1 = new Helper();
        /*
        public void Test()
        {
            Static olan classlar içerisinde standart metotlar kullanılamaz.(static olmayan metotlar)
        }
        */
        //static olan classlar içerisinde static olmayan field tanımları oluşturulamaz.
        //public string Tanim { get; set;}

        /*
        public Helper()
        {
            Her nesne örneği alındığında uygulama standart yapıcı metodu çalıştırır.
        }
        */
        static Helper()
        {
            //Uygulama içerisinde istenildiği kadar çağırılsınlar sadece ilk çağırılmada çalışırlar..
            Console.WriteLine("Helper => Static class => Constructor");
        }
        public static void emailGonder(string aliciEmailAdres, string konu, string icerik)
        {
            //email gönderme işlemleri devam edecek
            Console.WriteLine("mail gönderim işlemi başarılı");
        }
    }
}
