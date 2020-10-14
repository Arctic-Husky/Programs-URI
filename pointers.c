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
