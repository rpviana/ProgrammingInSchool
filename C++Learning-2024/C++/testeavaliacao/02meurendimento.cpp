#include <iostream>

using namespace std;

/** função de inicialização do programa **/
int main() {

    double salario, htrabalho;

    cout << "Quanto e que o senhor ganha por hora trabalhada?: " << endl;
    cin >> salario;
    cout << "Quantas horas trabalha por mes?: " << endl;
    cin >> htrabalho;

    cout << "\nO seu salario por mes sao: " << salario * htrabalho << " euros";
    cout << "\nE o seu salario por ano e: " << (salario * htrabalho) * 12 << " euros" << endl;

}
