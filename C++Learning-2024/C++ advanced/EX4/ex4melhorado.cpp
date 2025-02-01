#include <iostream>
#include <string>
#include <stdio.h>

using namespace std;

class Turmas {

public:
    string nome;
private:
    float notaMedia;
    string listaAlunos[26][4]; // 26 alunos e cada aluno tem 4 informações (nome, num, idade, cidade)
    string listaModulos[50];    // Não se poderia meter na linha acima pois o nome e o num ficaria com 50 modulos cada

public:
    void colocaNotaMedia(float notaX) {
        this->notaMedia = notaX;
    }
    bool inserirAluno(string numeroAluno, string nomeAluno, string idadeAluno, string cidadeAluno) {
        // Procura se o número do plebeu já está na lista
        for (int x = 0; x < 26; x++) {
            if (this->listaAlunos[x][0] == numeroAluno) {
                return false;
            }
        }
        // Procura um espaço vazio na lista para inserir o plebeu
        for (int x = 0; x < 26; x++) {
            if (this->listaAlunos[x][0] == "") {
                this->listaAlunos[x][0] = numeroAluno;
                this->listaAlunos[x][1] = nomeAluno;
                this->listaAlunos[x][2] = idadeAluno;
                this->listaAlunos[x][3] = cidadeAluno;
                return true;
            }
        }
        return false; // falso if não encontrar espaço vazio
    }
    string listagemNumeroAlunos() {
        string aux = "";
        for (int i = 0; i < 26; i++) {
            if (this->listaAlunos[i][0] != "") {
                aux += this->listaAlunos[i][0];
                aux += "\n";
            }
        }
        return aux;
    }

    string listagemNomeAlunos() {
        string aux = "";
        for (int i = 0; i < 26; i++) {
            if (this->listaAlunos[i][1] != "") {
                aux += this->listaAlunos[i][1];
                aux += "\n";
            }
        }
        return aux;
    }

    string listagemIdadeAlunos() {
        string aux = "";
        for (int i = 0; i < 26; i++) {
            if (this->listaAlunos[i][2] != "") {
                aux += this->listaAlunos[i][2];
                aux += "\n";
            }
        }
        return aux;
    }

    string listagemCidadeAlunos() {
        string aux = "";
        for (int i = 0; i < 26; i++) {
            if (this->listaAlunos[i][3] != "") {
                aux += this->listaAlunos[i][3];
                aux += "\n";
            }
        }
        return aux;
    }

    string listagemCompletaAlunos() {
        string aux = "";
        for (int i = 0; i < 26; i++) {
            if (this->listaAlunos[i][0] != "") {
                aux += "Numero: " + this->listaAlunos[i][0] + "\n";
                aux += "Nome: " + this->listaAlunos[i][1] + "\n";
                aux += "Idade: " + this->listaAlunos[i][2] + "\n";
                aux += "Cidade: " + this->listaAlunos[i][3] + "\n\n";
            }
        }
        return aux;
    }

    bool removerAluno(string numeroAluno) {
        for (int i = 0; i < 26; i++) {
            if (listaAlunos[i][0] == numeroAluno) {
                listaAlunos[i][0] = "";
                listaAlunos[i][1] = "";
                listaAlunos[i][2] = "";
                listaAlunos[i][3] = "";
                return true;
            }
        }
        return false;
    }

    void imprimeNumeroAlunos() {
        cout << this->numeroAlunos();
    }
private:
    int numeroAlunos() {
        int contador = 0;
        for (int x = 0; x < 26; x++) {
            if (this->listaAlunos[x][0] != "") {
                contador++;
            }
        }
        return contador;
    }
};

int main() {

    Turmas turma1P;

    //bla bla bla pardais ao ninho
    turma1P.nome = "Turma 1P 2023/2024";
    turma1P.inserirAluno("14466", "Leonardo Fernandes", "17", "Santo Tirso");
    turma1P.inserirAluno("14548", "Rodrigo Viana", "15", "Trofa");
    turma1P.inserirAluno("14467", "Daniel Mota", "16", "Ribeirao");
    turma1P.inserirAluno("14468", "Filipe Soblirov", "16", "Povoa");
    turma1P.inserirAluno("14469", "Hilario Ferreira", "15", "Famalicao");

    int decisao;
    string varAuxNumero, varAuxNome, varAuxIdade, varAuxCidade;

    do {
        cout << "O que quer ver?" << endl;
        cout << "\n1 - Numero de alunos." << endl;
        cout << "2 - Numero dos alunos." << endl;
        cout << "3 - Nome dos alunos." << endl;
        cout << "4 - Idade dos alunos." << endl;
        cout << "5 - Cidade dos alunos." << endl;
        cout << "6 - Ver informacao completa." << endl;
        cout << "7 - Inserir Aluno." << endl;
        cout << "8 - Remover aluno." << endl;
        cout << "0 - Sair." << endl;
        cout << "\nR: ";
        cin >> decisao;

        if (decisao == 1) {
            cout << "________________________________________" << "\nResposta: \n";
            turma1P.imprimeNumeroAlunos();
            cout << "\n________________________________________" << endl;

        } else if (decisao == 2) {
            cout << "________________________________________" << "\nResposta: \n";
            cout << turma1P.listagemNumeroAlunos();
            cout << "________________________________________" << endl;

        } else if (decisao == 3) {
            cout << "________________________________________" << "\nResposta: \n";
            cout << turma1P.listagemNomeAlunos();
            cout << "________________________________________" << endl;

        } else if (decisao == 4) {
            cout << "________________________________________" << "\nResposta: \n";
            cout << turma1P.listagemIdadeAlunos();
            cout << "________________________________________" << endl;

        } else if (decisao == 5) {
            cout << "________________________________________" << "\nResposta: \n";
            cout << turma1P.listagemCidadeAlunos();
            cout << "________________________________________" << endl;

        } else if (decisao == 6) {
            cout << "________________________________________" << "\nResposta: \n";
            cout << turma1P.listagemCompletaAlunos();
            cout << "________________________________________" << endl;

        } else if (decisao == 7) {
            fflush(stdin);
            cout << "Qual o numero do aluno? ";
            cin >> varAuxNumero;
            fflush(stdin);
            cout << "Qual o nome do aluno? ";
            getline(cin, varAuxNome);
            cout << "Qual a idade do aluno? ";
            cin >> varAuxIdade;
            fflush(stdin);
            cout << "Qual a cidade do aluno? ";
            getline(cin, varAuxCidade);
            if (turma1P.inserirAluno(varAuxNumero, varAuxNome, varAuxIdade, varAuxCidade)) {
                cout << "Aluno inserido com sucesso." << endl;
            } else {
                cout << "Numero already adicionado." << endl;
            }
        } else if (decisao == 8) {
            fflush(stdin);
            cout << "Qual o numero do Plebeu que deseja remover? ";
            cin >> varAuxNumero;
            fflush(stdin);
            if (turma1P.removerAluno(varAuxNumero)) {
                cout << "Plebeu excumungado com sucesso." << endl;
            } else {
                cout << "Plebeu nao encontrado." << endl;
            }
        } else if (decisao == 0) {
            return 0;
        }
    } while (decisao != 0);
}
