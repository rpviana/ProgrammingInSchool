import java.time.LocalDate;
import java.time.Period;

public class Veiculo {
    
    private String matricula; // (ex: 00-XX-02)
    private LocalDate dataDaMatricula; // (ex: 22/01/2022)
    private String marca;// Opel
    private String modelo; // (ex: Corsa)
    private int numeroRodas; //(ex: 4)
    private float iuc; //(imposto único de circulação ex: 10,20€)
    private String tipoDeVeiculo; // (ex: carro; moto; camião; bicicleta)
    private String combustivel;//(ex: Gasóleo, Híbrido, Elétrico)
    private int Kms; //(ex: 95.000)

    //Getters..
    public String getMatricula() {
        return matricula;
    }
    public LocalDate getDataDaMatricula() {
        return dataDaMatricula;
    }
    public String getMarca() {
        return marca;
    }
    public String getModelo() {
        return modelo;
    }
    public int getNumeroRodas() {
        return numeroRodas;
    }
    public float getIuc() {
        return iuc;
    }
    public String getTipoDeVeiculo() {
        return tipoDeVeiculo;
    }
    public String getCombustivel() {
        return combustivel;
    }
    public int getKms() {
        return Kms;
    }

    //Setters..
    public void setMatricula(String matricula) {
        this.matricula = matricula;
    }
    public void setDataDaMatricula(LocalDate dataDaMatricula) {
        this.dataDaMatricula = dataDaMatricula;
    }
    public void setMarca(String marca) {
        this.marca = marca;
    }
    public void setModelo(String modelo) {
        this.modelo = modelo;
    }
    public void setNumeroRodas(int numeroRodas) {
        this.numeroRodas = numeroRodas;
    }
    public void setIuc(float iuc) {
        this.iuc = iuc;
    }
    public void setTipoDeVeiculo(String tipoDeVeiculo) {
        this.tipoDeVeiculo = tipoDeVeiculo;
    }
    public void setCombustivel(String combustivel) {
        this.combustivel = combustivel;
    }
    public void setKms(int kms) {
        Kms = kms;
    }


    //Construtor vazio
    public Veiculo() {
        this.matricula = "";
        this.dataDaMatricula = null;
        this.marca = "";
        this.modelo = "";
        this.numeroRodas = 0;
        this.iuc = 0;
        this.tipoDeVeiculo = "";
        this.combustivel = "";
        Kms = 0;
    }

    //Construtor com os atributos
    public Veiculo(String matricula, LocalDate dataDaMatricula, String marca, String modelo, int numeroRodas, float iuc,
            String tipoDeVeiculo, String combustivel, int kms) {
        this.matricula = matricula;
        this.dataDaMatricula = dataDaMatricula;
        this.marca = marca;
        this.modelo = modelo;
        this.numeroRodas = numeroRodas;
        this.iuc = iuc;
        this.tipoDeVeiculo = tipoDeVeiculo;
        this.combustivel = combustivel;
        Kms = kms;
    }

    //toString..
    @Override
    public String toString() {
        return "Veiculo [matricula=" + matricula + ", dataDaMatricula=" + dataDaMatricula + ", marca=" + marca
                + ", modelo=" + modelo + ", numeroRodas=" + numeroRodas + ", iuc=" + iuc + ", tipoDeVeiculo="
                + tipoDeVeiculo + ", combustivel=" + combustivel + ", Kms=" + Kms + "]";
    }

    public int getIdadeVeiculo (){
        LocalDate dataAtual = LocalDate.now();
        Period periodo = Period.between(dataDaMatricula, dataAtual);
        return periodo.getYears();
        
    }



    

    

    


}
