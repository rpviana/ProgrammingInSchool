#include <iostream>
#include <cmath>
#include <string>
#include <stdio.h>

using namespace std;

double resultado = 0;

void soma() {

    int num1, num2;

    cout <<"*** Soma de 2 numeros inteiros \n";
    cout <<"1.Num \n";
    cin >> num1;
    cout <<"2.Num \n";
    cin >> num2;

    cout << "\nSoma = " << (num1 + num2) << endl << "_________________________________________________\n" << endl;
}

void subtrair() {

    int num1, num2;

    cout <<"*** Subtracao de 2 numeros inteiros \n";
    cout <<"1.Num \n";
    cin >> num1;
    cout <<"2.Num \n";
    cin >> num2;

    cout << "\nSubtracao = " << (num1 - num2) << endl << "_________________________________________________\n" << endl;
}


void dividir() {

    int num1, num2;

    cout <<"*** Divisao de 2 numeros inteiros \n";
    cout <<"1.Num \n";
    cin >> num1;
    cout <<"2.Num \n";
    cin >> num2;

     cout << "\nDivisao = " << (double)num1 / (double)num2 << endl << "_________________________________________________\n" << endl;
}

double multiplicar(int x, int y) {
    return (double)x * (double)y;
}


int main() {

    int op, num1, num2;

    do {
        printf("Que operacao deseja efetuar ? \n");
        printf("1 - Somar \n");
        printf("2 - Subtrair \n");
        printf("3 - Multiplicar \n");
        printf("4 - Dividir \n");
        printf("0 - Fechar App \n");
        scanf("%d", &op);

        switch (op) {
            case 1:
                soma();
                break;
        }

        switch (op) {
            case 2:
                subtrair();
                break;
        }

        switch (op) {
            case 3:
                cout <<"*** Multiplicacao de 2 numeros inteiros \n";
                cout <<"1.Num \n";
                cin >> num1;
                cout <<"2.Num \n";
                cin >> num2;
                resultado = multiplicar(num1, num2);
                cout << "\nMultiplicacao = " << resultado << endl << "_________________________________________________\n" << endl;
                break;
        }

        switch (op) {
            case 4:
                dividir();
                break;
        }



    } while (op != '0');

        return 0;
}
