public class Leitores {
    
    private int numero;
    private String nome;
    private String morada;
    private int telefone;
    private String email;
    private String genero;

    public int getNumero() {
        return numero;
    }
    public void setNumero(int numero) {
        this.numero = numero;
    }
    public String getNome() {
        return nome;
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
    public String getGenero() {
        return genero;
    }
    public void setGenero(String genero) {
        this.genero = genero;
    }

    public String getTelefoneString() {
        String aux = String.valueOf(telefone);//tornar em string
        String res = "";
        res += aux.substring(0, 3);
        res += " ";
        res += aux.substring(3, 6);
        res += " ";
        res += aux.substring(6, 9);
        return res;
    }

    public String getIniciais() {
        String res = "";
        String [] aux = nome.split(" ");
        for (String ch : aux) {
            res += ch.substring(0, 1);
        }
        return res;
    }

    public String getNomeConta() {
        String nomeProprio = "";
        String nomeApelido = "";
        String [] aux = nome.split(" ");
        for (String ch : aux) {
            if (nomeProprio != "") {
                nomeApelido = ch;
            }
            if (nomeProprio == "") {
            nomeProprio = ch.substring(0, 1);
            }
        }
    }
    
    public Leitores(int numero, String nome, String morada, int telefone, String email, String genero) {
        this.numero = numero;
        this.nome = nome;
        this.morada = morada;
        this.telefone = telefone;
        this.email = email;
        this.genero = genero;
    }

    public Leitores() {
        this.numero = 0;
        this.nome = "";
        this.morada = "";
        this.telefone = 0;
        this.email = "";
        this.genero = "";
    }

    
    @Override
    public String toString() {
        return "Leitores [numero=" + numero + ", nome=" + nome + ", morada=" + morada + ", telefone=" + telefone
                + ", email=" + email + ", genero=" + genero + "]";
    }

    

    
    

    
}
