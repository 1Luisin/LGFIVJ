import java.util.Scanner;

public class Pessoa {

    public String nome;
    public int idade;
    private float Cpf;
    private int codigo;
    private String localizacao;

    public String RecebeDados(){
        Scanner Leitura = new Scanner(System.in);        
        
        System.out.println("Digite uma idade");
         this.idade = Leitura.nextInt();
        System.out.println("Digite um nome");
         this.nome = Leitura.next();
        System.out.println("Digite o número de seu Cpf (Sem pontuação e traço):");
          this.Cpf = Leitura.nextFloat();
        System.out.println("Escreva sua localização");
         this.localizacao = Leitura.next();
        return idade + nome;
    }
    
    public void RetornaDados(){

        Scanner Leitura = new Scanner(System.in);
        System.out.println("Confira as informações de : "+ nome + "\n");
        System.out.println("Nome: " + nome);
        System.out.println("Idade: " + idade);
        System.out.println("Cpf: " + Cpf);
        System.out.println("Localização: " + localizacao);

        System.out.println("\nOs dados estão corretos?");
        System.out.println("\n1 - Sim\n2 - Não");
            int EntradaUsuario;
            EntradaUsuario = Leitura.nextInt();
                      

    }
    
    
}
