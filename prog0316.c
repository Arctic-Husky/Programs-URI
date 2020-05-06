#include <stdio.h>

int main() {
    double num1, num2, resultado;
    char operador;
    printf("Escreva a expressao: ");
    scanf("%lf %c %lf", &num1, &operador, &num2);
    switch(operador){
        case '.':
        case '*':
        case 'x':
        case 'X': resultado = num1 * num2; break;
        case '+': resultado = num1 + num2; break;
        case '-': resultado = num1 - num2; break;
        case '/':
        case '_':
        case ':':
        case '\\': resultado = num1 / num2; break;
        default : printf("Operador invalido");
    }
    printf("%.2lf %c %.2lf = %.2lf", num1, operador, num2, resultado);
return 0;
}
