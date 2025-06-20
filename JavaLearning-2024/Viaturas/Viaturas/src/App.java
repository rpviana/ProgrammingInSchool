public class App {
    public static void main(String[] args) throws Exception {
        Guitarra guitar1 = new Guitarra("ABCD", "Fender");
        guitar1.setNumeroCordas(6);
        Guitarra guitar2 = new Guitarra("DCBA", "Stratocaster");
        guitar2.setNumeroCordas(4);

        Piano piano1 = new Piano("EFGH", "YAMAHA");
        piano1.setNumeroTeclas(128);
        Piano piano2 = new Piano("HGFE","Fazioli");
        piano2.setNumeroTeclas(62);
        piano2.setSubTipo("Piano de Cauda");

        System.out.println(guitar1);
        System.out.println(guitar2);
        System.out.println(piano1);
        System.out.println(piano2);
    }
}
