public class Instrumento {
    private String codigo;
    private String tipoInstrumento;

    public String getCodigo() {
        return codigo;
    }
    public void setCodigo(String codigo) {
        this.codigo = codigo;
    }


    public String getTipoInstrumento() {
        return tipoInstrumento;
    }
    public void setTipoInstrumento(String tipoInstrumento) {
        this.tipoInstrumento = tipoInstrumento;
    }

    
    public Instrumento(String codigo, String tipoInstrumento) {
        this.codigo = codigo;
        this.tipoInstrumento = tipoInstrumento;
    }

    
    public Instrumento() {
        this.codigo = "";
        this.tipoInstrumento = "";
    }


    @Override
    public String toString() {
        return "Instrumento [codigo=" + codigo + ", tipoInstrumento=" + tipoInstrumento + "]";
    }

    
    
}
