// 14548, Rodrigo Pinto Viana
#include <iostream>
#include <string>
#include <algorithm>

using namespace std;

struct Veiculo {

    string tipoVeiculo; //Carro de Passageiros; Carro de Mercadorias, Mota
    string marca;
    string modeloVersao;
    string matricula;
    int ano;// ano em que o veiculo lançou
};

// declaracao da funcao dos meus dados
void colocarDadosMeu (Veiculo & x1) {

    cout << "Qual o tipo de veiculo? (ex:Carro de familia, carrinha de mercadioria)\nR: ";
    cin >> x1.tipoVeiculo;
    cout << "Qual a marca do veiculo? (ex: Nissan)\nR: ";
    cin >> x1.marca;
    cout << "Qual o modelo e a versao do veiculo? (ex: Qasqai 4X4)\nR: ";
    cin >> x1.modeloVersao;
    cout << "Qual a matricula do veiculo? (ex:23-VP-68)\nR: ";
    cin >> x1.matricula;
    cout << "Qual o ano do veiculo? (ex:2000)\nR: ";
    cin >> x1.ano;

}

// Declaracao da funcao dos dados prof
void colocarDadosProf (Veiculo & x2) {

    x2.tipoVeiculo = "Carrinha de mercadorias";
    x2.marca = "Volkswagen";
    x2.modeloVersao = "Polo 1.2 TDI";
    x2.matricula = "00-OX-11";
    x2.ano = 2014;
}

// Funcao para ver veiculo mais recente e caso a idade seja igual dar prioridade ao do prof
void veiculoMaisNovo (Veiculo x1, Veiculo x2) {
    if (x1.ano > x2.ano) {
        cout << x1.ano;
    }
    if (x1.ano < x2.ano) {
        cout << x2.ano;
    }
    if (x1.ano == x2.ano) {
        cout << x2.ano;
    }

}

// Funcao para mostrar os dados completos dos dois Carros
void mostraDados (Veiculo x1, Veiculo x2) {

    cout << "\n\n\n\n\n\n\n\n\n\n\t\tMEU VEICULO\n";
    cout << "\n\tTipo do meu veiculo: " << x1.tipoVeiculo;
    cout << "\n\tMarca do meu veiculo: " << x1.marca;
    cout << "\n\tModelo e versao do meu veiculo: " << x1.modeloVersao;
    cout << "\n\tMatricula do meu veiculo: " << x1.matricula;
    cout << "\n\tAno do meu veiculo: " << x1.ano;

    cout << "\n\n\n\t\tVEICULO DO PROF\n";
    cout << "\n\tTipo do veiculo do prof: " << x2.tipoVeiculo;
    cout << "\n\tMarca do veiculo do prof: " << x2.marca;
    cout << "\n\tModelo e versao do veiculo do prof: " << x2.modeloVersao;
    cout << "\n\tMatricula do veiculo do prof: " << x2.matricula;
    cout << "\n\tAno do veiculo do prof: " << x2.ano << "\n\n\n\n";


}


int main () {

    Veiculo meuVeiculo;
    Veiculo profVeiculo;

    int decisao;

    do {
        cout << "\nO que quer fazer?" << endl;
        cout << "1 - Colocar dados no MEU veiculo" << endl;
        cout << "2 - Ver dados do prof" << endl;
        cout << "3 - Ver veiculo mais novo" << endl;
        cout << "4 - Ver informacao completa" << endl;
        cout << "0 - Sair" << endl;
        cout << "R: ";
        cin >> decisao;
        cout << "\n ";


    switch (decisao) {
        case 1:
            colocarDadosMeu(meuVeiculo);
    }

    switch (decisao) {
        case 2:
            colocarDadosProf(profVeiculo);
    }

    switch (decisao) {
        case 3:
            veiculoMaisNovo(meuVeiculo, profVeiculo);
    }

    switch (decisao) {
        case 4:
            mostraDados(meuVeiculo, profVeiculo);
    }

    } while (decisao != 0);


    cout << "\n\nA minha AutoAvaliacao deste modulo e: 14" << endl;

    return 0;
}

