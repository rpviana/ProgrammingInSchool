#include <iostream>

using namespace std;

/** fun��o de inicializa��o do programa **/
int main() {

    double farenheit;

    cout << "\nDigite a tempertura (em farenheit) que quer passar para celsius" << endl;
    cin >> farenheit;

    cout << "\n\nEssa temperatura em graus celsius ficaria : " << (5 * (farenheit-32)) / 9 << " graus celsius" <<endl;

}
