public class Guitarra extends Instrumento {
    private int numeroCordas;
    private String subTipo;

    public int getNumeroCordas() {
        return numeroCordas;
    }
    public void setNumeroCordas(int numeroCordas) {
        this.numeroCordas = numeroCordas;
    }

    
    public String getSubTipo() {
        return subTipo;
    }
    public void setSubTipo(String subTipo) {
        this.subTipo = subTipo;
    }


    public Guitarra(String codigo, String tipoInstrumento) {
        super(codigo, tipoInstrumento);
    }


    public Guitarra() {
    }

    
    @Override
    public String toString() {
        return "Guitarra [numeroCordas=" + numeroCordas + ", subTipo=" + subTipo + "]";
    }

    
    
}
