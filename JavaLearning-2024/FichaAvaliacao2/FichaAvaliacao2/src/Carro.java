import java.time.LocalDate;

public class Carro extends Veiculo {
    
    private boolean classico; //(ex: True/False)
    private int numeroLugares; //(ex: 4; 5; 7; 2)

    //Getters..
    public boolean isClassico() {
        return classico;
    }
    public int getNumeroLugares() {
        return numeroLugares;
    }
    
    //Setters..
    public void setClassico(boolean classico) {
        this.classico = classico;
    }
    public void setNumeroLugares(int numeroLugares) {
        this.numeroLugares = numeroLugares;
    }

    //Construtor Vazio..
    public Carro() {
        this.classico = false;
        this.numeroLugares = 0;
    }

    //Construtor preenchido com atributos..
    public Carro(String matricula, LocalDate dataDaMatricula, String marca, String modelo, int numeroRodas, float iuc,
            String tipoDeVeiculo, String combustivel, int kms) {
        super("", null, "", "", 0, 0, "", "", 0 );
    }

    //toString..
    @Override
    public String toString() {
        return "Carro [classico=" + classico + ", numeroLugares=" + numeroLugares + "]";
    }

    /**public void getInfo() {
        String aux = "";

        String aux =+ "O carro e um classico? " 
    }**/

    

    

}
