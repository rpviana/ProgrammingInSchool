import java.time.LocalDate;
import java.time.Period;


public class Pessoa {
    
    private String nomeProprio;
    private String sobreNome;
    private LocalDate dataNascimento;
    private boolean falecido;
    private LocalDate dataFalecimento;
    private Pessoa pai;
    private Pessoa mae;

    // Getters e Setters
    public String getNomeProprio() {
        return nomeProprio;
    }

    public void setNomeProprio(String nomeProprio) {
        this.nomeProprio = nomeProprio;
    }

    public String getSobreNome() {
        return sobreNome;
    }

    public void setSobreNome(String sobreNome) {
        this.sobreNome = sobreNome;
    }

    public LocalDate getDataNascimento() {
        return dataNascimento;
    }

    public void setDataNascimento(LocalDate dataNascimento) {
        this.dataNascimento = dataNascimento;
    }

    public boolean isFalecido() {
        return falecido;
    }

    public void setFalecido(boolean falecido) {
        this.falecido = falecido;
    }

    public LocalDate getDataFalecimento() {
        return dataFalecimento;
    }

    public void setDataFalecimento(LocalDate dataFalecimento) {
        this.dataFalecimento = dataFalecimento;
    }

    public Pessoa getPai() {
        return pai;
    }

    public void setPai(Pessoa pai) {
        this.pai = pai;
    }

    public Pessoa getMae() {
        return mae;
    }

    public void setMae(Pessoa mae) {
        this.mae = mae;
    }


    //construtor vazio
    public Pessoa() {
    }

    //contrutor completo
    public Pessoa(String nomeProprio, String sobreNome, LocalDate dataNascimento, boolean falecido,
                                                LocalDate dataFalecimento, Pessoa pai, Pessoa mae) {
        this.nomeProprio = "";
        this.sobreNome = "";
        this.dataNascimento = null;
        this.falecido = false;
        this.dataFalecimento = null;
        this.pai = null;
        this.mae = null;
    }

    //toString
    @Override
    public String toString() {
        return "\n\t Pessoa \n nomeProprio = " + nomeProprio + " \n sobreNome = " + sobreNome + "\n Nome e Sobrenome = " + nomeProprio + " " + sobreNome + 
        "\n dataNascimento = " + dataNascimento + " \n pai = " + pai + " \n mae = " + mae;
    }


    public int getIdade (){
        LocalDate dataAtual = LocalDate.now();
        Period periodo = Period.between(dataNascimento, dataAtual);
        return periodo.getYears();

    }
    public int getIdadeFalecido () {
        Period periodo = Period.between(dataNascimento, dataFalecimento);
        return periodo.getYears();

    }

    public String mostraDescendencia(int nivel) {
        String aux = "\n";
        for ( int i=0; i<nivel; i++) aux+= "\t ";
        aux += nomeProprio + " (";
        if (this.falecido) {
            aux += "faleceu com: " + this.getIdadeFalecido();
        } else {
            aux += this.getIdade();
        }
        aux += " anos)";
        if (pai != null) {
            aux += pai.mostraDescendencia(nivel + 1);
        }
    
        if (mae != null) {
            aux += mae.mostraDescendencia(nivel + 1);
        }
         return aux;
    }


    

}
