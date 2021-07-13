using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace tic_tac_toe
{
    public class Help
    {
        int b1;
        int b2;
        int b3;
        int b4;
        int b5;
        int b6;
        int b7;
        int b8;
        int b9;
        bool stop;
        public Help(int b1, int b2, int b3, int b4, int b5, int b6, int b7, int b8, int b9,bool stop)
        {
            this.b1 = b1;
            this.b2 = b2;
            this.b3 = b3;
            this.b4 = b4;
            this.b5 = b5;
            this.b6 = b6;
            this.b7 = b7;
            this.b8 = b8;
            this.b9 = b9;
            this.stop = stop;
        }
        public int getb1() { return b1; }
        public int getb2() { return b2; }
        public int getb3() { return b3; }
        public int getb4() { return b4; }
        public int getb5() { return b5; }
        public int getb6() { return b6; }
        public int getb7() { return b7; }
        public int getb8() { return b8; }
        public int getb9() { return b9; }
        public bool getStop() { return stop; }

        public bool StopGame()
        {
            stop = true;
            return getStop();
        }

        public string Winning()
        {
            if (( b1 == 1 && b2 == 1 && b3 == 1 ) || (b4 == 1 && b5 == 1 && b6 == 1 ) || (b7 == 1 && b8 == 1 && b9 == 1 ) || (b1 == 1 && b4 == 1 && b7 == 1 ) || (b2 == 1 && b5 == 1 && b8 == 1 ) || (b3 == 1 && b6 == 1 && b9 == 1) || (b1 == 1 && b5 == 1 && b9 == 1 ) || (b3 == 1 && b5 == 1 && b7 == 1 ))
            {
                return "The winner is O";
            }
            else if ((b1 == 2 && b2 == 2 && b3 == 2) || (b4 == 2 && b5 == 2 && b6 == 2 ) || (b7 == 2 && b8 == 2 && b9 == 2) || (b1 == 2 && b4 == 2 && b7 == 2 ) || (b2 == 2 && b5 == 2 && b8 == 2 ) || (b3 == 2 && b6 == 2 && b9 == 2) || (b1 == 2 && b5 == 2 && b9 == 2 ) || (b3 == 2 && b5 == 2 && b7 == 2))
            {
                return "The winner is X";
            }
            else
            {
                return "...";
            }
        }
    }
}
