namespace MaiorNum
{
    internal class Program
    {
        //Faça uma função que receba por paramêtro três números inteiros e retorne o maior número dentre os três passados por parâmetro.
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Digite 3 números a seguir e o programa calculará o valor mais alto:");
            Console.ReadLine();
            Console.Clear();
        
                    
                    Console.WriteLine("Digite o primeiro número");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    
                    Console.WriteLine("Digite o segundo número");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Digite o terceiro número");
                    num3= Convert.ToInt32(Console.ReadLine());


        }
        static void Comparador(int num1, int num2, int num3)

        { 

            if (num1 > num2 && num1 > num3)
            {

                Console.WriteLine("1");
                Console.ReadLine();

            }

            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("2");
                Console.ReadLine();

            }

            else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine("3");
                Console.ReadLine();
            }  
                
            
        }

    }

   


}
