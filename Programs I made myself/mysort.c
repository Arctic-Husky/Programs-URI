/* Neste código eu tento colocar em ordem crescente os numeros de um vetor de qualquer tamanho, e acredito que esse algoritimo que eu fiz tem o nome de bubble sort,
que checa se um número é maior que o próximo e, se sim, troca os dois de lugar. Isso se repete até que o vetor esteja ordenado */
#include <stdio.h>

#define TAMANHO 6
int i;

void le_vetor(int vet[]); // Le os dados inseridos pelo usuário

void ordena_crescente(int vet[]); // Ordena o vetor crescentemente

void mostra_vetor(int vet[]); // Mostra o vetor

int main()
{
    int vet[TAMANHO];
    le_vetor(vet);
    mostra_vetor(vet);
    ordena_crescente(vet);
    mostra_vetor(vet);
}

void le_vetor(int vet[])
{
    for(i=0;i<TAMANHO;i++)
    {
        printf("\n\tInsira o valor para vet[%d]: ",i);
        scanf("%d",&vet[i]);
    }
}

void ordena_crescente(int vet[])
{
    int temp,lim = TAMANHO,sentinela = 1;
    while(sentinela != 0)
    {
        sentinela = 0;
           for(i=0;i<lim;i++)
           {
            if(i!=TAMANHO-1)
                if(vet[i]>vet[i+1])
                {
                    temp = vet[i];
                    vet[i] = vet[i+1];
                    vet[i+1] = temp;
                    sentinela = 1;
                }
            }
     lim--;
    }
}

void mostra_vetor(int vet[])
{
    putchar('\n');
    putchar('\t');
    for(i=0;i<TAMANHO;i++)
    {
        printf("%3d ",vet[i]);
    }
}
