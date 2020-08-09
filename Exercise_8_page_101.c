#include <stdio.h>
#include <stdlib.h>

int main()
{
    int m,n,p;
    printf("Pick a number: ");
    scanf("%d", &n);
    for(m=1;m<=n;m++)
    {
        for(p=1;p<=m;p++)
        {
          printf("*");
        }

        putchar('\n');
    }
return 0;
}
