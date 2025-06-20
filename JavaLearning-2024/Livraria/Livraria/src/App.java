

public class App {
    public static void main(String[] args) throws Exception {
        
        Livraria aLivraria = new Livraria("O Bogalho", "Rua Manuel Silva Pinheiro 271, apt61, 4785-333 Bougado", "Trofa", 934467309, "");
        //System.out.println("Morada de envio: " + aLivraria.getNome());
        //System.out.println(aLivraria.getMoradaCompleta());
        Estante aLivrariaEstante = new Estante("e1", "R/Chao");
        //System.out.println(aLivrariaEstante);

        Livro aLivrariaLivro = new Livro("20Comer100Piedade", "Jose Saramago", 678 );
        System.out.println(aLivrariaLivro.getInfoLivro());

        Leitores aLivrariaLeitores = new Leitores(9, "Rodrigo Viana", "", 934467309, "", "" );
        //System.out.println(aLivrariaLeitores.getTelefoneString());
        System.out.println(aLivrariaLeitores.getIniciais());
        System.out.println(aLivrariaLeitores.getNomeConta());
    }
}
