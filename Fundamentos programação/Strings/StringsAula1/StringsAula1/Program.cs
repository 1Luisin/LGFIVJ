namespace StringsAula1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palavra;

            Console.WriteLine("Informe uma palavra");
            palavra = Console.ReadLine();

            for (int i = 0; i < palavra.Length; i++) 
            {
                if (palavra[i] == 0)
                    {
                    Console.Write("{0}", palavra[i]);
                     }
                Console.Write("-{0} ", palavra[i]);

            
            }
        }
    }
}
