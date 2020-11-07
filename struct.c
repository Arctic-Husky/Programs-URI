#include <stdio.h>
#include <conio.h>
#include <string.h>

const int tam = 50;

void caixa_baixa(char *str);

int main()
{
    struct registro_pessoa // Como se fosse uma classe
    {
        char nome[tam];
        int idade;
        char comida[tam];
    };

struct registro_pessoa pessoa; // Como se fosse um objeto

printf("\n\n\tInsira seu nome: ");
fflush(stdin); // Limpa o buffer

fgets(pessoa.nome,tam,stdin); // Insere a string e guarda em pessoa.nome

printf("\n\n\tInsira sua idade: ");
fflush(stdin);

scanf("%d",&pessoa.idade); // Guarda o valor digitado no local de pessoa.idade

printf("\n\n\tInsira sua comida favorita: ");
fflush(stdin);

fgets(pessoa.comida,tam,stdin);

printf("\n\n\t--------- Seu registro ---------\n\n");
printf("\n\n\tSeu nome: %s\tSua idade: %d\n\tSua comida favorita: %s\n",pessoa.nome,pessoa.idade,pessoa.comida);

// Daqui pra baixo a parte mais importante do codigo
caixa_baixa(pessoa.comida);

if(strcmp(pessoa.comida,"sorvete\n")==0)
    printf("\n\n\tNota do programador: Eu tambem amo sorvete!\n\n");
if(strcmp(pessoa.comida,"ovo\n")==0)
    printf("\n\n\tNota do programador: Como voce pode gostar de ovo? E horrivel!\n\n");

}

void caixa_baixa(char *str)
{
    int i;
    for(i=0;i<strlen(str);i++)
        if(str[i]>=65 && str[i]<=90)
            str[i]+=32;
}
