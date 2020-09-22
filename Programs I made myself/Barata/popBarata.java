package Barata;

import java.util.Random;

public class popBarata 
{
    private int qtdBarata;
    private int soma;
    private int subtracao;
    private int subTotal;
    private int rodada = 1;
    Random rd = new Random();
    
    public popBarata()
    {
        qtdBarata = rd.nextInt(100);
    }
    
    public void aumentarPop()
    {
        soma = qtdBarata + rd.nextInt(100);
        qtdBarata = soma;
    }
    
    public void spray(int escolha)
    {
        int taxaReduc = (int)(qtdBarata * 0.1);
        qtdBarata = qtdBarata - taxaReduc;
        subtracao = taxaReduc;
        subTotal = subTotal + subtracao;
    }
    
    public int get_qtdBarata()
    {
        return qtdBarata;
    }
    
    public void nextRodada()
    {
        rodada++;
    }
    
    public int getRodada()
    {
        return rodada;
    }
    
    public int getSubtracao()
    {
        return subtracao;
    }
    
    public int get_subTotal()
    {
        return subTotal;
    }

}