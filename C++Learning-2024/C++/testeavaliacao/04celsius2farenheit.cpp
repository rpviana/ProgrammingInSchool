#include <iostream>

using namespace std;

/** função de inicialização do programa **/
int main() {

    double celsius;

    cout << "\nDigite a tempertura (em celsius) que quer passar para farenheit" << endl;
    cin >> celsius;

    cout << "\n\nEssa temperatura em graus farenheit ficaria : " << (celsius * 9/5) + 32 << " graus farenheit" <<endl;

}
