package Barata;

import java.util.Scanner;

public class Cozinha 
{
    public static void main(String[] args) 
    {
        int escolha;
        popBarata pop = new popBarata();
        Scanner scanner = new Scanner(System.in); 
        
        while(pop.getRodada()!=10)
        {
            System.out.println("Quantidade de baratas na rodada " + pop.getRodada() + " : " + pop.get_qtdBarata() + "\n");

            System.out.println("Usar spray?\n1 = SIM\n2 = NAO");
            escolha = scanner.nextInt();
            if(escolha==1)
            {
                pop.spray(escolha);
                System.out.println("\nQuantidade de baratas eliminadas na rodada " + pop.getRodada() + " : " + pop.getSubtracao() + "\n");
            }
            pop.aumentarPop();
            pop.nextRodada();
        }
        System.out.println("Quantidade de baratas na rodada " + pop.getRodada() + " : " + pop.get_qtdBarata() + "\n");
        System.out.println("Total de baratas: " + pop.get_qtdBarata() + "\nTotal de baratas eliminadas: " + pop.get_subTotal());
    }
}