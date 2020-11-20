#include <stdio.h>

const int LIMITE = 20; // Lembrança: 19 espaços serão usados pra string, o último será para o caractere finalizador '\0'

void nomear(char *nome);

int main()
{
    char nome[LIMITE];

    nomear(nome);

    printf("\n\n\t%s is a wonderful person!\n\n",nome);
}

void nomear(char *nome)
{
    int i;

    printf("\n\n\tInsira o nome: ");
    fgets(nome,LIMITE,stdin);

    for(i=0;nome[i]!='\0';i++)
    {

    }
    nome[i-1] = '\0'; // A funcao fgets() coloca um \n na string, esta linha substitui-o por um finalizador de string
                      // The fgets() function puts a \n in the string, this line replaces it with the character '\0'
}
