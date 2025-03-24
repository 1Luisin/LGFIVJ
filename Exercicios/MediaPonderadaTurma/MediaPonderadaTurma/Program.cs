namespace MediaPonderadaTurma
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            bool appexit = false;

            while (appexit!= true) // não é a variável que é condicionada com o "true" e sim o valor da variável
                //se lê "enquanto o valor falso da variavel "appexit" for diferente de verdadeiro, programa rodará 
            {
            Console.Clear();
            int nota1;
            int nota2;

            Console.WriteLine("Bem vindo ao calculador acadêmico");

            Console.WriteLine("\nDigite sua primeira nota");
            nota1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Digite sua segunda nota");
            nota2 = Convert.ToInt32(Console.ReadLine());

            Pontuacao(nota1, nota2);
        }
        
        static void Pontuacao(int nota1, int nota2)
        {
            int minimoparapassar = 6;
            int somanotas = nota1 + nota2;
            Console.WriteLine($"Nota minima para passar {minimoparapassar}");

           
            
            switch (somanotas) 
            {
                case >= 6:
                    Console.Clear();
                    Console.WriteLine($"Você está apto para passar de período\n Sua nota: {somanotas}\n Minimo para passar: {minimoparapassar}");
                    Console.ReadLine(); 
                break;

                case < 6:
                    Console.Clear();
                    Console.WriteLine($"Você não está apto para passar de período\n Sua nota: {somanotas}\n Minimo para passar: {minimoparapassar}");
                    Console.ReadLine();
                break;

                default:
                    Console.Clear();
                    Console.WriteLine("erro");
                break;
                    
            }
            
            }       
        
        
        }
    
    }

}
