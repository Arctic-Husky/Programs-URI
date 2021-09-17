using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosRicardo
{
    class Pilha
    {
        private Node _top;
        private int _count;
        public Pilha()
        {
            _count = 0;
            _top = null;
        }
        public void Push(char valor)
        {
            Node newNode = new Node(valor);
            newNode.next = _top;
            _top = newNode;
            _count++;
        }
        public char Pop()
        {
            if (IsEmpty())
                throw new Exception("Pilha Vazia");

            char temp = _top.data;
            _top = _top.next;

            _count--;
            return temp;
        }
        public int Count()
        {
            return _count;
        }
        public bool IsEmpty()
        {
            return _top == null;
        }
        public void Clear()
        {
            while (!IsEmpty())
            {
                Pop();
            }
        }
        public char Peek()
        {
            if (IsEmpty())
                throw new Exception("Pilha Vazia");

            return _top.data;
        }

        public static bool PopCompare(Pilha pilha1, Pilha pilha2)
        {
            while(pilha1.IsEmpty() != true)
            {
                if(pilha1.Pop() != pilha2.Pop())
                {
                    return false;
                }
            }

            return true;
        }
    }
}
