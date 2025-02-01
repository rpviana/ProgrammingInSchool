#include <iostream>
#include <cmath>
#include <string>
#include <stdio.h>

using namespace std;

    void trocaNumeros(int &num1, int &num2) {
        int aux = num1;
        num1 = num2;
        num2 = aux;
        cout << "Valor em num1: " << num1 << endl;
        cout << "Valor em num2: " << num2 << endl;
    }

    int main () {
        int x = 10, y = 200;

        cout << "Valor em x: " << x << endl;
        cout << "Valor em y: " << y << endl;
        trocaNumeros(x, y);
        cout << "Valor em x: " << x << endl;
        cout << "Valor em y: " << y << endl;

        return 0;

}


