import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.time.format.DateTimeParseException;

public class App {
    public static void main(String[] args) throws Exception {

        DateTimeFormatter formato = DateTimeFormatter.ofPattern("yyyy/MM/dd");
        String dnAvoPaterno = "1949/12/12";
        String dnAvoPaterna = "1945/06/12";
        String dnAvoMaterno = "1954/07/12";
        String dnAvoMaterna = "1952/01/12";
        String dnpai = "1978/11/12";
        String dnmae = "1982/08/12";
        String dnfilho = "2008/06/12";


    
        Pessoa avoMaterno = new Pessoa("Jose", "Viana", LocalDate.parse(dnAvoMaterno, formato), true, LocalDate.parse("2013/09/11", formato), null, null);
        Pessoa avoMaterna = new Pessoa("Talinha", "Viana", LocalDate.parse(dnAvoMaterna, formato), false, null, null, null);
        Pessoa mae = new Pessoa("Ines", "Viana", LocalDate.parse(dnmae, formato),false, null, avoMaterno, avoMaterna);

        Pessoa avoPaterno = new Pessoa("Emilio", "Pinto", LocalDate.parse(dnAvoPaterno, formato),true, LocalDate.parse("2001/09/11", formato),  null, null);
        Pessoa avoPaterna = new Pessoa("Lurdes", "Pinto", LocalDate.parse(dnAvoPaterna, formato), false, null, null, null);
        Pessoa pai = new Pessoa("Paulo", "Viana", LocalDate.parse(dnpai, formato), false, null, avoPaterno, avoPaterna);
        
        Pessoa filho = new Pessoa("Rodrigo", "Viana", LocalDate.parse(dnfilho, formato), false, null ,pai, mae);
      
       System.out.println(filho.mostraDescendencia(0));
      
        
    }
}
