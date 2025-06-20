public class Autor { //
    private String nome;
    private String sobreNome;
    
    public String getNome() {
        return nome;
    }
    public void setNome(String nome) {
        this.nome = nome;
    }
    public String getSobreNome() {
        return sobreNome;
    }
    public void setSobreNome(String sobreNome) {
        this.sobreNome = sobreNome;
    }
    
    public Autor(String nome, String sobreNome) {
        this.nome = nome;
        this.sobreNome = sobreNome;
    }


    @Override 
    public String toString() {
        return "O Nome do Autor é: " + nome + " " + sobreNome + "";
    }

    


}
