#include <stdio.h>

#define LIN 3
#define COL 3
int i, j;

void le_mat(int mat[COL][LIN]);

void preenche(int mat[][LIN]);

void mostra_mat(int mat[COL][LIN]);

int main()
{
    int mat[COL][LIN];

    preenche(mat);

    mostra_mat(mat);
}

void le_mat(int mat[COL][LIN])
{
    for(i=0;i<COL;i++)
        for(j=0;j<LIN;j++)
        {
            printf("\n\n\tPosicao [%d][%d]: ",i,j);
            scanf("%d",&mat[i][j]);
        }
}

void preenche(int mat[][LIN])
{
    for(i=0;i<COL;i++)
        for(j=0;j<LIN;j++)
        {
            if(i==j)
                mat[i][j] = 1;
            else
                mat[i][j] = 0;
        }
}

void mostra_mat(int mat[COL][LIN])
{
    for(i=0;i<COL;i++)
    {
        for(j=0;j<LIN;j++)
        {
            printf("%3d",mat[i][j]);
        }
        putchar('\n');
    }

}
