using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public class CreditsClass
    {

        public void installment(int kp, int tutar) 
        //Fonksiyonda kullanacağımız değerleri her zaman parantez içinde tipiyle beraber (int, double vs.) tanımlıyoruz.
        {
            double toplamtutar;
            if (kp == 1) { toplamtutar = tutar + (tutar * 0.2); Console.Write("Ödemeniz Gereken Tutar=" + toplamtutar + " TL"); }
            if (kp == 2) { toplamtutar = tutar + (tutar * 0.3); Console.Write("Ödemeniz Gereken Tutar=" + toplamtutar + " TL"); }
            if (kp == 3) { toplamtutar = tutar + (tutar * 0.4); Console.Write("Ödemeniz Gereken Tutar=" + toplamtutar + " TL"); }
            if (kp == 4) { toplamtutar = tutar + (tutar * 0.5); Console.Write("Ödemeniz Gereken Tutar=" + toplamtutar + " TL"); }
            if (kp == 5) { toplamtutar = tutar + (tutar * 0.6); Console.Write("Ödemeniz Gereken Tutar=" + toplamtutar + " TL"); }
            if (kp>5 || kp<1) { Console.Write("Mevcut Paket Bulunmamaktadır"); }  
            
        
        
        
        }


    }
}
