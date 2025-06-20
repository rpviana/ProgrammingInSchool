class Viatura {
    protected String marca = "Opel";

    public void buzina() {
        System.out.println("Tuut, tuut!");
    }
}

public class Carro extends Viatura {

    // Atributos privados
    private String marca = "";
    private String modelo = "";
    private String matricula = "";
    private int ano = 0;
    private int kms = 0;
    int x = 0;

    public void setMarca(String nomeMarca) {
        this.marca = nomeMarca;
    }
    public String getMarca () {
        return this.marca;
    }

    public void setModelo(String nomeModelo) {
        this.modelo = nomeModelo;
    }
    public String getModelo() {
        return this.modelo;
    }

    public void setMatricula(String nomeMatricula) {
        this.matricula = nomeMatricula;
    }
    public String getMatricula() {
        return this.matricula;
    }

    public void setAno(int ano) {
        this.ano = ano;
    }
    public int getAno() {
        return this.ano;
    }
 
    public void setKms(int
     kms) {
        this.kms = kms;
    }
    public int getKms() {
        return this.kms;
    }

    public void mostraInfo () {
        System.out.println("Marca = " + this.getMarca());
        System.out.println("Modelo = " + this.getModelo());
        System.out.println("Matricula = " + this.getMatricula());
        System.out.println("Ano = " + this.getAno());
        System.out.println("quilometros = " + this.getKms());

    }

    public Carro(String marcaX, String modeloX) {
        this.marca = marcaX;
        this.modelo = modeloX;
    }

    public Carro(String marcaX, String modeloX, String matriculaX, int anoX, int KmsX) {
        this.marca = marcaX;
        this.modelo = modeloX;
        this.matricula = matriculaX;
        this.ano = anoX;
        this.kms = KmsX;
    }

    /* 
    public static void main(String[] args) {

        if (args.length>0) {
            System.out.println("Recebi os seguintes argumentos: ");
            for (String i : args) {
                System.out.println(i);
            }
        }
        
        Carro meuCarro1= new Carro("Nissan", "GTR" );
        meuCarro.setMarca("Nissan");
        meuCarro.setModelo("gtr");
        meuCarro.setMatricula("95-VP-44");
        meuCarro.setAno(2008);
        meuCarro.setKms(105890);

        meuCarro1.mostraInfo();
    }*/

    public void buzinar() {
        System.out.println("Beep, beep!");
    }
}


