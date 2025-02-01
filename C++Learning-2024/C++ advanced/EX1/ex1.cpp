#include <iostream>
#include <cmath>
#include <string>
#include <stdio.h>
#include <conio.h>

using namespace std;

class Myclass {
    public:
        int myNum;
        string myString;
    private:
        int Year;

    public:
        void myMethod() {
                cout << "Hello world!!";
            }
            int mySum(int num1, int num2) { //metodo/funcao defenida dentro da class
                return num1 + num2;
            }
};

int main() {

    Myclass myObj;

    //Acessa os atributos e mete valores
    //myObj.Year = 2025;
    myObj.myNum = 15;
    myObj.myString = "Alguma cena";

    // Printa os valores do atributo
    cout << myObj.myNum << "\n";
    cout << myObj.myString;

    myObj.myMethod(); //Chama o metodo
    cout << endl << myObj.mySum(2, 3);

    return 0;
}


