// IMPORTANTE :      *i++ diferente de (*i)++ , a precedencia do ++ é maior que o ponteiro *


#include <stdio.h>

int main()
{
    int *num1,num2;
    
    num2=5; // num2 recebe 5
    num1=&num2; // num1 recebe o endereco de memoria de num2
    *num1=10; // num1, que tem o endereco de memoria de num2, recebe 10
    // & -> pega o endereco
    // * -> variavel tipo ponteiro
    // se *num1 = 10, num2 = 10 tambem
    
    int *p,*q,a;
    
    *p=&num1;
    *q=&num2;
    a=(*p)*(*q); // Igual a a = num1 * num2
}

// Outro exemplo

#include <stdio.h>

void troca(int *a,int *b);

int main()
{
    int num1,num2;
    scanf("%d%d",&num1,&num2);
    troca(&num1,&num2);
    printf("\n\n%d %d",num1,num2);
    return 0;
}

void troca(int *a,int *b)
{
    *a = *a + *b;
    *b = *a - *b;
    *a = *a - *b;
}
