#include <iostream>

using namespace std;

/** função de inicialização do programa **/
int main() {

    float x, op, resultado, num1, num2 ;

    cout << "_____________________________________________________";
    cout << "\n\t";
    cout << "Comprimentos " ;
    cout << ", \n\n\t\t Vamos fazer continhas " "?";

    cout << "\n\t\t digite a operacao que deseja \n 1 - Somar \n 2 - subtrair \n 3 - multiplicar \n 4 - dividir" << endl;
    cin >> op;

    cout << "\t\t digite o 1. numero: " << endl;
    cin >> num1;

    cout << "\t\t digite o 2. numero: " << endl;
    cin >> num2;

        if (op == '1');
            cout << "\t\t"<< " A soma do numero " << num1 << " com o numero " << num2 << " e igual a: " <<(num1 + num2) << endl;

        if (op == '2');
            cout << "\t\t"<< " A subtracao do numero " << num1 << " com o numero " << num2 << " e igual a: " <<(num1 - num2) << endl;

        if (op == '3');
            cout << "\t\t"<< " A multiplicacao do numero " << num1 << " com o numero " << num2 << " e igual a: " <<(num1 * num2) << endl;

        if (op == '4');
            cout << "\t\t"<< " divisao do numero " << num1 << " com o numero " << num2 << " e igual a: " <<(num1 / num2) << endl;

  return 0;

}
