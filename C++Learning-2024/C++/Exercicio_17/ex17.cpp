#include <iostream>
#include <cmath>
#include <string>
#include <stdio.h>

using namespace std;

        struct Carros {
            string marca;
            string modelo;
            string versao;
            string matricula;
            double ano;
            string proprietario;
        };


    int main () {

        double mediAno, medIdade, aux, someses, dias, mediadiasmes, meses, dias1, diasdomes, diasdomes1;
        int AnoAtual = 2024;
        int mesesano = 12;
        int diasano = 365;
        int aux1;
        int meses1;


        Carros Carros1;
        Carros1.marca = "Opel";
        Carros1.modelo = "Corsa";
        Carros1.versao = "Tdi";
        Carros1.matricula = "94-VP-30";
        Carros1.ano = 2003;
        Carros1.proprietario = "Ines Viana";

        Carros Carros2;
        Carros2.marca = "Pagani";
        Carros2.modelo = "Zonda";
        Carros2.versao = "R";
        Carros2.matricula = "30-45-PQ";
        Carros2.ano = 1999;
        Carros2.proprietario = "Cristiano Ronaldo";

        Carros Carros3;
        Carros3.marca = "Koenigsegg";
        Carros3.modelo = "Gamera";
        Carros3.versao = "F";
        Carros3.matricula = "6H-74-2D";
        Carros3.ano = 2024;
        Carros3.proprietario = "Ines Viana";

        Carros Carros4;
        Carros4.marca = "Fiat";
        Carros4.modelo = "LaPata";
        Carros4.versao = "5";
        Carros4.matricula = "S0-UG-AY";
        Carros4.ano = 1800;
        Carros4.proprietario = "Menina de profissao duvidosa";

        mediAno = (Carros1.ano + Carros2.ano + Carros3.ano + Carros4.ano) / 4;
        medIdade = AnoAtual - mediAno;
        aux = AnoAtual - mediAno;
        aux1 = AnoAtual - mediAno;
        someses = aux - aux1;
        dias = someses * diasano;
        mediadiasmes = diasano / mesesano;
        meses = dias / mediadiasmes;
        meses1 = dias / mediadiasmes;
        diasdomes = meses - meses1;
        diasdomes1 = diasdomes * diasano;





        cout << meses << endl;
        cout << diasano << endl;
        cout << "A media do Ano dos carros e: " << mediAno << " anos" << endl;
        cout << "A media da Idade dos carros e: " << medIdade << " anos" << endl;

        return 0;

}


