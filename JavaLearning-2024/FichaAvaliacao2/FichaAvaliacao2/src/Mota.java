import java.time.LocalDate;

public class Mota extends Veiculo {
    
    private boolean pagaIUC; //true or false
    private String suporteMalas;//laterais/top case/etc..

    //Getters..
    public boolean isPagaIUC() {
        return pagaIUC;
    }
    public String getSuporteMalas() {
        return suporteMalas;
    }

    //Setters..
    public void setPagaIUC(boolean pagaIUC) {
        this.pagaIUC = pagaIUC;
        if (pagaIUC == false) this.setIuc(0.0f);
    }
    public void setSuporteMalas(String suporteMalas) {
        this.suporteMalas = suporteMalas;
    }

    //Construtor com atributos..
    public Mota(String matricula, LocalDate dataDaMatricula, String marca, String modelo, int numeroRodas, float iuc,
            String tipoDeVeiculo, String combustivel, int kms) {
        super("", null, "", "", 0, 0, "", "", 0 );
    }
    
    
    //Construtor vazio..
    public Mota() {
        this.pagaIUC = false;
        this.suporteMalas = "";
    }

    
    //toString..
    @Override
    public String toString() {
        return "Mota [pagaIUC=" + pagaIUC + ", suporteMalas=" + suporteMalas + "]";
    }

    

    
}
