#include <stdio.h>
#include <math.h>

int main() {
    double a, b, c, delta, formula1, formula2, numero;
    scanf ("%lf %lf %lf", &a, &b, &c);
    delta = b*b -4*a*c;
    numero = 2*a;
    formula1 = (-b + sqrt(delta)) / numero;
    formula2 = (-b - sqrt(delta)) / numero;
    if (a == 0 || delta < 0){
        printf("Impossivel calcular\n");
    }else{
        printf("R1 = %.5lf\nR2 = %.5lf\n", formula1, formula2);
    }
return 0;
}
