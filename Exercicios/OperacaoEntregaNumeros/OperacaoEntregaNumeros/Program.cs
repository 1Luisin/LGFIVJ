namespace OperacaoEntregaNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            int primeironumero;

            Console.WriteLine("Informe o primeiro numero");

            char simbolooperacao;

            Console.WriteLine("Informe o tipo de operação: +, -, * ou /");

            int segundonumero;

            Console.WriteLine("Informe o segundo número");
            
            segundonumero = Convert.ToInt32(Console.ReadLine());
            
            primeironumero = Convert.ToInt32(Console.ReadLine());
            
            
            
            simbolooperacao = Convert.ToChar(Console.ReadLine());

            int operacao = primeironumero + simbolooperacao + segundonumero;
            
            
        }
    }
}
