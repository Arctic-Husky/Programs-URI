using System;

static class MeuSort
{
  static public void BubbleSort(int[] vet)
  {
    int temp, lim = vet.Length, sentinela = 1;

    while(sentinela != 0)
    {
      sentinela = 0;
      for (int i = 0; i < lim; i++)
      {
        if(i != vet.Length - 1)
        {
          if (vet[i] > vet[i + 1])
          {
            temp = vet[i];
            vet[i] = vet[i + 1];
            vet[i + 1] = temp;
            sentinela = 1;
          }
        }
      }
      lim--;
    }
  }


  static public void ExibeVetor(int[] vet)
  {
    for (int i = 0; i < vet.Length; i++)
    {
      Console.WriteLine($"{vet[i]} - ");
    }
  }

}
