#include <stdio.h>
#define MAX_LIMIT 20

int main()
{
    char fala[MAX_LIMIT];
    fgets(fala,MAX_LIMIT,stdin);
    printf("%s",fala);
}
