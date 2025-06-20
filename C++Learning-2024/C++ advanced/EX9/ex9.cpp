#include <iostream>
#include <string>
#include <algorithm>

using namespace std;

struct Hotel {

    string nome;
    string URL;
    string cidade;
    int estrelas;// estrelas do hotel (de 1 a 5)
    double quartos[500];

};

void inicializar (Hotel & x1) {
    x1.nome = "Pensao Sao Bento";
    x1.URL = "https://www.pensaosaobento.pt/";
    x1.cidade = "Santo Tirso";
    x1.estrelas = 2;
    for (int i=0; i<500; i++) {
        x1.quartos[i] = 0;
    }
    x1.quartos[1] = 10;
    x1.quartos[2] = 20;
    x1.quartos[3] = 30;
    x1.quartos[4] = 40;
    x1.quartos[5] = 50;

}

double mostraMediaPrecosQuartos(double dados[500]) {

    double totalSoma = 0;
    double numElementos = 0;

    for (int i=0; i<500; i++) {
        if (dados[i]>0){
            totalSoma += dados[i];
            numElementos ++;
        }
    }

    return totalSoma / numElementos;


};

int mostraMaxPrecoQuartos (double dados[500]) {
    double precoMax = 0;
    for (int i=0; i<500; ++i) {
        if (dados[i]>precoMax) {
            precoMax = dados[i];
        }
    }

    return precoMax;
}


int main () {

    Hotel PensaoSaoBento;
    double media, maxValor;

    inicializar(PensaoSaoBento);
    //cout << PensaoSaoBento.quartos[2];
    media = mostraMediaPrecosQuartos(PensaoSaoBento.quartos);
    maxValor = mostraMaxPrecoQuartos(PensaoSaoBento.quartos);
    cout << maxValor;

    return 0;
}
