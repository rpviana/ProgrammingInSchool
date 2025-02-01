#include <iostream>

using namespace std;

/** função de inicialização do programa **/
int main() {

    string nome, sobrenome, nomecompleto;

    cout<<"_______________________________________________________";
    cout<<"\n Boas, escreva o seu 1. nome \n";
    cin >> nome;
    cout<<"\n Boas, escreva o seu sobrenome \n";
    cin >> sobrenome;

    nomecompleto = nome + " " + sobrenome;
    cout << "\n _______________________________________________________";
    cout << "\n\n Bom dia Caro " <<nome [0] << "." << sobrenome;
    cout << "\n Com o teu sobrenome " <<sobrenome <<", temos o " << sobrenome [0];
    cout << "\n Com o teu nome " <<nome <<", temos o " << nome [0];
    cout << "\n assim sera chamado de " <<nome [0] << sobrenome [0];
    cout << endl;


    return 0;
}
