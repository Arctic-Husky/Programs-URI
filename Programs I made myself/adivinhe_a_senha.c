#include <stdio.h>

#define MAX_LIMIT 20
#define SENHA "abc123"

int mesmoschars(char s1[MAX_LIMIT+1],char s2[]);
int tamanhostr(char *s);

// Nao leve a serio este programa, fiz pra testar conhecimento

int main()
{
    char in[MAX_LIMIT+1];
    int tentativas = 5,erros = 0;
    char sair;

    printf("\n\n\tTente descobrir a senha! Voce possui %d tentativas totais\n",tentativas);

    while(tentativas!=0)
    {
        printf("\n\n\tDigite a senha: ");
        scanf("%s",in);

        tentativas--;
        erros++;

        if(mesmoschars(in,SENHA)==1)
        {
            printf("\n\n\tParabens, voce descobriu a senha em %d tentativa%c!\n",erros,erros==1 ? ' ' : 's');
            printf("\n\n\tPressione <ENTER> para sair...\n\n\n");
            sair = getchar();
            if(sair=='\n')
                return 0;
        }
        else
        {
            if(tentativas==0)
                printf("\n\n\tSenha incorreta, acabaram as tentativas!\n");
            else
                printf("\n\n\tSenha incorreta, agora restam %d tentativas\n",tentativas);
        }
        if(tentativas==3)
            printf("\n\n\t\tDica: a senha possui 3 letras e 3 numeros!\n");

    }
    printf("\n\n\tTente novamente mais tarde!\n\n");
    printf("\n\n\tPressione <ENTER> para sair...\n\n\n");
            sair = getchar();
            if(sair=='\n')
                return 0;
    return 0;
}

int mesmoschars(char s1[MAX_LIMIT+1],char s2[]) // Checa se as duas strings sao EXATAMENTE iguais
{
    int i;
    for(i=0;s2[i]!='\0';i++)
    {
        if(s1[i]==s2[i])
            continue;
        else
            return 0;
    }
    if(tamanhostr(s1)==tamanhostr(s2))
        return 1;
    else
        return 0;
}

int tamanhostr(char *s) // Retorna o tamanho total da string
{
    int i=0;
    while(s[i]!='\0')
        i++;
    return i;
}
