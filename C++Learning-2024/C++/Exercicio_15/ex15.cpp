#include <iostream>
#include <cmath>
#include <string>
#include <stdio.h>

using namespace std;

        struct fAluno {
            int numAluno;
            string nomeAluno;
            int iddAluno;
        };

    int main () {
        fAluno fichaAluno;
        fichaAluno.numAluno = 14548;
        fichaAluno.nomeAluno = "Rodrigo Viana";
        fichaAluno.iddAluno = 15;
        cout << "Aluno : " << fichaAluno.nomeAluno;
        cout << ", tem o numAluno : " << fichaAluno.numAluno;
        cout << " e tem " << fichaAluno.iddAluno << " anos." << endl;

        fAluno fichaAluno2;
        fichaAluno2.numAluno = 14548;
        fichaAluno2.nomeAluno = "Rodrigo Viana";
        fichaAluno2.iddAluno = 16;
        cout << "Aluno : " << fichaAluno2.nomeAluno;
        cout << ", tem o numAluno : " << fichaAluno2.numAluno;
        cout << " e tem " << fichaAluno2.iddAluno << " anos." << endl;


        return 0;

}


