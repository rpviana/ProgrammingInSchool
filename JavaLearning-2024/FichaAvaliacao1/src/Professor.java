public class Professor {
    
    private int numero; // ex:12345
    private String nomeProprio; // ex:Rodrigo
    private String nomeApelido; // ex:Viana
    private int anoNascimento; // ex: 1999
    private String area; // ex:Programacao

    //Getters
    public int getNumero() {
        return numero;
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
    public String getArea() {
        return area;
    }

    //Setters
    public void setNumero(int numero) {
        this.numero = numero;
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
    public void setArea(String area) {
        this.area = area;
    }

    //funcao para nome do stor
    public String getNomeCompleto() {
        String nomeProf = "";

        nomeProf += this.getNomeProprio() + " " + this.getNomeApelido();
        return nomeProf;
    }
    
    //construtor vazio
    public Professor() {
        this.numero = 0;
        this.nomeProprio = "";
        this.nomeApelido = "";
        this.anoNascimento = 0;
        this.area = "";
    }

    //construtor com parametros
    public Professor(int numero, String nomeProprio, String nomeApelido, int anoNascimento, String area) {
        this.numero = numero;
        this.nomeProprio = nomeProprio;
        this.nomeApelido = nomeApelido;
        this.anoNascimento = anoNascimento;
        this.area = area;
    }

    //toString
    @Override
    public String toString() {
        return "Professor [numero=" + numero + ", nomeProprio=" + nomeProprio + ", nomeApelido=" + nomeApelido
                + ", anoNascimento=" + anoNascimento + ", Area=" + area + "]";
    }
    
    

    
}
