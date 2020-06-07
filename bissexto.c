#include <stdio.h>

int main() {
    int x;
    long int ano;
    printf("Escolha o ano e UM mes entre 1 a 12 : ");
    scanf("%ld %d", &ano, &x);
        if(x == 1 || x == 2 || x == 3 || x == 4 || x == 5 || x == 6 || x == 7 || x == 8 || x == 9 || x == 10 || x == 11 || x ==12) {
            if (x == 1 || x == 3 || x == 5 || x == 7 || x == 8 || x == 10 || x == 12) {
                printf("O mes %d possui 31 dias.\n", x);
            } else if (x == 4 || x == 6 || x == 9 || x == 11) {
                printf("O mes %d possui 30 dias.\n", x);
            }
            if (((ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0) && x == 2) {
                printf("O mes %d possui 29 dias\n", x);
            } else if (x == 2) {
                printf("O mes %d possui 28 dias\n", x);
            }
        }else{
            printf("Erro, mes invalido\n");
        }
return 0;
}
