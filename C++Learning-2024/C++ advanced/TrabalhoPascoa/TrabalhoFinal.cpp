#include <iostream>
#include <string>
#include <algorithm> // Para a função max e min element que é usada para encontrar o elemento máximo e o mínimo em um intervalo.

using namespace std;

const int numModulosProgramacao = 6;
const int numModulosMatematica = 3;
const int numModulosPortugues = 3;
const int numModulosING = 3;
const int numModulosAI = 2;
const int numModulosTIC = 4;
const int numModulosEF = 6;
const int numModulosFQ = 6;
const int numModulosMA = 3;
const int numModulosRedes = 2;
const int numModulosMoral = 1;

// Estrutura para representar cada disciplina e os seus módulos com notas.
struct materias {
    string areaNome;        // Nome da disciplina
    string moduloNome[20];  // Nomes dos módulos
    int moduloNota[20];     // Notas dos módulos
};

// Função para calcular a média das notas positivas de uma área.
float calcularMediaPositiva(const materias& area, int numModulos) {
    int somaNotas = 0;
    int numModulosComNota = 0;

    for (int i = 0; i < numModulos; ++i) {
        if (area.moduloNota[i] > 0) {
            somaNotas += area.moduloNota[i];
            numModulosComNota++;
        }
    }

    if (numModulosComNota == 0) {
        return 0; // Retorna 0 se nenhum módulo tiver nota positiva
    }

    return somaNotas / float(numModulosComNota);
}

// Função para retornar a nota máxima das notas positivas de uma área.
int notaMaximaPositiva(const materias& area, int numModulos) {
    int notaMaxima = 0;

    for (int i = 0; i < numModulos; ++i) {
        if (area.moduloNota[i] > 0 && area.moduloNota[i] > notaMaxima) {
            notaMaxima = area.moduloNota[i];
        }
    }

    return notaMaxima;
}

// Função para retornar a nota mínima das notas positivas de uma área.
int notaMinimaPositiva(const materias& area, int numModulos) {
    int notaMinima = 20; // Inicializa com um valor alto para comparação

    for (int i = 0; i < numModulos; ++i) {
        if (area.moduloNota[i] > 0 && area.moduloNota[i] < notaMinima) {
            notaMinima = area.moduloNota[i];
        }
    }

    if (notaMinima == 20) {
        return 0; // Retorna 0 se não houver notas positivas
    }

    return notaMinima;
}

// Função para retornar a nota máxima tirada em todo o curso.
int notaMaximaCurso(const materias disciplinas[], int numDisciplinas) {
    int notaMaxima = 0;

    for (int i = 0; i < numDisciplinas; ++i) {
        for (int j = 0; j < numModulosProgramacao; ++j) {
            if (disciplinas[i].moduloNota[j] > notaMaxima) {
                notaMaxima = disciplinas[i].moduloNota[j];
            }
        }
    }

    return notaMaxima;
}

// Função para retornar a nota mínima tirada em todo o curso.
int notaMinimaCurso(const materias disciplinas[], int numDisciplinas) {
    int notaMinima = 20;

    for (int i = 0; i < numDisciplinas; ++i) {
        for (int j = 0; j < numModulosProgramacao; ++j) {
            if (disciplinas[i].moduloNota[j] > 0 && disciplinas[i].moduloNota[j] < notaMinima) {
                notaMinima = disciplinas[i].moduloNota[j];
            }
        }
    }

    if (notaMinima == 20) {
        return 0; // Retorna 0 se não houver notas positivas no curso
    }

    return notaMinima;
}

// Função para calcular a média de todas as notas do curso.
float calcularMediaCurso(const materias disciplinas[], int numDisciplinas) {
    int somaNotas = 0;
    int numModulosComNota = 0;

    for (int i = 0; i < numDisciplinas; ++i) {
        for (int j = 0; j < numModulosProgramacao; ++j) {
            if (disciplinas[i].moduloNota[j] > 0) {
                somaNotas += disciplinas[i].moduloNota[j];
                numModulosComNota++;
            }
        }
    }

    if (numModulosComNota == 0) {
        return 0; // Retorna 0 se não houver notas positivas no curso
    }

    return somaNotas / float(numModulosComNota);
}

/** Função para mostrar os módulos de uma disciplina
void mostraModulos(const materias& x, int numModulos) {
    for (int i = 0; i < numModulos; i++) {
        cout << x.moduloNome[i] << endl;
    }
}**/

int main() {

    // Instâncias para cada disciplina.
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

    // Dados para cada disciplina.
    Programacao.areaNome = "Programacao";
    Programacao.moduloNome[0] = "algoritemia";
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

    // Definir o número total de disciplinas
    const int numDisciplinas = 11;

    // Disciplinas ja feitas
    materias disciplinas[numDisciplinas] = {Programacao, Matematica, Portugues, Ingles, AI, TIC, EF, FQ, MA, Redes, Moral}; // Adicione as outras disciplinas conforme necessário

    int decisao;
    char escolhaModulo; // char pois decidi ao invés de meter 1/2 etc meter a,b,c

    /**cout << "MODULOS PROGRAMACAO:" << endl;
    mostraModulos(Programacao, numModulosProgramacao);
    cout << "\nMODULOS MATEMATICA:" << endl;
    mostraModulos(Matematica, numModulosMatematica);**/

    do {
        cout << "O que quer ver?" << endl;
        cout << "\n1 - Ver media de alguma Disciplina" << endl;
        cout << "2 - Ver nota maxima detro de uma disciplina" << endl;
        cout << "3 - Ver nota minima dentro de uma disciplina" << endl;
        cout << "4 - Ver nota maxima do curso" << endl;
        cout << "5 - Ver nota minima acima de 10 do curso" << endl;
        cout << "6 - Ver media do curso" << endl;
        cout << "0 - Sair" << endl;
        cout << "\nR: ";
        cin >> decisao;

        if (decisao >= 1 && decisao <= 6) {
            cout << "Qual disciplina deseja selecionar?" << endl;
            cout << "\na - PROGRAMACAO\nb - MATEMATICA\nc - PORTUGUES\nd - INGLES\ne - AREA DE INTEGRACAO\nf - TIC\ng - EDUCACAO FISICA\nh - FISICO QUIMICA\ni - MICROPROCESSADORES E AUTOMACAO\nj - REDES\nk - EDUCACAO MORAL E RELIGIOSA" << endl;
            cout << "R: ";
            cin >> escolhaModulo;
        }

        switch (decisao) {
            case 1:
                switch (escolhaModulo) {
                    case 'a':
                        cout << "Media de Programacao: " << calcularMediaPositiva(Programacao, numModulosProgramacao) << endl;
                        break;
                    case 'b':
                        cout << "Media de Matematica: " << calcularMediaPositiva(Matematica, numModulosMatematica) << endl;
                        break;
                    case 'c':
                        cout << "Media de Portugues: " << calcularMediaPositiva(Portugues, numModulosPortugues) << endl;
                        break;
                    case 'd':
                        cout << "Media de Ingles: " << calcularMediaPositiva(Ingles, numModulosING) << endl;
                        break;
                    case 'e':
                        cout << "Media de Area de Integracao: " << calcularMediaPositiva(AI, numModulosAI) << endl;
                        break;
                    case 'f':
                        cout << "Media de TIC: " << calcularMediaPositiva(TIC, numModulosTIC) << endl;
                        break;
                    case 'g':
                        cout << "Media de Educacao Fisica: " << calcularMediaPositiva(EF, numModulosEF) << endl;
                        break;
                    case 'h':
                        cout << "Media de Fisico Quimica: " << calcularMediaPositiva(FQ, numModulosFQ) << endl;
                        break;
                    case 'i':
                        cout << "Media de Microprocessadores e Automacao: " << calcularMediaPositiva(MA, numModulosMA) << endl;
                        break;
                    case 'j':
                        cout << "Media de Redes: " << calcularMediaPositiva(Redes, numModulosRedes) << endl;
                        break;
                    case 'k':
                        cout << "Media de Educacao Moral e Religiosa: " << calcularMediaPositiva(Moral, 1) << endl;
                        break;
                    default:
                        cout << "Opcao Invalida!" << endl;
                        break;
                }
                break;
            case 2:
                switch (escolhaModulo) {
                    case 'a':
                        cout << "Nota maxima de Programacao: " << notaMaximaPositiva(Programacao, numModulosProgramacao) << endl;
                        break;
                    case 'b':
                        cout << "Nota maxima de Matematica: " << notaMaximaPositiva(Matematica, numModulosMatematica) << endl;
                        break;
                    case 'c':
                        cout << "Nota maxima de Portugues: " << notaMaximaPositiva(Portugues, numModulosPortugues) << endl;
                        break;
                    case 'd':
                        cout << "Nota maxima de Ingles: " << notaMaximaPositiva(Ingles, numModulosING) << endl;
                        break;
                    case 'e':
                        cout << "Nota maxima de Area de Integracao: " << notaMaximaPositiva(AI, numModulosAI) << endl;
                        break;
                    case 'f':
                        cout << "Nota maxima de TIC: " << notaMaximaPositiva(TIC, numModulosTIC) << endl;
                        break;
                    case 'g':
                        cout << "Nota maxima de Educacao Fisica: " << notaMaximaPositiva(EF, numModulosEF) << endl;
                        break;
                    case 'h':
                        cout << "Nota maxima de Fisico Quimica: " << notaMaximaPositiva(FQ, numModulosFQ) << endl;
                        break;
                    case 'i':
                        cout << "Nota maxima de Microprocessadores e Automacao: " << notaMaximaPositiva(MA, numModulosMA) << endl;
                        break;
                    case 'j':
                        cout << "Nota maxima de Redes: " << notaMaximaPositiva(Redes, numModulosRedes) << endl;
                        break;
                    case 'k':
                        cout << "Nota maxima de Educacao Moral e Religiosa: " << notaMaximaPositiva(Moral, 1) << endl;
                        break;
                    default:
                        cout << "Opcao Invalida!" << endl;
                        break;
                }
                break;
            case 3:
                switch (escolhaModulo) {
                    case 'a':
                        cout << "Nota minima de Programacao: " << notaMinimaPositiva(Programacao, numModulosProgramacao) << endl;
                        break;
                    case 'b':
                        cout << "Nota minima de Matematica: " << notaMinimaPositiva(Matematica, numModulosMatematica) << endl;
                        break;
                    case 'c':
                        cout << "Nota minima de Portugues: " << notaMinimaPositiva(Portugues, numModulosPortugues) << endl;
                        break;
                    case 'd':
                        cout << "Nota minima de Ingles: " << notaMinimaPositiva(Ingles, numModulosING) << endl;
                        break;
                    case 'e':
                        cout << "Nota minima de Area de Integracao: " << notaMinimaPositiva(AI, numModulosAI) << endl;
                        break;
                    case 'f':
                        cout << "Nota minima de TIC: " << notaMinimaPositiva(TIC, numModulosTIC) << endl;
                        break;
                    case 'g':
                        cout << "Nota minima de Educacao Fisica: " << notaMinimaPositiva(EF, numModulosEF) << endl;
                        break;
                    case 'h':
                        cout << "Nota minima de Fisico Quimica: " << notaMinimaPositiva(FQ, numModulosFQ) << endl;
                        break;
                    case 'i':
                        cout << "Nota minima de Microprocessadores e Automacao: " << notaMinimaPositiva(MA, numModulosMA) << endl;
                        break;
                    case 'j':
                        cout << "Nota minima de Redes: " << notaMinimaPositiva(Redes, numModulosRedes) << endl;
                        break;
                    case 'k':
                        cout << "Nota minima de Educacao Moral e Religiosa: " << notaMinimaPositiva(Moral, 1) << endl;
                        break;
                    default:
                        cout << "Opcao Invalida!" << endl;
                        break;
                }
                break;
            case 4:
                cout << "Nota maxima do curso: " << notaMaximaCurso(disciplinas, numDisciplinas) << endl;
                break;
            case 5:
                cout << "Nota minima acima de 10 do curso: " << notaMinimaCurso(disciplinas, numDisciplinas) << endl;
                break;
            case 6:
                cout << "Media do curso: " << calcularMediaCurso(disciplinas, numDisciplinas) << endl;
                break;
            case 0:
                cout << "ByeBye!" << endl;
                break;
            default:
                cout << "Opcao Invalida!" << endl;
                break;
        }
    } while (decisao != 0);

    return 0;
}

