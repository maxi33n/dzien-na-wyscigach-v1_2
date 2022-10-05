using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace dzien_na_wyscigach_v1_2
{
    public class Bet
    {
        public int Amount; // Ilość postawionych pieniędzy 
        public int Dog; // Numer psa, na którego postawiono
        public Guy Bettor; // Facet, który zawarł zakład

        public string GetDescription()
        {
            // Zwraca string, który określa, kto obstawił wyścig, jak dużo pieniędzy 
            // postawił i na którego psa (" Janek postawił 8 zł na psa numr 4").
            // Jeżeli ilość jest równa zero, zakład nie został zawarty
            // ("Janek nie zawarł zakładu")
            if (Amount == 0)
            {
               return Bettor.Name + " nie zawarł zakładu ";
            }
            else
            {
                return Bettor.Name + " stawia " + Amount + " na charta numer " + Dog;
            }
            
        }
        public int PayOut(int Winner)
        {
            //Parametrem jest zwycięzca wyścigu. Jeżeli pies wygrał, 
            // zwróć wartość podstawową. W przeciwnym razie zwróć wartość 
            // postawioną ze znakiem minus
            if(Dog == Winner)
            {
                return Amount;
            }
            else
            {
                return -Amount;
            }
        }
    }
}
