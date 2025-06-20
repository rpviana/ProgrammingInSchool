#include <iostream>
#include <string>

using namespace std;

class Disciplina {
public:
    string nomeDisciplina;
    int numModulos;
    string modulos[26]; // Array de nomes de módulos
    float notas[26]; // Array de notas para cada módulo
};

class Cursos {
public:
    string nomeCurso;
private:
    string listaCursos[26][3]; // Cada curso tem o nome e o número de disciplinas
    Disciplina disciplinas[26][26]; // Matriz de disciplinas para cada curso
public:
    bool inserirCurso(string nomeCurso, int numDisciplinas, int numModulos) {
        // Procura se o curso já está na lista
        for (int x = 0; x < 26; x++) {
            if (this->listaCursos[x][0] == nomeCurso) {
                return false;
            }
        }
        // Procura um espaço vazio na lista para inserir o curso
        for (int x = 0; x < 26; x++) {
            if (this->listaCursos[x][0] == "") {
                this->listaCursos[x][0] = nomeCurso;
                this->listaCursos[x][1] = to_string(numDisciplinas);
                this->listaCursos[x][2] = to_string(numModulos);
                // Adiciona disciplinas ao curso
                for (int i = 0; i < numDisciplinas; ++i) {
                    cout << "Digite o nome da disciplina " << i+1 << " do curso " << nomeCurso << ": ";
                    cin >> disciplinas[x][i].nomeDisciplina;
                    cout << "Quantos modulos tem a disciplina " << disciplinas[x][i].nomeDisciplina << "? ";
                    cin >> disciplinas[x][i].numModulos;
                    for (int j = 0; j < disciplinas[x][i].numModulos; ++j) {
                        cout << "Digite o nome do modulo " << j+1 << " da disciplina de " << disciplinas[x][i].nomeDisciplina << ": ";
                        cin >> disciplinas[x][i].modulos[j];
                        char respostaNota;
                        cout << "Existe alguma nota atribuida a este modulo? (SIM = 1/NAO = 2) ";
                        cout << "R: ";
                        cin >> respostaNota;
                        if (respostaNota == 1) {
                            cout << "Digite a nota do modulo (no máximo 20): ";
                            cout << "Nota: ";
                            cin >> disciplinas[x][i].notas[j];
                            while (disciplinas[x][i].notas[j] < 0 || disciplinas[x][i].notas[j] > 20) {
                                cout << "Nota invalida! Digite a nota do módulo (no máximo 20): ";
                                cin >> disciplinas[x][i].notas[j];
                            }
                        } else {
                            disciplinas[x][i].notas[j] = 0;
                        }
                    }
                }
                return true;
            }
        }
        return false; // false se não encontrar espaço vazio
    }

    bool removerCurso(string nomeCurso) {
        for (int i = 0; i < 26; i++) {
            if (listaCursos[i][0] == nomeCurso) {
                listaCursos[i][0] = "";
                listaCursos[i][1] = "";
                listaCursos[i][2] = "";
                listaCursos[i][3] = "";
                return true;
            }
        }
        return false;
    }

   string listagemCompleta() {
        string aux = "";
        for (int i = 0; i < 26; i++) {
            if (this->listaCursos[i][0] != "") {
                aux += "Nome do Curso: " + this->listaCursos[i][0] + "\n";
                aux += "Num de disciplinas dentro do Curso: " + this->listaCursos[i][1] + "\n\n";
                aux += "\n";
            }
        }
        return aux;
    }

    string lstagemNumDisciplinas() {
        string aux = "";
        for (int i = 0; i < 26; i++) {
            if (this->listaCursos[i][0] != "") {
                aux += this->listaCursos[i][1];
                aux += this->listaCursos[i][2];
                aux += "\n";
            }
        }
        return aux;
    }

   string listagemCursos() {
        string aux = "";
        for (int i = 0; i < 26; i++) {
            if (this->listaCursos[i][0] != "") {
                aux += "Nome: " + this->listaCursos[i][0] + "\n";
            }
        }
        return aux;
    }

};

int main() {
    Cursos Curso;

    int decisao;
    string varAuxNomeCurso;
    int varAuxNumDisciplinas, varAuxNumModulos;

      do {
        cout << "O que quer ver?" << endl;
        cout << "\n1 - Nome dos Cursos Iseridos" << endl;
        cout << "2 - Numero de Disciplinas Inseridas e Modulos Inseridos" << endl;
        cout << "3 - Nome das Disciplinas Inseridas" << endl;
        cout << "4 - Nome dos Modulos Inseridos" << endl;
        cout << "5 - Media do Curso" << endl;
        cout << "6 - Media de disciplinas" << endl;
        cout << "7 - Ver notas dos Modulos" << endl;
        cout << "8 - Inserir Curso" << endl;
        cout << "9 - Remover aluno." << endl;
        cout << "10 - Ver informacao completa." << endl;
        cout << "0 - Sair." << endl;
        cout << "\nR: ";
        cin >> decisao;

        if (decisao == 1) {
            cout << "________________________________________" << "\nResposta: \n";
            cout << Curso.listagemCursos();
            cout << "________________________________________" << endl;

        } else if (decisao == 2) {
            cout << "________________________________________" << "\nResposta: \n";
            cout << Curso.lstagemNumDisciplinas();
            cout << "________________________________________" << endl;

        } else if (decisao == 8) {
            fflush(stdin);
            cout << "Qual o nome do Curso?\nR: ";
            cin >> varAuxNomeCurso;
            cout << "Quantas Disciplinas tem?\nR: ";
            cin >> varAuxNumDisciplinas;
            if (Curso.inserirCurso(varAuxNomeCurso, varAuxNumDisciplinas, varAuxNumModulos)) {
                cout << "\nCurso inserido com sucesso." << endl;
                cout << "\n________________________________________________________\n\n";
            } else {
                cout << "Curso ja adicionado." << endl;
            }

        } else if (decisao == 9) {
            fflush(stdin);
            cout << "Nome do Curso que deseja remover: \nR: ";
            cin >> varAuxNomeCurso;
            fflush(stdin);
            if (Curso.removerCurso(varAuxNomeCurso)) {
                cout << "Curso removido com sucesso" << endl;
            } else {
                cout << "Curso nao encontrado" << endl;
            }

        } else if (decisao == 5) {
            cout << "________________________________________" << "\nResposta: \n";
            cout << Curso.listagemCompleta();
            cout << "________________________________________" << endl;

        } else if (decisao == 0) {
            return 0;
        }
    } while (decisao != 0);

    return 0;
}
