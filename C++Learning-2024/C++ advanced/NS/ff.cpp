#include <iostream>
#include <string>
#include <algorithm> // Para a fun��o max_element e min_element

using namespace std;

const int numModulosProgramacao = 6;
const int numModulosMatematica = 3;
const int numModulosPortugues = 3;
const int numModulosIngles = 3;
const int numModulosAI = 2;
const int numModulosTIC = 4;
const int numModulosEF = 6;
const int numModulosFQ = 6;
const int numModulosMA = 4;
const int numModulosRedes = 2;
const int numModulosMoral = 1;

// Estrutura para representar cada disciplina e seus m�dulos com notas.
struct materias {
    string areaNome;        // Nome da disciplina
    string moduloNome[20];  // Nomes dos m�dulos
    int moduloNota[20];     // Notas dos m�dulos
};

// Fun��o para calcular a nota m�xima de um m�dulo em uma disciplina.
int notaMaximaModulo(const materias& area, int numModulos) {
    if (numModulos == 0) {
        return 0; // Se n�o houver m�dulos, a nota m�xima � 0.
    }

    // Fun��o para encontrar a nota m�xima entre os m�dulos.
    int notaMaxima = *max_element(area.moduloNota, area.moduloNota + numModulos);
    return notaMaxima;
}

// Fun��o para calcular a nota m�nima acima de 10 de um m�dulo em uma disciplina.
int notaMinimaModulo(const materias& area, int numModulos) {
    if (numModulos == 0) {
        return 0; // Se n�o houver m�dulos, a nota m�nima � 0.
    }
    // Inicializa a nota m�nima como 20 (nota m�xima poss�vel)
    int notaMinima = 20;

    // Itera sobre os m�dulos para encontrar a nota m�nima acima de 10
    for (int i = 0; i < numModulos; ++i) {
        if (area.moduloNota[i] > 10 && area.moduloNota[i] < notaMinima) {
            notaMinima = area.moduloNota[i];
        }
    }

    // Se nenhuma nota acima de 10 for encontrada, retorna 0
    if (notaMinima == 20) {
        return 0;
    }

    return notaMinima;
}

// Fun��o para calcular a m�dia das notas de um m�dulo em uma disciplina.
float calcularMediaModulo(const materias& area, int numModulos) {
    int somaNotas = 0;
    int numModulosComNota = 0;

    // Calcular a soma das notas e contar os m�dulos com notas v�lidas (positivas).
    for (int i = 0; i < numModulos; i++) {
        if (area.moduloNota[i] != 0) {
            somaNotas += area.moduloNota[i];
            numModulosComNota++;
        }
    }

    // Se nenhum m�dulo tiver nota, a m�dia � nula.
    if (numModulosComNota == 0) {
        return 0;
    }

    // Calcula e retorna a m�dia.
    return somaNotas / float(numModulosComNota);
}

// Fun��o para calcular a nota m�xima tirada no curso inteiro
int notaMaximaCurso(const materias disciplinas[], int numDisciplinas) {
    int notaMaxima = 0;

    for (int i = 0; i < numDisciplinas; ++i) {
        for (int j = 0; j < numModulosProgramacao; ++j) {
            notaMaxima = max(notaMaxima, disciplinas[i].moduloNota[j]);
        }
    }

    return notaMaxima;
}

// Fun��o para calcular a nota m�nima acima de 10 tirada no curso inteiro
int notaMinimaCurso(const materias disciplinas[], int numDisciplinas) {
    int notaMinima = 20;

    for (int i = 0; i < numDisciplinas; ++i) {
        for (int j = 0; j < numModulosProgramacao; ++j) {
            if (disciplinas[i].moduloNota[j] > 10 && disciplinas[i].moduloNota[j] < notaMinima) {
                notaMinima = disciplinas[i].moduloNota[j];
            }
        }
    }

    if (notaMinima == 20) {
        return 0; // Retorna 0 se n�o encontrar nenhuma nota acima de 10
    }

    return notaMinima;
}

// Fun��o para calcular a m�dia do curso inteiro
float calcularMediaCurso(const materias disciplinas[], int numDisciplinas) {
    int somaNotas = 0;
    int numModulosComNota = 0;

    for (int i = 0; i < numDisciplinas; ++i) {
        for (int j = 0; j < numModulosProgramacao; ++j) {
            if (disciplinas[i].moduloNota[j] != 0) {
                somaNotas += disciplinas[i].moduloNota[j];
                numModulosComNota++;
            }
        }
    }

    if (numModulosComNota == 0) {
        return 0; // Retorna 0 se nenhum m�dulo tiver nota
    }

    return somaNotas / float(numModulosComNota);
}

void mostraModulos (materias x, int numModulos){
    for (int i=0; i<numModulos; i++) {
        cout << x.moduloNome[i] << endl;
    }
}

int main() {
    // Inst�ncias para cada disciplina.
    materias Programacao;
    materias Matematica;
    materias Portugues;
    materias Ingles;
    materias AI;
    materias TIC;
    materias EF;
    materias FQ;
    materias MA;
    materias Redes;
    materias Moral;

    //Dados para cada disciplina.
    Programacao.areaNome = "Programacao";
    Programacao.moduloNome[0] = "Algoritemia";
    Programacao.moduloNome[1] = "Estrutura e Metodologias da Programacao";
    Programacao.moduloNome[2] = "C++ Fundamentos";
    Programacao.moduloNome[3] = "C++ Avancado";
    Programacao.moduloNome[4] = "JAVA";
    Programacao.moduloNome[5] = "JAVA WEB";
    Programacao.moduloNota[0] = 18;
    Programacao.moduloNota[1] = 19;
    Programacao.moduloNota[2] = 16;
    Programacao.moduloNota[3] = 0;
    Programacao.moduloNota[4] = 0;
    Programacao.moduloNota[5] = 0;

    Matematica.areaNome = "Matematica";
    Matematica.moduloNome[0] = "Geometria";
    Matematica.moduloNome[1] = "Funcoes Polinomiais";
    Matematica.moduloNome[2] = "Estatistica";
    Matematica.moduloNota[0] = 0;
    Matematica.moduloNota[1] = 0;
    Matematica.moduloNota[2] = 15;

    Portugues.areaNome = "Portugues";
    Portugues.moduloNome[0] = "Modulo1Portugues";
    Portugues.moduloNome[1] = "Modulo2Portugues";
    Portugues.moduloNome[2] = "Modulo3Portugues";
    Portugues.moduloNota[0] = 16;
    Portugues.moduloNota[1] = 15;
    Portugues.moduloNota[2] = 0;

    Ingles.areaNome = "Ingles";
    Ingles.moduloNome[0] = "Eu e o Mundo Profissional";
    Ingles.moduloNome[1] = "Um Mundo de Muitas Linguas";
    Ingles.moduloNome[2] = "O Mundo Tecnologico";
    Ingles.moduloNota[0] = 18;
    Ingles.moduloNota[1] = 0;
    Ingles.moduloNota[2] = 0;

    AI.areaNome = "Area de Integracao";
    AI.moduloNome[0] = "Modulo1AI";
    AI.moduloNome[1] = "Modulo2AI";
    AI.moduloNota[0] = 0;
    AI.moduloNota[1] = 0;

    TIC.areaNome = "TIC";
    TIC.moduloNome[0] = "Pesquisar, filtrar e estruturar info e conteudos em ambientes digitais";
    TIC.moduloNome[1] = "Organizacao e tratamento de dados";
    TIC.moduloNome[2] = "Edicao de som e video";
    TIC.moduloNome[3] = "Introducao Modelagem 3D";
    TIC.moduloNota[0] = 0;
    TIC.moduloNota[1] = 0;
    TIC.moduloNota[2] = 0;
    TIC.moduloNota[3] = 0;

    EF.areaNome = "Educacao Fisica";
    EF.moduloNome[0] = "Jogos Desportivos Coletivos";
    EF.moduloNome[1] = "Ginastica";
    EF.moduloNome[2] = "Atletismo/Raquetas/Patinagem";
    EF.moduloNome[3] = "Danca";
    EF.moduloNome[4] = "Aptidao Fisica";
    EF.moduloNome[5] = "Atividades Fisicas/Contextos e Saude";
    EF.moduloNota[0] = 18;
    EF.moduloNota[1] = 0;
    EF.moduloNota[2] = 0;
    EF.moduloNota[3] = 0;
    EF.moduloNota[4] = 0;
    EF.moduloNota[5] = 0;

    FQ.areaNome = "Fisico Quimica";
    FQ.moduloNome[0] = "Forcas e Movimentos";
    FQ.moduloNome[1] = "Estatica";
    FQ.moduloNome[2] = "Hidrostatica e Hidrodinamica";
    FQ.moduloNome[3] = "Luz e Fontes de Luz";
    FQ.moduloNome[4] = "Otica geometrica";
    FQ.moduloNome[5] = "Circuitos eletricos";
    FQ.moduloNota[0] = 15;
    FQ.moduloNota[1] = 16;
    FQ.moduloNota[2] = 14;
    FQ.moduloNota[3] = 0;
    FQ.moduloNota[4] = 0;
    FQ.moduloNota[5] = 0;

    MA.areaNome = "Microprocessadores e automacao";
    MA.moduloNome[0] = "Dispositivos e perifericos";
    MA.moduloNome[1] = "Sistemas operativos - tipologias";
    MA.moduloNome[2] = "Utilitarios";
    MA.moduloNome[3] = "Informatica - nocoes basicas";
    MA.moduloNota[0] = 16;
    MA.moduloNota[1] = 0;
    MA.moduloNota[2] = 0;
    MA.moduloNota[3] = 0;

    Redes.areaNome = "Redes";
    Redes.moduloNome[0] = "Conexoes de rede";
    Redes.moduloNome[1] = "Sistemas de rede local";
    Redes.moduloNota[0] = 17;
    Redes.moduloNota[1] = 0;

    Moral.areaNome = "Educacao Moral e Religiosa";
    Moral.moduloNome[0] = "Modulo1Moral";
    Moral.moduloNota[0] = 0;

    int decisao;
    char escolhaModulo;
    const int numDisciplinas = 11; // N�mero total de disciplinas

    // Disciplinas j� feitas
    materias disciplinas[numDisciplinas] = {Programacao, Matematica, Portugues, Ingles, AI, TIC, EF, FQ, MA, Redes, Moral};

    do {
        cout << "\nO que deseja fazer?" << endl;
        cout << "1 - Ver m�dia de alguma disciplina" << endl;
        cout << "2 - Ver nota m�xima de um m�dulo" << endl;
        cout << "3 - Ver nota m�nima de um m�dulo" << endl;
        cout << "4 - Ver nota m�xima do curso" << endl;
        cout << "5 - Ver nota m�nima acima de 10 do curso" << endl;
        cout << "6 - Ver m�dia do curso" << endl;
        cout << "0 - Sair" << endl;
        cout << "\nEscolha: ";
        cin >> decisao;

        if (decisao >= 1 && decisao <= 6) {
            cout << "Qual disciplina deseja selecionar?" << endl;
            cout << "a - PROGRAMACAO\nb - MATEMATICA\nc - PORTUGUES\nd - INGLES\ne - AREA DE INTEGRACAO\nf - TIC\ng - EDUCACAO FISICA\nh - FISICO-QUIMICA\ni - MICROPROCESSADORES E AUTOMACAO\nj - REDES\nk - EDUCACAO MORAL E RELIGIOSA\nEscolha: ";
            cin >> escolhaModulo;
            int numModulos;
            materias disciplinaSelecionada;

            switch (escolhaModulo) {
                case 'a':
                    numModulos = numModulosProgramacao;
                    disciplinaSelecionada = Programacao;
                    break;
                case 'b':
                    numModulos = numModulosMatematica;
                    disciplinaSelecionada = Matematica;
                    break;
                case 'c':
                    numModulos = numModulosPortugues;
                    disciplinaSelecionada = Portugues;
                    break;
                case 'd':
                    numModulos = numModulosIngles;
                    disciplinaSelecionada = Ingles;
                    break;
                case 'e':
                    numModulos = numModulosAI;
                    disciplinaSelecionada = AI;
                    break;
                case 'f':
                    numModulos = numModulosTIC;
                    disciplinaSelecionada = TIC;
                    break;
                case 'g':
                    numModulos = numModulosEF;
                    disciplinaSelecionada = EF;
                    break;
                case 'h':
                    numModulos = numModulosFQ;
                    disciplinaSelecionada = FQ;
                    break;
                case 'i':
                    numModulos = numModulosMA;
                    disciplinaSelecionada = MA;
                    break;
                case 'j':
                    numModulos = numModulosRedes;
                    disciplinaSelecionada = Redes;
                    break;
                case 'k':
                    numModulos = numModulosMoral;
                    disciplinaSelecionada = Moral;
                    break;
                default:
                    cout << "Sele��o inv�lida." << endl;
                    continue;
            }

            switch (decisao) {
                case 1:
                    cout << "A m�dia da disciplina selecionada �: " << calcularMediaModulo(disciplinaSelecionada, numModulos) << endl;
                    break;
                case 2:
                    cout << "A nota m�xima da disciplina selecionada �: " << notaMaximaModulo(disciplinaSelecionada, numModulos) << endl;
                    break;
                case 3:
                    cout << "A nota m�nima acima de 10 da disciplina selecionada �: " << notaMinimaModulo(disciplinaSelecionada, numModulos) << endl;
                    break;
                default:
                    cout << "Op��o inv�lida." << endl;
            }
        } else if (decisao == 4) {
            cout << "A nota m�xima do curso �: " << notaMaximaCurso(disciplinas, numDisciplinas) << endl;
        } else if (decisao == 5) {
            cout << "A nota m�nima acima de 10 do curso �: " << notaMinimaCurso(disciplinas, numDisciplinas) << endl;
        } else if (decisao == 6) {
            cout << "A m�dia do curso �: " << calcularMediaCurso(disciplinas, numDisciplinas) << endl;
        } else if (decisao != 0) {
            cout << "Op��o inv�lida." << endl;
        }

    } while (decisao != 0);

    return 0;
}

