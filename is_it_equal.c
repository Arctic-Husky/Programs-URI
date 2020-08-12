#include <stdio.h>

int linha();

int main()
{
    int a,b;
    printf("Escolha um numero: ");
    scanf("%d", &a);
    printf("Escolha outro numero: ");
    scanf("%d", &b);
    if(comparar(a,b))
    {
        printf("%d %d sao iguais", a,b);
    }
    else
        printf("%d %d nao sao iguais", a,b);
}
int comparar(int x,int y)
{
    return(x == y);
}
