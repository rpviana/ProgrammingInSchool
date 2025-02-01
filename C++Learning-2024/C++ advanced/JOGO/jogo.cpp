#include <iostream>
#include <cmath>
#include <string>
#include <stdio.h>
#include <conio.h>
#include <cstdlib>
#include <ctype.h>
#include <ctime>

using namespace std;

const int numEuropa = 5;
const int numAfrica = 5;

void popularEuropa(string continente [numEuropa]) {
    continente[0] = "PORTUGAL";
    continente[1] = "ESPANHA";
    continente[2] = "FRANCA";
    continente[3] = "INGLATERRA";
    continente[4] = "ITALIA";
}

void popularAfrica(string continente [numAfrica]) {
    continente[0] = "MARROCOS";
    continente[1] = "CONGO";
    continente[2] = "ANGOLA";
    continente[3] = "EGITO";
    continente[4] = "CAMAROES";
}

void mostrarTabelaPais(string nomePaisSorteado, string aglomeraLetras) {
    bool temLetra;
    cout << endl << endl;
    for (int i=0; i<nomePaisSorteado.length(); i++) {
        temLetra = false;
        for (int j=0; j<aglomeraLetras.length(); j++) {
            if (nomePaisSorteado[i] == aglomeraLetras[j]) {
                temLetra = true;
            }
        }
        if (temLetra) {
            cout << nomePaisSorteado[i] << " ";
        } else {
            cout << "_" << " ";
        }
    }
    cout << endl;
}

bool verificaSeJaEscolheu(string aglomeraLetras, char LetraAverificar) {
    for (int i=0; i<aglomeraLetras.length(); i++) {
        if (aglomeraLetras[i] == LetraAverificar) {
            return true;
        }
    }
    return false;
}

bool verificaSeLetraExiste(string nomePais, char LetraAverificar) {
    for (int i=0; i<nomePais.length(); i++) {
        if (nomePais[i] == LetraAverificar) {
            return true;
        }
    }
    return false;
}

void mostrarLetrasEscolhidas(string letrasEscolhidas) {
    cout << "\n*** LETRAS ESCOLHIDAS: ";
    for (int i=0; i<letrasEscolhidas.length(); i++) {
        cout << letrasEscolhidas[i];
        cout << " ";
    }
}

bool verificaAdvinhou(string nomePaisSorteado, string aglomeraLetras) {
    bool temLetraTodas = true;
    bool temLetra;
    for (int i=0; i<nomePaisSorteado.length(); i++) {
        temLetra = false;
        for (int j=0; j<aglomeraLetras.length(); j++) {
            if (nomePaisSorteado[i] == aglomeraLetras[j]) {
                temLetra = true;
            }
        }
        if (!temLetra) temLetraTodas = temLetra;
    }
    return temLetraTodas;
}

int main() {

    int tentativas = 5;
    bool jogoterminou = false;
    string escolhaContinente;
    string europa[numEuropa];
    string africa[numAfrica];

    popularEuropa(europa);
    popularAfrica(africa);

    do{
        cout << "jogo da forca\n\n";
        cout << "Qual continente quer jogar?\n";
        cout << "1 - europa\n";
        cout << "2 - africa\n";
        cout << "0 - Sair\n";
        cout << "R: ";
        cin >> escolhaContinente;
        cout << endl << endl;
    } while (escolhaContinente != "0"
                && escolhaContinente != "1"
                && escolhaContinente != "2");

    if(escolhaContinente == "1" || escolhaContinente == "2" ) {
        int numPaisSorteado;
        string nomePaisSorteado;
        string aglomeraLetras = "";
        char letraEscolhida;


        srand(time(NULL));
        if (escolhaContinente == "1") {
            numPaisSorteado = rand() % numEuropa;
            nomePaisSorteado = europa[numPaisSorteado];
        } else if (escolhaContinente == "2") {
            numPaisSorteado = rand() % numAfrica;
            nomePaisSorteado = africa[numPaisSorteado];
        }

        do {
            cout << "\nTem " << tentativas << " tentativas para advinhar \n\n";

            mostrarTabelaPais(nomePaisSorteado, aglomeraLetras);

            mostrarLetrasEscolhidas(aglomeraLetras);

           cout << endl << "Diga uma letra para verificar: ";
           cin >> letraEscolhida;
           letraEscolhida = (char)toupper(letraEscolhida);

           bool existe, escolhida;
           escolhida = verificaSeJaEscolheu(aglomeraLetras, letraEscolhida);
           if (escolhida) {
                cout << endl << "A sua letra " << letraEscolhida;
                cout << " Ja tinha sido escolhida!!" << endl;
           } else {
               aglomeraLetras = aglomeraLetras + letraEscolhida;
               existe = verificaSeLetraExiste(nomePaisSorteado, letraEscolhida);
               if (existe) {
                    jogoterminou = verificaAdvinhou(nomePaisSorteado,aglomeraLetras);
                } else {
                    tentativas --;
                }
           }

        } while(tentativas>0 && !jogoterminou);

        if (jogoterminou && tentativas>0) {
            mostrarTabelaPais(nomePaisSorteado, aglomeraLetras);
            cout << "\n________________________________________________\n",
            cout << "PARABENS ... ACERTOU NA PALAVRA \n\n";
            cout << "O pais era: " << nomePaisSorteado << "\n________________________________________________\n";
        } else if (jogoterminou && tentativas == 0) {
            mostrarTabelaPais(nomePaisSorteado, aglomeraLetras);
            cout << "\n________________________________________________\n",
            cout << "TENTATIVAS ESGOTADAS!! \n\n";
            cout << "O pais era: " << nomePaisSorteado << "\n________________________________________________\n";
        }



     else {
    }

    return 0;
}
}

