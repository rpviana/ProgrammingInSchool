    #include <iostream>

    using namespace std;

    /** função de inicialização do programa **/
    int main() {

    const double pi = 3.1416;
    int numero;
    string nome, sobrenome, resposta;

    nome = sobrenome = "Rodrigo";
    sobrenome = "Viana";

    cout << "_____________________________________________________";
    cout << "\n\t";
    cout << "Comprimentos " << nome <<" "<< sobrenome;
    cout << ", \n\n\t\t Vamos criar esse numero ^2? " "?\n";
    cout << "\t\t Escreva o numero: " << endl;

    cin >> numero;

    //system("cls"); //limpar a tela
    if (numero >= 0) {
        cout << "\t\t"<< " " << numero << " ao quadrado = " <<(numero * numero) << endl;
    } else if (numero == 0) {
        cout << " 0 x 0 = 0 ?!?!?! dumbass";
    } else {
        cout << "apenas serao aceites numeros positivos !!!";
    }

    return 0;
}
