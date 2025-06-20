#include <iostream>
#include <string>
#include <algorithm>

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

//estrutura para representar cada disciplina e os seus módulos com notas.
struct materias {
    string areaNome;        // Nome da disciplina
    string moduloNome[20];  // Nomes dos módulos
    int moduloNota[20];     // Notas dos módulos
};

// Função para calcular a média de uma área (considerando apenas notas positivas)
float calcularMediaPositiva(const materias& area, int numModulos) {
    int somaNotas = 0;
    int numModulosComNota = 0;

    // Calcular a soma das notas e conta os módulos com notas válidas (positivas).
    for (int i = 0; i < numModulos; i++) {
        if (area.moduloNota[i] > 0) {
            somaNotas += area.moduloNota[i];
            numModulosComNota++;
        }
    }

    // Se nenhum módulo tiver nota, a média é nula.
    if (numModulosComNota == 0) {
        return 0;
    }

    // Calcula e retorna a média.
    return somaNotas / static_cast<float>(numModulosComNota);
}

// Função para calcular a nota máxima de uma área (considerando apenas notas positivas)
int notaMaximaPositiva(const materias& area, int numModulos) {
    int notaMaxima = 0;

    // Encontra a nota máxima entre os módulos com notas positivas.
    for (int i = 0; i < numModulos; ++i) {
        if (area.moduloNota[i] > notaMaxima) {
            notaMaxima = area.moduloNota[i];
        }
    }

    return notaMaxima;
}

// Função para calcular a nota mínima de uma área (considerando apenas notas positivas)
int notaMinimaPositiva(const materias& area, int numModulos) {
    int notaMinima = INT_MAX;

    // Encontra a nota mínima entre os módulos com notas positivas.
    for (int i = 0; i < numModulos; ++i) {
        if (area.moduloNota[i] > 0 && area.moduloNota[i] < notaMinima) {
            notaMinima = area.moduloNota[i];
        }
    }

    // Se nenhuma nota positiva for encontrada, retorna 0.
    if (notaMinima == INT_MAX) {
        return 0;
    }

    return notaMinima;
}

// Função para calcular a nota máxima tirada no curso inteiro
int notaMaximaCurso(const materias disciplinas[], int numDisciplinas) {
    int notaMaxima = 0;

    for (int i = 0; i < numDisciplinas; ++i) {
        for (int j = 0; j < numModulosProgramacao; ++j) {
            notaMaxima = max(notaMaxima, disciplinas[i].moduloNota[j]);
        }
    }

    return notaMaxima;
}

// Função para calcular a nota mínima acima de 10 tirada no curso inteiro
int notaMinimaCurso(const materias disciplinas[], int numDisciplinas) {
    int notaMinima = INT_MAX;

    for (int i = 0; i < numDisciplinas; ++i) {
        for (int j = 0; j < numModulosProgramacao; ++j) {
            if (disciplinas[i].moduloNota[j] > 10 && disciplinas[i].moduloNota[j] < notaMinima) {
                notaMinima = disciplinas[i].moduloNota[j];
            }
        }
    }

    // Se nenhuma nota acima de 10 for encontrada, retorna 0
    if (notaMinima == INT_MAX) {
        return 0;
    }

    return notaMinima;
}

// Função para calcular a média do curso inteiro
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
        return 0; // Retorna 0 se nenhum módulo tiver nota
    }

    return somaNotas / static_cast<float>(numModulosComNota);
}

void mostraModulos(const materias& x, int numModulos) {
    for (int i = 0; i < numModulos; i++) {
        cout << x.moduloNome[i] << endl;
    }
}

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

    //Dados para cada disciplina.
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

    // Disciplinas já feitas
    materias disciplinas[numDisciplinas] = {Programacao, Matematica, Portugues, Ingles, AI, TIC, EF, FQ, MA, Redes, Moral};

    cout << "MODULOS PROGRAMACAO:" << endl;
    mostraModulos(Programacao, numModulosProgramacao);
    cout << "\nMODULOS MATEMATICA:" << endl;
    mostraModulos(Matematica, numModulosMatematica);

    int decisao;

    do {
        cout << "\nO que quer ver?" << endl;
        cout << "1 - Ver média de alguma disciplina" << endl;
        cout << "2 - Ver nota máxima de uma área" << endl;
        cout << "3 - Ver nota mínima de uma área" << endl;
        cout << "4 - Ver nota máxima do curso" << endl;
        cout << "5 - Ver nota mínima acima de 10 do curso" << endl;
        cout << "6 - Ver média do curso" << endl;
        cout << "0 - Sair" << endl;
        cout << "R: ";
        cin >> decisao;

        if (decisao >= 1 && decisao <= 6) {
            switch (decisao) {
                case 1:
                    cout << "Qual disciplina deseja selecionar?" << endl;
                    cout << "a - PROGRAMACAO\nb - MATEMATICA\nc - PORTUGUES\nd - INGLES\ne - AREA DE INTEGRACAO\nf - TIC\ng - EDUCACAO FISICA\nh - FISICO QUIMICA\ni - MICROPROCESSADORES E AUTOMACAO\nj - REDES\nk - EDUCACAO MORAL";
                    cout << "\nR: ";
                    char escolhaModulo;
                    cin >> escolhaModulo;

                    materias disciplinaSelecionada;
                    int numModulos = 0;
                    switch (escolhaModulo) {
                        case 'a':
                            disciplinaSelecionada = Programacao;
                            numModulos = numModulosProgramacao;
                            break;

                        case 'b':
                            disciplinaSelecionada = Matematica;
                            numModulos = numModulosMatematica;
                            break;

                        case 'c':
                            disciplinaSelecionada = Portugues;
                            numModulos = numModulosPortugues;
                            break;

                        case 'd':
                            disciplinaSelecionada = Ingles;
                            numModulos = numModulosIngles;
                            break;

                        case 'e':
                            disciplinaSelecionada = AI;
                            numModulos = numModulosAI;
                            break;

                        case 'f':
                            disciplinaSelecionada = TIC;
                            numModulos = numModulosTIC;
                            break;

                        case 'g':
                            disciplinaSelecionada = EF;
                            numModulos = numModulosEF;
                            break;

                        case 'h':
                            disciplinaSelecionada = FQ;
                            numModulos = numModulosFQ;
                            break;

                        case 'i':
                            disciplinaSelecionada = MA;
                            numModulos = numModulosMA;
                            break;

                        case 'j':
                            disciplinaSelecionada = Redes;
                            numModulos = numModulosRedes;
                            break;

                        case 'k':
                            disciplinaSelecionada = Moral;
                            numModulos = numModulosMoral;
                            break;

                        default:
                            cout << "Essa opção não existe!" << endl;
                            continue;
                    }

                    cout << "A média da disciplina " << disciplinaSelecionada.areaNome << " é: " << calcularMediaPositiva(disciplinaSelecionada, numModulos) << endl;
                    break;

                case 2:
                    cout << "Qual área deseja selecionar?" << endl;
                    cout << "a - PROGRAMACAO\nb - MATEMATICA\nc - PORTUGUES\nd - INGLES\ne - AREA DE INTEGRACAO\nf - TIC\ng - EDUCACAO FISICA\nh - FISICO QUIMICA\ni - MICROPROCESSADORES E AUTOMACAO\nj - REDES\nk - EDUCACAO MORAL";
                    cout << "\nR: ";
                    cin >> escolhaModulo;

                    switch (escolhaModulo) {
                        case 'a':
                            cout << "A nota máxima da área " << Programacao.areaNome << " é: " << notaMaximaPositiva(Programacao, numModulosProgramacao) << endl;
                            break;

                        case 'b':
                            cout << "A nota máxima da área " << Matematica.areaNome << " é: " << notaMaximaPositiva(Matematica, numModulosMatematica) << endl;
                            break;

                        case 'c':
                            cout << "A nota máxima da área " << Portugues.areaNome << " é: " << notaMaximaPositiva(Portugues, numModulosPortugues) << endl;
                            break;

                        case 'd':
                            cout << "A nota máxima da área " << Ingles.areaNome << " é: " << notaMaximaPositiva(Ingles, numModulosIngles) << endl;
                            break;

                        case 'e':
                            cout << "A nota máxima da área " << AI.areaNome << " é: " << notaMaximaPositiva(AI, numModulosAI) << endl;
                            break;

                        case 'f':
                            cout << "A nota máxima da área " << TIC.areaNome << " é: " << notaMaximaPositiva(TIC, numModulosTIC) << endl;
                            break;

                        case 'g':
                            cout << "A nota máxima da área " << EF.areaNome << " é: " << notaMaximaPositiva(EF, numModulosEF) << endl;
                            break;

                        case 'h':
                            cout << "A nota máxima da área " << FQ.areaNome << " é: " << notaMaximaPositiva(FQ, numModulosFQ) << endl;
                            break;

                        case 'i':
                            cout << "A nota máxima da área " << MA.areaNome << " é: " << notaMaximaPositiva(MA, numModulosMA) << endl;
                            break;

                        case 'j':
                            cout << "A nota máxima da área " << Redes.areaNome << " é: " << notaMaximaPositiva(Redes, numModulosRedes) << endl;
                            break;

                        case 'k':
                            cout << "A nota máxima da área " << Moral.areaNome << " é: " << notaMaximaPositiva(Moral, numModulosMoral) << endl;
                            break;

                        default:
                            cout << "Essa opção não existe!" << endl;
                            continue;
                    }
                    break;

                case 3:
                    cout << "Qual área deseja selecionar?" << endl;
                    cout << "a - PROGRAMACAO\nb - MATEMATICA\nc - PORTUGUES\nd - INGLES\ne - AREA DE INTEGRACAO\nf - TIC\ng - EDUCACAO FISICA\nh - FISICO QUIMICA\ni - MICROPROCESSADORES E AUTOMACAO\nj - REDES\nk - EDUCACAO MORAL";
                    cout << "\nR: ";
                    cin >> escolhaModulo;

                    switch (escolhaModulo) {
                        case 'a':
                            cout << "A nota mínima da área " << Programacao.areaNome << " é: " << notaMinimaPositiva(Programacao, numModulosProgramacao) << endl;
                            break;

                        case 'b':
                            cout << "A nota mínima da área " << Matematica.areaNome << " é: " << notaMinimaPositiva(Matematica, numModulosMatematica) << endl;
                            break;

                        case 'c':
                            cout << "A nota mínima da área " << Portugues.areaNome << " é: " << notaMinimaPositiva(Portugues, numModulosPortugues) << endl;
                            break;

                        case 'd':
                            cout << "A nota mínima da área " << Ingles.areaNome << " é: " << notaMinimaPositiva(Ingles, numModulosIngles) << endl;
                            break;

                        case 'e':
                            cout << "A nota mínima da área " << AI.areaNome << " é: " << notaMinimaPositiva(AI, numModulosAI) << endl;
                            break;

                        case 'f':
                            cout << "A nota mínima da área " << TIC.areaNome << " é: " << notaMinimaPositiva(TIC, numModulosTIC) << endl;
                            break;

                        case 'g':
                            cout << "A nota mínima da área " << EF.areaNome << " é: " << notaMinimaPositiva(EF, numModulosEF) << endl;
                            break;

                        case 'h':
                            cout << "A nota mínima da área " << FQ.areaNome << " é: " << notaMinimaPositiva(FQ, numModulosFQ) << endl;
                            break;

                        case 'i':
                            cout << "A nota mínima da área " << MA.areaNome << " é: " << notaMinimaPositiva(MA, numModulosMA) << endl;
                            break;

                        case 'j':
                            cout << "A nota mínima da área " << Redes.areaNome << " é: " << notaMinimaPositiva(Redes, numModulosRedes) << endl;
                            break;

                        case 'k':
                            cout << "A nota mínima da área " << Moral.areaNome << " é: " << notaMinimaPositiva(Moral, numModulosMoral) << endl;
                            break;

                        default:
                            cout << "Essa opção não existe!" << endl;
                            continue;
                    }
                    break;

                case 4:
                    cout << "A nota máxima do curso é: " << notaMaximaCurso(disciplinas, numDisciplinas) << endl;
                    break;

                case 5:
                    cout << "A nota mínima acima de 10 do curso é: " << notaMinimaCurso(disciplinas, numDisciplinas) << endl;
                    break;

                case 6:
                    cout << "A média do curso é: " << calcularMediaCurso(disciplinas, numDisciplinas) << endl;
                    break;
            }
        } else if (decisao != 0) {
            cout << "Opção inválida!" << endl;
        }
    } while (decisao != 0);

    return 0;
}
