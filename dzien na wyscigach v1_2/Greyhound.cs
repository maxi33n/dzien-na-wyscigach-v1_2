using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dzien_na_wyscigach_v1_2
{
    public class Greyhound
    {
        public int StartingPosition; // Miejsce gdzie rozpoczyna się PictureBox
        public int RacetrackLength; // Jak długa jest trasa
        public PictureBox MyPictureBox = null; // mój obiekt PictureBox
        public int Location = 0; // Moje położenie na torze wyścigowym
        public Random MyRandom; // Instancja klasy Random

        public bool Run()
        {
            // Przesuń się do przodu losowo o 1,2,3,4 punkty
            //Zaktualizij położenie PictureBox na formularzu
            //Zwruć true, jeżeli wygram wyścig
            if (Location <= RacetrackLength)
            {
                MyPictureBox.Left = Location += MyRandom.Next(5);
                return false;
            }
            else
                return true;
        }

        public void TakeStartingPosition()
        {
            // Wyzeruj położenie i ustaw na linii startowej
            MyPictureBox.Left = StartingPosition;
            Location = 0;
        }
    }
}
