public class Guitarra extends Instrumento {
    private int numeroCordas;
    private String subTipo;

    // get e set de NumeroCordas
    public int getNumeroCordas() {
        return numeroCordas;
    }
    public void setNumeroCordas(int numeroCordas) {
        this.numeroCordas = numeroCordas;
    }

    // get e set de subtipo
    public String getSubTipo() {
        return subTipo;
    }
    public void setSubTipo(String subTipo) {
        this.subTipo = subTipo;
    }

    

    public Guitarra(int codigo, String tipoInstrumento, int numeroCordas, String subTipo) {
        super(codigo, tipoInstrumento);
        this.numeroCordas = 0;
        this.subTipo = "";
    }
    @Override
    public String toString() {
        return "Guitarra [numeroCordas=" + numeroCordas + ", subTipo=" + subTipo + "]";
    } 
    
    
      
}
