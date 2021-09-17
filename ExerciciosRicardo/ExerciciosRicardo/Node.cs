using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosRicardo
{
    class Node
    {
        public char data;
        public Node next;

        public Node(char valor)
        {
            data = valor;
            next = null;
        }
    }
}
