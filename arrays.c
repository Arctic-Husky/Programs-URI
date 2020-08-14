#include <stdio.h>

int main()
{
    /* O n-esimo elemento de um vetor esta sempre na posicao n-1 */
    int n[6];
    n[0] = 123;
    n[5] = n[0]*2;
    n[2] = n[0] + n[5];

    int vetor[6];
    int i;

    for(i=0;i<6;i++)
    {
        vetor[i] = i;
        printf("%d\n",vetor[i]);
    }

    /*

    Evitar escrever o codigo assim

    char vogal[5];
    vogal[0] = 'a';
    vogal[1] = 'e';
    vogal[2] = 'i';
    vogal[3] = 'o';
    vogal[4] = 'u';

    */

    char vogal[5] = {'a','e','i','o','u'}; /* Escrever assim! */
}
