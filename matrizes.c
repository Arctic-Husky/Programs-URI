#include <stdio.h>

#define LIN 10  // Deixar os dois com o mesmo valor pra este codigo pfv
#define COL 10
int i, j;

void le_mat(int mat[COL][LIN]);

void preenche(int mat[][LIN]);
void preenche_mds(int mat[][LIN]); // mds = matriz diagonal secundaria

void mostra_mat(int mat[COL][LIN]);
void mostra_ds(int mat[][LIN]);
void mostra_d(int mat[][LIN]);

int main()
{
    int mat[COL][LIN];

    preenche(mat);
    mostra_mat(mat);
    mostra_d(mat);

    putchar('\n');

    preenche_mds(mat);
    mostra_mat(mat);
    mostra_ds(mat);
}

void mostra_d(int mat[][LIN])
{
    for(i=0,j=0;i<LIN;i++,j++)
    {
        printf("\n\tElemento[%d][%d]: %d",i,i,mat[i][i]);
    }
    putchar('\n');
}

void mostra_ds(int mat[][LIN])
{
    for(i=0,j=LIN;i<LIN;i++)
    {
        j--;
        printf("\n\tElemento[%d][%d]: %d",i,j,mat[i][j]);
    }
    putchar('\n');
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

void preenche_mds(int mat[][LIN])
{
    for(i=0;i<COL;i++)
        for(j=0;j<LIN;j++)
        {
            if((i+j)==(LIN-1))
                mat[i][j] = 5*j+i;
            else
                mat[i][j] = 0;
        }
}

void preenche(int mat[][LIN])
{
    for(i=0;i<COL;i++)
        for(j=0;j<LIN;j++)
        {
            if(i==j)
                mat[i][j] = 9*j-i;
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
            printf("%5d",mat[i][j]);
        }
        putchar('\n');
    }

}
