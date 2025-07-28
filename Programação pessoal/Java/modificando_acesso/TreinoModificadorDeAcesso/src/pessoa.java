import java.util.Scanner;

public class Pessoa {

    private String nome;
    private int idade;

    public String Acesso(){
        Scanner Leitura = new Scanner(System.in);        
        
        System.out.println("Digite uma idade");
         this.idade = Leitura.nextInt();
        
        System.out.println("Digite um nome");
        this.nome = Leitura.next();
        
        return idade + nome;
    }
    
    public void ExibirConsole(){

        System.out.println("Informações da pessoa:\n");
        System.out.println("Nome: " + nome);
        System.out.println("Idade: " + idade);
    
    }
    
    
}
