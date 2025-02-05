#include <iostream>

using namespace std;
// Declaracao da funcao mostrartabuleiro para que ela possa ser usada antes de ser definida
void mostrartabuleiro(string tabuleiro[6][8]);

// Fun��o para verificar se algum jogador ganhou
bool alguemganhou(string tabuleiro[6][8]) {
    // Verificar horizontalmente
    for(int i = 0; i < 6; i++) {
        for(int j = 0; j < 5; j++) {
            // Se encontrarmos 4 pe�as iguais consecutivas na horizontal, mostramos uma mensagem de vitoria
            if(tabuleiro[i][j] != "" && tabuleiro[i][j] == tabuleiro[i][j+1] && tabuleiro[i][j] == tabuleiro[i][j+2] && tabuleiro[i][j] == tabuleiro[i][j+3]) {
                cout << "Parabens, jogador " << tabuleiro[i][j] << " ganhou!" << endl;
                return 0; // Retornamos imediatamente pois o jogo terminou
            }
        }
    }

    // Verificar verticalmente
    for(int i = 0; i < 3; i++) {
        for(int j = 0; j < 8; j++) {
            // Se encontrarmos 4 pe�as iguais consecutivas na vertical, mostramos uma mensagem de vitoria
            if(tabuleiro[i][j] != "" && tabuleiro[i][j] == tabuleiro[i+1][j] && tabuleiro[i][j] == tabuleiro[i+2][j] && tabuleiro[i][j] == tabuleiro[i+3][j]) {
                cout << "Parabens, jogador " << tabuleiro[i][j] << " ganhou!" << endl;
                return 0; // Retornamos imediatamente pois o jogo terminou
            }
        }
    }

    // Verificar diagonalmente (de cima para baixo)
    for(int i = 0; i < 3; i++) {
        for(int j = 0; j < 5; j++) {
            // Se encontrarmos 4 pe�as iguais consecutivas na diagonal (de cima para baixo), mostramos uma mensagem de vitoria
            if(tabuleiro[i][j] != "" && tabuleiro[i][j] == tabuleiro[i+1][j+1] && tabuleiro[i][j] == tabuleiro[i+2][j+2] && tabuleiro[i][j] == tabuleiro[i+3][j+3]) {
                cout << "Parabens, jogador " << tabuleiro[i][j] << " ganhou!" << endl;
                return 0;
            }
        }
    }

    // Verificar diagonalmente (de baixo para cima)
    for(int i = 3; i < 6; i++) {
        for(int j = 0; j < 5; j++) {
            // Se encontrarmos 4 pe�as iguais consecutivas na diagonal (de baixo para cima), mostramos uma mensagem de vitoria
            if(tabuleiro[i][j] != "" && tabuleiro[i][j] == tabuleiro[i-1][j+1] && tabuleiro[i][j] == tabuleiro[i-2][j+2] && tabuleiro[i][j] == tabuleiro[i-3][j+3]) {
                cout << "Parabens, jogador " << tabuleiro[i][j] << " ganhou!" << endl;
                return 0; // Retornamos imediatamente pois o jogo terminou
            }
        }
    }
}

// Funcao para mostrar o tabuleiro
void mostrartabuleiro(string tabuleiro[6][8]) {
    // Pergunta ao jogador se deseja ver o tabuleiro atual
    char resposta;
    cout << "Deseja ver o tabuleiro atual? (S/N): ";
    cin >> resposta;
    // Se a resposta for afirmativa, mostra o tabuleiro
    if (resposta == 'S' || resposta == 's') {
        cout << "Tabuleiro atual:" << endl;
        for(int i = 0; i < 6; i++) {
            for(int j = 0; j < 8; j++) {
                cout << tabuleiro[i][j] << " ";
            }
            cout << endl;
        }
    }
}

// Funcao para verificar se o tabuleiro esta cheio
bool tabuleirocheio(string tabuleiro[6][8]) {
    for(int i = 0; i < 6; i++) {
        for(int j = 0; j < 8; j++) {
            if(tabuleiro[i][j] == "") {
                return false;// Se houver uma posicao vazia no tabuleiro, retornamos falso
            }
        }
    }
    // Se nao houver nenhuma posicao vazia, retornamos verdadeiro
    return true;
}

// Fun��o para iniciar o jogo
void iniciojogo(string tabuleiro[6][8], char letras[2]) {
    // In�cio do jogo
    cout << "Inicio do jogo!" << endl;
    int coluna;
    int jogador = 0; // jogador 0 e o jogador 1, jogador 1 e o jogador 2
    char resposta; // Variavel para armazenar a resposta do jogador
    // Loop do jogo
    do {
            mostrartabuleiro(tabuleiro); // Mostra o tabuleiro


        // Solicitar a jogada do jogador atual
        cout << "Jogador " << jogador + 1 << " (" << letras[jogador] << "), faca a sua jogada (coluna 0-7): ";
        cin >> coluna;

        // Verificar se a coluna e valida
        if (coluna < 0 || coluna > 7) {
            cout << "Coluna invalida. Tente novamente." << endl;
            continue;
        }

        // Encontrar a primeira posicao vazia na coluna escolhida
        int linha;
        for (linha = 5; linha >= 0; linha--) {
            if (tabuleiro[linha][coluna] == "") {
                tabuleiro[linha][coluna] = letras[jogador]; // Preencher a posicao com a letra do jogador
                break;
            }
        }

        // Verificar se houve 4 em linha
        alguemganhou(tabuleiro);

        // Trocar de jogador
        jogador = (jogador + 1) % 2;

    } while (!tabuleirocheio(tabuleiro) && !alguemganhou(tabuleiro)); // Continuar enquanto houver espa�o vazio no tabuleiro e ninguem ganhar
}

 int main() {
    string nomes[2];
    char letras[2];

    string tabuleiro[6][8] {
        { "", "", "", "", "", "", "", ""},
        { "", "", "", "", "", "", "", ""},
        { "", "", "", "", "", "", "", ""},
        { "", "", "", "", "", "", "", ""},
        { "", "", "", "", "", "", "", ""},
        { "", "", "", "", "", "", "", ""}
    };

    cout << "\n\t\t\t******************* BEM VINDO AO JOGO ******************" << endl << endl;
    cout<<"\n\t\t\t-------------------- TRABALHO PROG --------------------\n\t\t\t";
    cout<<"| 1 - Criado por Rodrigo Viana e Vasco Matos           |\n\t\t\t";
    cout<<"| 2 - Para a disciplina de Programacao                 |\n\t\t\t";
    cout<<"| 3 - Feito em c++ com amor, carinho e dedicacao       |\n\t\t\t";
    cout<<"| 4 - Obs* fizemos readme                              |\n\t\t\t";
    cout<<"-------------------------------------------------------\n\t\t\t" << endl << endl;

    // Solicitar os nomes dos jogadores e suas letras
    for (int i = 0; i < 2; i++) {
        cout << "Nome jogador " << i + 1 << ": ";
        cin >> nomes[i];
        do {
            cout << "Escolha 'X' ou 'O': ";
            cin >> letras[i];
        } while (letras[i] != 'X' && letras[i] != 'O');
    }

    // Iniciar o jogo
    iniciojogo(tabuleiro, letras);

    return 0;
}
