public class Livraria {
    
    private String nome; 
    private String morada; 
    private String cidade; 
    private int telefone;
    private String email;
    
    public String getNome() {
        return nome.toUpperCase();
    }
    public void setNome(String nome) {
        this.nome = nome;
    }
    public String getMorada() {
        return morada;
    }
    public void setMorada(String morada) {
        this.morada = morada;
    }
    public String getCidade() {
        return cidade;
    }
    public void setCidade(String cidade) {
        this.cidade = cidade;
    }
    public int getTelefone() {
        return telefone;
    }
    public void setTelefone(int telefone) {
        this.telefone = telefone;
    }
    public String getEmail() {
        return email;
    }
    public void setEmail(String email) {
        this.email = email;
    }
    

    public String getMoradaCompleta() {
        String aux = "";

        aux += this.getNome() + "\n" + this.getMorada() + "\n" + this.getCidade();
        return aux;
    }

    public Livraria(String nome, String morada, String cidade, int telefone, String email) {
        this.nome = nome;
        this.morada = morada;
        this.cidade = cidade;
        this.telefone = telefone;
        this.email = email;
    }

    public Livraria() {
        this.nome = "";
        this.morada = "";
        this.cidade = "";
        this.telefone = 0;
        this.email = "";
    }

    
    @Override
    public String toString() {
        return "Livraria [nome=" + nome + ", morada=" + morada + ", cidade=" + cidade + ", telefone=" + telefone
                + ", email=" + email + "]";
    } 

    

    
    
}
