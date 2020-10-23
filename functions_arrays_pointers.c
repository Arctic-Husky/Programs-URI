#include <stdio.h>

#define MAX 2

void sum(int v[]); // Same as int *vet

int main()
{
    int numbs[MAX];
    
    sum(numbs); // This is a pointer
}

void sum(int v[])
{

}
