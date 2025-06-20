#include <iostream>

using namespace std;

/** função de inicialização do programa **/
int main() {
    int i = 0;
    int x = 0;


    while (i < 4) {
        cout << "Instrucao: " << i << "\n";
        i++;
    }

    string nome = "Viana";
    i = 0;
    while (i < 5) {
        cout << nome[i] << endl;
        i = i + 1;
    }

    int base, expoente;
    cout << "Base a exponenciar: ";
    cin >> base;
    cout << "Qual o expoente: ";
    cin >> expoente;

    int resultado = 1;

    x = 1;
    if (expoente>0) {
    do {
        resultado *= base;
        x++;
    }
    while (x <= expoente);
    }
    cout <<"\n Resultado com O Do..While: " << resultado << endl;

    return 0;

}
