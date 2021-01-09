using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treino
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogo game = new Jogo();
            game.setNumero(1);
            game.setNome("Bonitopia");
            game.setValor(50.0);

            Jogo game2 = new Jogo();
            game2.setNumero(2);
            game2.setNome("GamePedia");
            game2.setValor(30.0);

            Comprador comp = new Comprador();
            comp.setNumero(1);
            comp.setNome("Mac Robingo");
            comp.setSaldo(60.0);

            Console.Write("\n\n\tJogo: " + game.getNome() + "\n\tValor: " + game.getValor() + " R$\n\n");

            Console.Write("\t" + comp.comprar(game)); // Compra um jogo, experimente retirar esta linha e deixar as outras abaixo

            Console.Write("\n\n\tSaldo atual de " + comp.getNome() + ": " + comp.getSaldo() + " R$.\n\n");

            Console.Write("\n\n\t" + comp.reembolsar(game)); // Reembolsa um jogo comprado, experimente tentar reembolsar um jogo que o comprador não possui

            Console.Write("\n\n\t" + comp.trocar(game, game2)); // Troca um jogo comprado por outro, experimente trocar um jogo que não possui

            Console.Write("\n\n\tSaldo atual de " + comp.getNome() + ": " + comp.getSaldo() + " R$.\n\n");

            Console.ReadKey(true);
        }
    }
}
