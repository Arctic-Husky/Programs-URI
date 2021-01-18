using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_da_Forca_2
{
    class Vidas // Esta classe controla o numero de vidas e a mensagem de morte/derrota
    {
        public int vidasAtuais { get; private set; }
        public bool Status { get; private set; }
        public Vidas()
        {
            vidasAtuais = 6;
            derrota = "      ";
            Status = true;
        }

        public String derrota { get; private set; }



        public void perdeVida()
        {
            vidasAtuais--;
            if (vidasAtuais >= 5)
                derrota = "P     ";
            else if (vidasAtuais >= 4)
                derrota = "PE    ";
            else if (vidasAtuais >= 3)
                derrota = "PER   ";
            else if (vidasAtuais >= 2)
                derrota = "PERD  ";
            else if (vidasAtuais >= 1)
                derrota = "PERDE ";
            else if (vidasAtuais >= 0)
            {
                derrota = "PERDEU";
                Status = false;
            }
        }


    }
}
