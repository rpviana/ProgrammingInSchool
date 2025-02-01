#include <iostream>
#include <cmath>
#include <string>
#include <stdio.h>

using namespace std;

    int main () {

        int numUtilizador, op = 0;
        string nomeUtilizador;


        cout << "Digite o seu numero: ";
        cin >> numUtilizador;

        cout << "Digite o seu nome: ";
        cin >> nomeUtilizador;


    cout<<"\n\t-------------------- Bem vindo " << nomeUtilizador << " ---------------------\n\t";
    cout<<"| 1 - Verificar qual o maior numero entre 4 numeros   |\n\t";
    cout<<"| 2 - Verificar qual a media de 4 numeros             |\n\t";
    cout<<"| 3 - Calcular o Fatorial de um Numero                |\n\t";
    cout<<"| 4 - Ordenar 10 numeros inteiros                     |\n\t";
    cout<<"| 0 - Sair do programa                                |\n\t";
    cout<<"-------------------------------------------------------\n\t" << endl << endl;
    cout << "Qual vai querer?: ";
    cin >> op;

        return 0;

}


