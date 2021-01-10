using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treino
{
    public class Jogo
    {
        private int numero;
        private String nome;
        private double valor;

        public int teste;
        public String testeString;

        public void setNumero(int numero)
        {
            this.numero = numero;
        }

        public int getNumero()
        {
            return numero;
        }

        public void setNome(String nome)
        {
            this.nome = nome;
        }

        public String getNome()
        {
            return nome;
        }

        public void setValor(double valor)
        {
            this.valor = valor;
        }

        public double getValor()
        {
            return valor;
        }
    }
}
