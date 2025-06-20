public class Alunos {
    
    String nomeAluno = "";
    private String moradaAluno = "";
    int numAluno = 0;
    private int tlfAluno = 0;

    public void setnmAluno(String nomeAluno) {
        this.nomeAluno = nomeAluno;
    }
    public String getnmAluno () {
        return this.nomeAluno;
    }

    public void setMorada(String morada) {
        this.moradaAluno = morada;
    }
    public String getMorada () {
        return this.moradaAluno;
    }

    public void setNumAluno(int alunos) {
        this.numAluno = alunos;
    }
    public int getNumAluno () {
        return this.numAluno;
    }

    public void setTeleAluno(int teleAluno) {
        this.tlfAluno = teleAluno;
    }
    public int getTeleAluno () {
        return this.tlfAluno;
    }

    public void mostraInfo () {
        System.out.println("Nome do aluno = " + this.getnmAluno());
        System.out.println("Morada do aluno  = " + this.getMorada());
        System.out.println("Numero do aluno = " + this.getNumAluno());
        System.out.println("Telefone do aluno =  " + this.getTeleAluno());

    }

    public Alunos(String nomeX, String moradaX, int numX, int tlfX) {
        this.nomeAluno = nomeX;
        this.moradaAluno = moradaX;
        this.numAluno = numX;
        this.tlfAluno = tlfX;

    }

}


