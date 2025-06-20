public class Estante {
    
    private String codigo;// E 1 e1
    private String andar; //1 2 3 0 /cave


    public String getCodigo() {
        return codigo;
    }
    public void setCodigo(String codigo) {
        this.codigo = codigo.toUpperCase();//forcar letra grande
    }
    public String getAndar() {
        return andar;
    }
    public void setAndar(String andar) {
        this.andar = andar;
    }

    public Estante(String codigo, String andar) {
        this.codigo = codigo;
        this.andar = andar;
    }

    public Estante() {
        this.codigo = "";
        this.andar = "";
    }
    
    @Override
    public String toString() {
        return "Estante [codigo=" + codigo.toUpperCase() + ", andar=" + andar + "]";
    }

    

    

    

    
}
