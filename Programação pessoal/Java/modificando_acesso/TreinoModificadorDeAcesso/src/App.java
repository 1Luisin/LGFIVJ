import java.util.Scanner;

public class App {
    public static void main(String[] args) throws Exception {        
        
        Pessoa Pessoaobj = new Pessoa();
        System.out.println("Cadastro de usuário!\n");
        
        Pessoaobj.RecebeDados();
        Pessoaobj.RetornaDados();
        
    }
}
