using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treino
{
    class Program       /* UM LEMBRETE PARA CLASSES: 
                           Private -> codigo utilizavel somente dentro da propria classe ( mais restritivo )
                           Internal -> acessível apenas pelo mesmo projeto ( este é o padrão )
                           Public -> fora do assembly / projeto, pode ser visto em todos os pontos do código ( menos restritivo )
                           Protected -> acessível apenas para a mesma classe ou classes que herdam a mesma
                           Protected Internal -> igual o internal, mas também é acessivel a classes que herdam a mesma, podendo estar fora do projeto */
    {
        static void Main(string[] args)
        {
            Jogo game = new Jogo()
            {
                teste = 0, // Utiliza-se virgula ao inves de " ; "
                testeString = "a" // Não possui " ; " no final
            };
            game.setNumero(1);
            game.setNome("Bonitopia");
            game.setValor(100.0);

            Jogo game2 = new Jogo();
            game2.setNumero(2);
            game2.setNome("GamePedia");
            game2.setValor(30.0);

            Comprador comp = new Comprador();
            EmpresaCartao masterCard = new EmpresaCartao(pais: "Brasil"); // Teste de parametros opcionais
            masterCard.correntista = comp;

            masterCard.correntista.setNumero(1);
            masterCard.correntista.setNome("Mac Robingo");
            masterCard.correntista.setSaldo(120.0);
            masterCard.correntista.Pensamento = "Strike Samba!\n\n"; // Esta linha está utilizando as as propriedades get e set ( NOTA: guardar esses nomes )

            /*comp.setNumero(1);
            comp.setNome("Mac Robingo");
            comp.setSaldo(60.0);*/

            Console.Write("\n\n\tJogo: " + game.getNome() + "\n\tValor: " + game.getValor() + " R$\n\n");

            Console.Write("\t" + masterCard.correntista.comprar(game)); // Compra um jogo, experimente retirar esta linha e deixar as outras abaixo

            Console.Write("\n\n\tSaldo atual de " + masterCard.correntista.getNome() + ": " + masterCard.correntista.getSaldo() + " R$ na empresa " + masterCard.Nome + " do " + masterCard.Pais + "\n\n");

            Console.Write("\n\n\t" + masterCard.correntista.reembolsar(game)); // Reembolsa um jogo comprado, experimente tentar reembolsar um jogo que o comprador não possui

            Console.Write("\n\n\t" + masterCard.correntista.trocar(game, game2)); // Troca um jogo comprado por outro, experimente trocar um jogo que não possui

            Console.Write("\n\n\tSaldo atual de " + masterCard.correntista.getNome() + ": " + masterCard.correntista.getSaldo() + " R$.\n\n");

            Console.Write("\n\n\tPensamento atual de " + masterCard.correntista.getNome() + ": " + masterCard.correntista.Pensamento);

            Console.ReadKey(true);
        }
    }
}
