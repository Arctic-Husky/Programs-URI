int main()
{
    char nome[50];
    gets(nome);                 <- gets everything I put
    printf("%s\n",nome);

}
INPUT: ZABUZA MOMOCHI
OUTPUT: ZABUZA MOMOCHI





int main()
{
    char nome[50];
    scanf("%s",nome);           <- gets only one word
    printf("%s\n",nome);

}
INPUT: ZABUZA MOMOCHI
OUTPUT: ZABUZA

HOW TO FIX THIS :

int main()
{
    char str[11];

    scanf(" %10[^\n]", str);          <- gets everything up to 10 characters, and if it finds a \n in the string, it stops printing

    printf("%s",str);
}

