#include <iostream>

using namespace std;

/** função de inicialização do programa **/
int main() {

    int i;
    float x, base, expoente, resultado = 1;

    cout << "_____________________________________________________";
    cout << "\n\t";
    cout << "Comprimentos " ;
    cout << ", \n\n\t\t Vamos criar a exponenciacao de um numero " "?\n";

    cout << "\n\t\t digite o numero base: " << endl;
    cin >> base;

    cout << "\t\t digite o expoente: " << endl;
    cin >> expoente;

    //system("cls"); //limpar a tela
    if (expoente > 0) {
        for (i = 1; i <= expoente; i++){
            resultado = resultado * base;
        }
        cout << "\t\t"<< "O resultado = " << resultado;
    } else if (expoente == 0) {
        cout << " resultado = 1";
    } else {
        for (i = 1; i <= (expoente * -1); i++){
            resultado = resultado * base;
            cout << resultado << endl;
        }
        x = 1 / resultado;
        cout << x << endl;
        cout << "\t\t"<< "O resultado +/- = " <<  (1/resultado);
    }

    return 0;
}
