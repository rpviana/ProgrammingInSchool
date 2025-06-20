#include <iostream>

using namespace std;

/** função de inicialização do programa **/
int main() {

    int numero, calculo = 0;
    string texto = " " ;
    do {
        cout << "Qual o numero a somar / acrescentar?: \n";
        cin >> numero;
        if (numero != 0) {
        calculo = numero + calculo;

    } while (numero != 0);
        cout << calculo << endl;
        cout << "Resultado de (" << texto << ") = " << calculo << endl;


    return 0;
}
