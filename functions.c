#include <stdio.h>

int comparar(int num1, int num2)
{
    if(num1>num2)
    {
        return num1;
    }
    else
        return num2;

}
int main()
{
    int n1, n2;
    printf("Digite dois numeros: ");
    scanf("%d %d", &n1,&n2);
    printf("%d",comparar(n1,n2));
}
