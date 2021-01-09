using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treino
{
    class Comprador
    {
        int numero;
        String nome;
        double saldo;
        String compraSucesso = "Compra efetuada com sucesso.", faltaDinheiro = "Dinheiro insuficiente";
        int totalJogos = 0;
        int[] jogosComprados = new int[100];

        private bool procuraJogo(int numero)
        {
            bool encontrou = false;

            for (int i = 0; i < totalJogos; i++)
            {
                if (numero == jogosComprados[i])
                    encontrou = true;
            }

            return encontrou;
        }

        public String trocar(Jogo gamePossui,Jogo gameAlvo)
        {
            if (!(procuraJogo(gamePossui.getNumero())))
                return "Comprador não possui tal jogo para trocar.";

            for (int i = 0; i < totalJogos; i++)
            {
                if (gamePossui.getNumero() == jogosComprados[i])
                    jogosComprados[i] = gameAlvo.getNumero();
            }

            return "Jogo trocado com sucesso";
        }

        public String reembolsar(Jogo game)
        {
            double valorRecebido = game.getValor();

            if (procuraJogo(game.getNumero()) == false)
                return "Comprador não possui tal jogo.";

            for (int i = 0; i < totalJogos; i++)
            {
                if (game.getNumero() == jogosComprados[i])
                    jogosComprados[i] = 0;
            }

            saldo += valorRecebido;

            return "Dinheiro e jogo reembolsados com sucesso.";
        }
        public String comprar(Jogo game)
        {
            double valorGasto = game.getValor();

            if (valorGasto > saldo)
                return faltaDinheiro;
            else
            {
                saldo -= valorGasto;
                ++totalJogos;
                jogosComprados[totalJogos-1] = game.getNumero();
                return compraSucesso;
            }

            //jogosComprados += game.getNumero();
        }

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

        public void setSaldo(double saldo)
        {
            this.saldo = saldo;
        }

        public double getSaldo()
        {
            return saldo;
        }
    }
}
