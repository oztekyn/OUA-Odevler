using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach
{
    internal class Program
    {

        public static int sayi2;
        static void Main(string[] args)
        {
            string[] siparisNo = { "birincisiparis", "ikincisiparis", "ucuncusiparis" };
            int[] fiyat = { 250, 300, 700};
            int toplamFiyat = 0;
            int say = 0;
            foreach (string siparis in siparisNo) 

            {
            Console.WriteLine(siparis); //3 kere dönecek çünkü 3 tane var 

            }


            foreach (var tekilFiyat in fiyat) 
            {
                toplamFiyat += tekilFiyat;
                say++;

            }

            Console.WriteLine(toplamFiyat + " " + say);

            int sayi = 5;
            string isim = "Mustafa";
            Console.WriteLine("a" == "a"); //== kullanmak string karşılaştırma yapar != ise eşit değil anlamında
            Console.WriteLine("b" == "B");
            Console.WriteLine(1 != sayi);
            Console.WriteLine(isim.Contains("Mus"));
            Console.ReadLine();

            //int sayi = 6;
            Console.WriteLine(sayi >= 6 ? 1 : 2); //conditional operation
            
            //int sayi = 5;
            if (sayi == 5)
                sayi2 = 20; 
           
            {
            
            int sayi2 = 20;
            Console.WriteLine(sayi2);

            }


            Console.WriteLine(sayi2);


        }
        
    }
}
