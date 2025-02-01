public class Instrumento {
    private int codigo;
    private String tipoInstrumento;

    // get e set de Codigo
    public int getCodigo() {
        return codigo;
    }
    public void setCodigo(int codigo) {
        this.codigo = codigo;
    }
     
    // get e set de tipoInstrumento
    public String getTipoInstrumento() {
        return tipoInstrumento;
    }
    public void setTipoInstrumento(String tipoInstrumento) {
        this.tipoInstrumento = tipoInstrumento;
    }

    
    public Instrumento(int codigo, String tipoInstrumento) {
        this.codigo = 0;
        this.tipoInstrumento = "";
    }
    @Override
    public String toString() {
        return "Instrumento [codigo=" + codigo + ", tipoInstrumento=" + tipoInstrumento + "]";
    }
    
}
