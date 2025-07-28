public class PessoaIdade {
    
    
    public static void VerificadorIdade(){
        Pessoa Pessoaobj = new Pessoa();
        if (Pessoaobj.idade > 150){
            System.out.println("Idade inválida!");
        }
        else if(Pessoaobj.idade < 0){
            
            System.out.println("Idade inválida!");
        }
    
    }
}
