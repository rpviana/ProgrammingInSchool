import java.time.LocalDate;
import java.util.*;

public class App {
    public static void main(String[] args) throws Exception {

        Scanner txtEntrada = new Scanner(System.in);

        List<Artigo> livros = new ArrayList<Artigo>();

        Categoria acao = new Categoria("acao", "Acção", null);
        Categoria animacao = new Categoria("animacao", "Animação", acao);


        /*// mexer com a interface
        System.out.println("Escreva o seu nome: ");
        String nome = txtEntrada.nextLine();
        System.out.println("Qual a sua idade: ");
        int idade = txtEntrada.nextInt();
        System.out.println("O seu nome é: " + nome + ", e tem " + idade + " anos.");*/

        int op = 1;
        while (op != 0) {
            System.out.println("Quer inserir Livro? (0 - Não | 1 - Sim) Re: ");
            op = txtEntrada.nextInt();
            /*
             c
             */
            txtEntrada.nextLine();

            if (op != 0) {
                System.out.println("Nome do livro? ");
                String nomeLivro = txtEntrada.nextLine();

                System.out.println("Nome do Autor? ");
                String autorNome = txtEntrada.nextLine();

                System.out.println("Sobrenome do Autor? ");
                String autorSobrenome = txtEntrada.nextLine();

                System.out.println("Data de publicação? (ex: 2024-05-12) Re: ");
                String dataPublicacao = txtEntrada.nextLine();

                livros.add(new Artigo(nomeLivro,
                        new Autor(autorNome, autorSobrenome),
                        LocalDate.parse(dataPublicacao),
                        acao));
                
            }
        }

        

        //Autor autor = new Autor("Rodrigo", "Viana");
        //Categoria categoria = new Categoria();

        Artigo livroX = new Artigo("ABC DEF",
                                    new Autor("Rodrigo", "Viana") , 
                                    LocalDate.of(2024, 05, 07),
                                    animacao);

        livros.add(livroX);
        livros.add(new Artigo("Novo Livro", new Autor("Rodrigo", "Viana"), LocalDate.of(2024, 06, 12), new Categoria()));
        //System.out.println(livros);*/

        for (Artigo artigo : livros) {
            System.out.println(artigo);
        }

        ArtigoWeb livroWeb1 = new ArtigoWeb("ABC DEF",
                                    new Autor("Rodrigo", "Viana") , 
                                    LocalDate.of(2024, 05, 07),
                                    animacao);

        System.out.println(livroWeb1);


    }
}
