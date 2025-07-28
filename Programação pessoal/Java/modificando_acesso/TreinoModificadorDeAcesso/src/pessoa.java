import java.util.Scanner;

public class Pessoa {
    
    LimpaConsole ClearObj = new LimpaConsole();
    
    public Boolean InfoErrada = true;
    
    public String nome;
    public int idade;
    private int Cpf;
    private int codigo;
    private String localizacao;

    public void RecebeDados(){
        
        Scanner Leitura = new Scanner(System.in);        
        
        while(InfoErrada != true){
        System.out.println("Digite uma idade");
         this.idade = Leitura.nextInt();
        System.out.println("Digite um nome");
         this.nome = Leitura.next();
        System.out.println("Digite o número de seu Cpf (Sem pontuação e traço):");
          this.Cpf = Leitura.nextInt();
        System.out.println("Escreva sua localização");
         this.localizacao = Leitura.next();
        
        }
    }
    
    public void RetornaDados(){

            
            Scanner Leitura = new Scanner(System.in);
            ClearObj.Limpador();
            System.out.println("Confira as informações de : "+ nome + "\n");
            System.out.println("Nome: " + nome);
            System.out.println("Idade: " + idade);
            System.out.println("Cpf: " + Cpf);
            System.out.println("Localização: " + localizacao);

            System.out.println("\nOs dados estão corretos?");
            System.out.println("\n1 - Sim\n2 - Não");
                
            int EntradaUsuario;
                EntradaUsuario = Leitura.nextInt();
                    switch(EntradaUsuario){
                        case 1: 
                            ClearObj.Limpador();
                            System.out.println("Cadastro finalizado!\n");
                            InfoErrada = true;
                        
                        case 2: 
                            InfoErrada = false; 
                        }

        }
        
                    
}
    
    
