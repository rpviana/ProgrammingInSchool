#include <iostream>
#include <string>
#include <stdio.h>

using namespace std;

const int numModulosProgramacao = 6;
const int numModulosMatematica = 3;



struct materias {

    string areaNome;
    string moduloNome[20];
    int moduloNota[20];

};

void mostraModulos (materias r, int numModulos){
    for (int i=0; i<numModulos; i++) {
        cout << r.moduloNome[i] << endl;
    }
}


int main() {

    materias notasProgramacao;
    materias notasMatematica;

    notasProgramacao.areaNome = "Programacao";
    notasProgramacao.moduloNome[0] = "algoritemia";
    notasProgramacao.moduloNome[1] = "Estrutura e Metodologias da Programacao";
    notasProgramacao.moduloNome[2] = "C++ Fundamentos";
    notasProgramacao.moduloNome[3] = "C++ Avancado";
    notasProgramacao.moduloNome[4] = "JAVA";
    notasProgramacao.moduloNome[5] = "JAVA WEB";
    notasProgramacao.moduloNota[0] = 18;
    notasProgramacao.moduloNota[1] = 19;


    notasMatematica.areaNome = "Matematica";
    notasMatematica.moduloNome[0] = "Geometria";
    notasMatematica.moduloNome[1] = "Funcoes Polinomiais";
    notasMatematica.moduloNome[2] = "Estatística";
    notasMatematica.moduloNota[0] = 15;
    notasMatematica.moduloNota[1] = 16;
    notasMatematica.moduloNota[2] = 3;

    cout << "MODULOS PROGRAMACAO:" << endl;
    mostraModulos(notasProgramacao, numModulosProgramacao);
    cout << "\nMODULOS MATEMATICA:" << endl;
    mostraModulos(notasMatematica, numModulosMatematica);

    return 0;

}

