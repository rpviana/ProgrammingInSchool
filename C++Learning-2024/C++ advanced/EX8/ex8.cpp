#include <iostream>
#include <fstream>
#include <string>

using namespace std;

const int numRegistos = 26;
int numRegistosExistente = 0;
bool leuFicheiro = false;

void readfile(char * localficheiro,
              string col1[numRegistos],
              int col2[numRegistos],
              string col3[numRegistos]) {

    char aux = ';';
    string myText;
    string txtFinal = "";
    bool comeca = false;
    int comecarVar=1, posicaoArray=0;
    string idadeAux;
    //string col1[26], col2[26], col3[26];

    ifstream MyReadFile(localficheiro);

    while (getline (MyReadFile, myText)) {
        comecarVar = 1;
        idadeAux = "";
        //col1= col2= col3="";
        if (myText == "<READ>") comeca = true;
        if (myText == "</READ>") comeca = false;

        if (comeca && myText!="<READ>") {
            col1[posicaoArray] = "";
            col3[posicaoArray] = "";
            for (int i=0; i< myText.length(); i++) {
                if (myText[i] == ';') {
                    comecarVar++;
                } else {
                    if (comecarVar == 1) {
                        col1[posicaoArray] = col1[posicaoArray] + myText[i];
                    } else if (comecarVar == 2) {
                        idadeAux = idadeAux + myText[i];
                        //col2[posicaoArray] = col2[posicaoArray] + myText[i];
                    } else if (comecarVar == 3) {
                        col3[posicaoArray] = col3[posicaoArray] + myText[i];
                    }
                }
            }
            //col2[posicaoArray] = stoi(idadeAux);
            //cout << "O " << col1[posicaoArray];
            //cout << " tem " << col2[posicaoArray] << "anos e mora em " << col3[posicaoArray] << endl;
            posicaoArray ++; // dizer que passa para a proxima posicao do array
            txtFinal = txtFinal + myText + "\n";
        }

    }
    MyReadFile.close();
    numRegistosExistente = posicaoArray;
    leuFicheiro = true;
}

void writefile(char * localficheiro, string col1[numRegistos],
               int col2[numRegistos], string col3[numRegistos]) {

    string txtTotal = "";

    ofstream MyFile(localficheiro);

    txtTotal = txtTotal + "<READ>\n";

    for (int i=0; i<numRegistosExistente; i++) {
        txtTotal += col1[i]; // nome
        txtTotal += ";";
        txtTotal += (col2[i]); // idade
        txtTotal += ";";
        txtTotal += col3[i]; // localidade
        txtTotal += "\n";
    }

    txtTotal = txtTotal + "</READ>\n";

    MyFile << txtTotal;

    MyFile.close();
}

void mostraDados(string col[numRegistos]) {
    for (int i=0; i<numRegistosExistente; i++) {
        cout << "#" << i << " - " << col[i] << "\n";
    }
}
void mostraDadosInteiros(int col[numRegistos]) {
    for (int i=0; i<numRegistosExistente; i++) {
        cout << "#" << i << " - " << col[i] << "\n";
    }
}
void popularDadosInteiros(int col[numRegistos]) {
    for (int i=0; i<numRegistos; i++) {
        col[i]=0;
    }
}
void mostraRegistos(string nomes[numRegistos],
                    int idades[numRegistos],
                    string localidades[numRegistos]) {

    for (int i=0; i<numRegistosExistente; i++) {
        cout << "#" << i << " - ";
        cout << nomes[i];
        cout << " | ";
        cout << (idades[i]) << " anos ";
        cout << " | ";
        cout << localidades[i];
        cout << "\n";
    }
}

int mostraMenuPrincipal() {
    int opx=0;
    //system("cls");
    cout << "**** LEITURA / ESCRITA DE FICHEIROS **** \n\n\n";
    cout << "1 - Ler Dados do ficheiro \n";
    if (leuFicheiro) {
        cout << "2 - Gravar Dados do ficheiro \n\n";
        cout << "3 - Mostra Nomes Lidos \n\n";
        cout << "4 - Mostra Localidades Lidas \n\n";
        cout << "5 - Mostra Idades Lidas \n\n";
        cout << "6 - Mostra Registos da BD \n\n";
        cout << "11 - Inserir Registos da BD \n\n";
        cout << "12 - Alterar Registos da BD \n\n";
        cout << "13 - Apagar Registos da BD \n\n";
    }
    cout << "0 - Sair do Programa \n\n";
    cout << "O que pretende fazer? ";
    cin >> opx;

    return opx;
}

void inserirRegisto(string nomes[numRegistos],
                    int idades[numRegistos],
                    string localidades[numRegistos]) {

    string auxNome, auxLocalidade;
    int auxIdade;

    cout << "Vai inserir um registo\n\n";
    cout << "\nDiga o nome do novo registo: ";
    cin >> auxNome;
    cout << "\nDiga a idade do novo registo: ";
    cin >> auxIdade;
    cout << "\nDiga a localidade do novo registo: ";
    cin >> auxLocalidade;
    nomes[numRegistosExistente] = auxNome;
    idades[numRegistosExistente] = auxIdade;
    localidades[numRegistosExistente] = auxLocalidade;
    numRegistosExistente ++;

}

void alterarRegisto(string nomes[numRegistos],
                    int idades[numRegistos],
                    string localidades[numRegistos]) {

}

void apagarRegisto(string nomes[numRegistos],
                    int idades[numRegistos],
                    string localidades[numRegistos]) {

    int op, auxNumRegisto;

    cout << "Vai apagar um registo\n\n";
    cout << "\nDiga o numero do registo que quer apagar: ";
    cin >> auxNumRegisto;
    if (auxNumRegisto>=0 && auxNumRegisto < numRegistosExistente) {
        cout << "Tem a certeza que quer eleminar o registo: \n";
        cout << nomes[auxNumRegisto] << ";" << idades[auxNumRegisto] << ";" << localidades[auxNumRegisto];
        cout << "\n(1-Sim | 0-Nao)";
        cout << "R: ";
        cin >> op;
        if(op == 1){

            for (int i=auxNumRegisto; i<(numRegistosExistente - 1); i++) {
                nomes[i] = nomes[i+1];
                idades[i] = idades[i+1];
                localidades[i] =localidades[i+1];
            }
            numRegistosExistente --;
        }

    } else {
        cout << "Nao temos nenhum registo com o numero " << auxNumRegisto << ".\nDeseja Continuar? (1-Sim | 0-Nao):";
        cin >> op;
    }
}

int main () {

    string nomes[numRegistos], localidades[numRegistos];
    int idades[numRegistos];
    int op=0, aux;

    do {
        op = mostraMenuPrincipal();

        switch (op) {
            case 1:
                numRegistosExistente=0;
                popularDadosInteiros(idades);
                readfile("teste.txt", nomes, idades, localidades);
                break;

            case 2:
                writefile("teste.txt", nomes, idades, localidades);
                cout << "\nTEXTO GRAVADO COM SUCESSO\n";
                break;

            case 3:
                mostraDados(nomes);
                cout << "\n\nContinuar ? (1 - Sim)";
                cin >> aux;
                break;

            case 4:
                mostraDados(localidades);
                cout << "\n\nContinuar ? (1 - Sim)";
                cin >> aux;
                break;

            case 5:
                mostraDadosInteiros(idades);
                cout << "\n\nContinuar ? (1 - Sim)";
                cin >> aux;
                break;

            case 6:
                mostraRegistos(nomes, idades, localidades);
                cout << "\n\nContinuar ? (1 - Sim)";
                cin >> aux;
                break;

            case 11:
                inserirRegisto(nomes, idades, localidades);
                break;

            case 12:
                alterarRegisto(nomes, idades, localidades);
                break;

            case 13:
                apagarRegisto(nomes, idades, localidades);
                break;

            default:
                break;
        }

    } while (op != 0);


    return 0;
}



