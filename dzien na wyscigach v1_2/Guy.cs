using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dzien_na_wyscigach_v1_2
{
    public class Guy
    {
        public string Name; // Imię faceta
        public Bet MyBet; // Instancja klasy Bet przechowująca dane o zakładzie 
        public int Cash; // Jak dużo pieniędzy posiada

        // Ostatnie dwa pola są kontrolkami GUI na formularzu
        public RadioButton MyRadioButton; // Moje pole wyboru
        public Label MyLabel; // Moja etykieta do zmiany tekstu uzytkownika 

        public void UpdateLabels()
        {
            // Ustaw moje pole tekstowe na opis zakładu, a napis obok
            // pola wyboru tak, aby pokazywał ilość pieniędzy ("Janek ma 43 zł")
            MyLabel.Text = MyBet.GetDescription();
            MyRadioButton.Text = Name + " ma " + Cash + " zł";
        }

        public void ClearBet()
        {
            // Wyczyść mój zakład, aby był równy zero
            PlaceBet(0, 1);
            UpdateLabels();
        }

        public bool PlaceBet(int BetAmount, int DogToWin)
        {
            // Ustal nowy zakład i przechowaj go w polu MyBet
            // Zwróć true, jeżeli facet ma wystarczającą ilość pieniędzy, aby obstawić
            
            if(Cash > BetAmount)
            {
                MyBet = new Bet() { Amount = BetAmount, Dog = DogToWin, Bettor = this};
              
                UpdateLabels();
                return true;
            }
            MessageBox.Show("Masz za mało pieniędzy");
            return false;
        }

        public void Collect(int Winner)
        {
            // Poproś o wypłatę zakładu i zaktualizuj etykiety 
            // kluczem jest użycie obiektu Bet
            Cash += MyBet.PayOut(Winner);
            UpdateLabels();
        }
    }
}
