import java.util.Scanner;

public class App {
    public static void main(String[] args) throws Exception {
        Scanner Leitura = new Scanner(System.in);        
        
        Pessoa Pessoaobj = new Pessoa();
        System.out.println("Digite uma idade");
        Pessoaobj.idade = Leitura.nextInt();
        
        System.out.println("Digite um nome");
        Pessoaobj.nome= Leitura.next();

        
    
    }
}
