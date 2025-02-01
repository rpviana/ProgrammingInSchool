public class App {
    public static void main(String[] args) throws Exception {
        Guitarra guitarra1 = new Guitarra(756, "Guitarra", 8, "cavaquinho");
        guitarra1.setNumeroCordas(6);
        System.out.println(guitarra1);

        Guitarra guitarra2 = new Guitarra(759, "Guitarra", 9, "Eletrica");
        guitarra2.setNumeroCordas(4);
        System.out.println(guitarra2);

        Piano piano1 = new Piano(756, "Guitarra", 8, "cavaquinho");
        piano1.setNumeroTeclas(128);
        System.out.println(piano1);

        Piano piano2 = new Piano(756, "Guitarra", 8, "cavaquinho");
        piano2.setNumeroTeclas(62);
        piano2.setSubTipo("Piano de Cauda");
        System.out.println(piano2);
        
        
    }
}
