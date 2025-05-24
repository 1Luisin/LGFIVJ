namespace CalculadorEscolar
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int contador;

            Console.WriteLine("Bem vindo ao Calculador Escolar! \nDigite o número de alunos que você deseja calcular a nota.");
            int TotalAluno = Convert.ToInt32(Console.ReadLine());
            int[] NotaAluno = new int[TotalAluno];
            string[] Nome = new string[TotalAluno];
            
            for (contador = 0; contador < TotalAluno; contador++)
            {   
                Console.WriteLine("Digite o nome do aluno {0} de {1}", contador + 1, TotalAluno);
                Nome[contador] = Console.ReadLine();
                Console.WriteLine("Digite a nota do(a) " + Nome[contador]);
                NotaAluno[contador] = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}
