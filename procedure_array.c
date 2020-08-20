#include <stdio.h>

// Procedure == Void Function

void  inic(int s[],int n);

int main()
{
  int v[10], x[20];

  inic(v,10);
  inic(x,20);
}

void inic(int s[],int n)
{
  int i;
  for(i=0;i<n;i++)
  s[i]=0;
}
