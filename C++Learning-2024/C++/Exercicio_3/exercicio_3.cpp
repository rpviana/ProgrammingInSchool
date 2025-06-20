#include <iostream>

using namespace std;

/** função de inicialização do programa **/
int main() {

    char letra1, letra2;

    cout << " vai selecionar 2 caminhos : \n";
    cout << " U - UP \n D - DOWN \n L - LEFT \n R - RIGHT \n";
    cout << "\n 1.caminho?";
    cin >> letra1;
    cout << "\n 2.caminho";
    cin >> letra2;

    //cout << " R: " << letra1 <<  letra2;

    if (((letra1 == 'U') && (letra2 == 'U'))
        || ((letra1 == 'R') && (letra2 == 'D'))) {
        cout << ":-| estou coiso";

    } else if (((letra1 == 'U') && (letra2 == 'R'))
        || ((letra1 == 'R') && (letra2 == 'R'))) {
        cout << "/-: estou coiso coisado";

    } else if (((letra1 == 'U') && (letra2 == 'L'))
        || ((letra1 == 'U') && (letra2 == 'D'))
        || ((letra1 == 'D') && (letra2 == 'R'))
        || ((letra1 == 'D') && (letra2 == 'L'))
        || ((letra1 == 'L') && (letra2 == 'L'))
        || ((letra1 == 'R') && (letra2 == 'L'))) {
        cout << ")-: tou triste";

    } else if (((letra1 == 'D') && (letra2 == 'U'))
        || ((letra1 == 'D') && (letra2 == 'D'))
        || ((letra1 == 'L') && (letra2 == 'U'))
        || ((letra1 == 'L') && (letra2 == 'R'))
        || ((letra1 == 'L') && (letra2 == 'D'))
        || ((letra1 == 'R') && (letra2 == 'U'))) {
        cout << ":-) tou contente";

    } else {
        // dar indicacao ao utilizador que ele escreveu alguma coisa mal
        cout << "caminho nao encontrado";
    }

    return 0;
}
