import java.util.Calendar;

public class Aluno {
    
    private String codigo;
    private String nomeProprio;
    private String nomeApelido;
    private int anoNascimento;
    private Turma turma;

    //Getters
    public String getCodigo() {
        return codigo;
    }
    public String getNomeProprio() {
        return nomeProprio;
    }
    public String getNomeApelido() {
        return nomeApelido;
    }
    public int getAnoNascimento() {
        return anoNascimento;
    }
    public Turma getTurma() {
        return turma;
    }

    //Setters
    public void setCodigo(String codigo) {
        this.codigo = codigo;
    }
    public void setNomeProprio(String nomeProprio) {
        this.nomeProprio = nomeProprio;
    }
    public void setNomeApelido(String nomeApelido) {
        this.nomeApelido = nomeApelido;
    }
    public void setAnoNascimento(int anoNascimento) {
        this.anoNascimento = anoNascimento;
    }
    public void setTurma(Turma turma) {
        this.turma = turma;
    }

    //contrutor vazio
    public Aluno() {
        this.codigo = "";
        this.nomeProprio = "";
        this.nomeApelido = "";
        this.anoNascimento = 0;
        this.turma = null;
    }

    //contrutor com parametros
    public Aluno(String codigo, String nomeProprio, String nomeApelido, int anoNascimento, Turma turma) {
        this.codigo = codigo;
        this.nomeProprio = nomeProprio;
        this.nomeApelido = nomeApelido;
        this.anoNascimento = anoNascimento;
        this.turma = turma;
    } 

    public String getNomeCompleto() {
        String aux = "";

        aux += this.getNomeProprio() + " " +  this.getNomeApelido();
        return aux;
    }

    public int getIdade (){
    int currentYear = Calendar.getInstance().get(Calendar.YEAR);
    int idade = currentYear - anoNascimento;

    return idade;
    }
    
    //toString 
    @Override
    public String toString() {
        return "Aluno [codigo=" + codigo + ", nomeProprio=" + nomeProprio + ", nomeApelido=" + nomeApelido
                + ", anoNascimento=" + anoNascimento + ", turma=" + turma + "]";
    }
    

    
}
