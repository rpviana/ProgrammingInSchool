#include <iostream>
#include <cmath>
#include <string>
#include <stdio.h>
#include <conio.h>

using namespace std;

class Matematica {

    // atributos
    private:
        int Num1, Num2; // atributos privados

    public:
        void setNum(int x) {
            this -> Num1 = x;
        }
        int getNum(int x) {
            return this -> Num1;
        }

    //metodos
    public:
        int somar (int numX, int numY) {
            return (numX + numY);
        }
        int subtrair (int numX, int numY) {
            return (numX - numY);
        }
        int multiplicar (int numX, int numY) {
            return (numX * numY);
        }
        float dividir (int numX, int numY) {
            return ((float) numX / (float) numY);
        }
};

int main() {

    Matematica obj1;

    cout << obj1.somar(2, 5);
    cout << endl << obj1.subtrair(2, 5);
    cout << endl << obj1.multiplicar(2, 5);
    cout << endl << obj1.dividir(2, 5);

    //podemos tambem chamar o metodo diretamente da classe sem precisar de ter o objeto na classe
    // ex:
    //cout << Matematica::dividir(2, 5);

    return 0;
}


