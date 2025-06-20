public class Piano extends Instrumento {
    private int numeroTeclas;
    private String subTipo;

    public int getNumeroTeclas() {
        return numeroTeclas;
    }
    public void setNumeroTeclas(int numeroTeclas) {
        this.numeroTeclas = numeroTeclas;
    }


    public String getSubTipo() {
        return subTipo;
    }
    public void setSubTipo(String subTipo) {
        this.subTipo = subTipo;
    }

    public Piano(String codigo, String tipoInstrumento) {
        super(codigo, tipoInstrumento);
    }

    
    public Piano() {
    }


    @Override
    public String toString() {
        return "Piano [numeroTeclas=" + numeroTeclas + ", subTipo=" + subTipo + "]";
    }
    
}
