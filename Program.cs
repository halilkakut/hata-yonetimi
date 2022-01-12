using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            // try
            // { 
            //     Console.WriteLine("Bir Sayı giriniz:");
            //     int sayi = Convert.ToInt32(Console.ReadLine());
            //     Console.WriteLine("Sayı:"  +sayi);
            // }
            // catch (Exception ex) 
            // {
            //     Console.WriteLine("Hata: " +ex.Message.ToString());
            // }
            // finally {
            //     Console.WriteLine("İşlem Tamamandı");
            // }
            
            try
            {
                 //int a = int.Parse(null);
                //  int a = int.Parse("test");
                int a = int.Parse("-2000000000000000000");
            }
            catch (ArgumentNullException ex)
            {
               Console.WriteLine("Boş Değer Girdiniz.");
               Console.WriteLine(ex);
            }
            catch(FormatException ex){
                Console.WriteLine("Veri Tipi uygun değil");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex){
                Console.WriteLine("Çok küçük yada çok büyük bir değer girdiniz.");
                Console.WriteLine(ex);
            }finally{
                Console.WriteLine("İşlem Başarıyla tamamlandı.");
            }
        }
    }
}
