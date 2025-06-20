#include <iostream>
#include <fstream>

using namespace std;

int main() {

    // Create and open a text file
    ofstream MyFile("teste.txt");

    // Write to the filebuf
    MyFile << "Isso e um teste feito em codigo!\n";
    MyFile << "Isso e um teste feito em codigo!\n";
    MyFile << "Isso e um teste feito em codigo!\n";
    MyFile << "Isso e um teste feito em codigo!\n";

    //Close the file
    MyFile.close();
}
