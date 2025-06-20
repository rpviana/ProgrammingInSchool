public class Piano extends Instrumento {
    private int numeroTeclas;
    private String subTipo;

    // get e set de NumeroTeclas
    public int getNumeroTeclas() {
        return numeroTeclas;
    }
    public void setNumeroTeclas(int numeroTeclas) {
        this.numeroTeclas = numeroTeclas;
    }

    // get e set de subtipo
    public String getSubTipo() {
        return subTipo;
    }
    public void setSubTipo(String subTipo) {
        this.subTipo = subTipo;
    }

    
    
    public Piano(int codigo, String tipoInstrumento, int numeroTeclas, String subTipo) {
        super(codigo, tipoInstrumento);
        this.numeroTeclas = 0;
        this.subTipo = "";
    }
    @Override
    public String toString() {
        return "Piano [numeroTeclas=" + numeroTeclas + ", subTipo=" + subTipo + "]";
    } 
    
}
