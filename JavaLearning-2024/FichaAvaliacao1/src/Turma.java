public class Turma {
    
    private String codigo; //(ex: CX12345)
    private String nomeCurso; //(ex: Programador de Informática)
    private int anoInicio; //(ex: 2023)
    private int anoFim; //(ex: 2026)

    //Getters
    public String getCodigo() {
        return codigo;
    }
    public String getNomeCurso() {
        return nomeCurso;
    }
    public int getAnoInicio() {
        return anoInicio;
    }
    public int getAnoFim() {
        return anoFim;
    }

    //Setters
    public void setCodigo(String codigo) {
        this.codigo = codigo.toUpperCase();
    }
    public void setNomeCurso(String nomeCurso) {
        this.nomeCurso = nomeCurso.toUpperCase();
    }
    public void setAnoInicio(int anoInicio) {
        this.anoInicio = anoInicio;
    }
    public void setAnoFim(int anoFim) {
        this.anoFim = anoFim;
    }

    //informacao da Turma
    public String getInfoTurma() {
        String aux = "";
        
        aux += "Codigo da Turma: " + this.getCodigo() + "\n";
        aux += "Nome do Curso: " + this.getNomeCurso() + "\n";
        aux += "Ano de inicio do Curso: " + this.getAnoInicio() + "\n";
        aux += "Ano de fim do Curso: " + this.getAnoFim() + "\n";

        return aux;
    }

    //contrutor vazio
    public Turma() {
        this.codigo = "";
        this.nomeCurso = "";
        this.anoInicio = 0;
        this.anoFim = 0;
    }

    //contrutor com parametros
    public Turma(String codigo, String nomeCurso, int anoInicio, int anoFim) {
        this.codigo = codigo.toUpperCase();
        this.nomeCurso = nomeCurso.toUpperCase();
        this.anoInicio = anoInicio;
        this.anoFim = anoFim;
    }

    //toString
    @Override
    public String toString() {
        return "Turma [Codigo=" + codigo + ", nomeCurso=" + nomeCurso + ", anoInicio=" + anoInicio + ", anoFim="
                + anoFim + "]";
    }

    

    
    

}
