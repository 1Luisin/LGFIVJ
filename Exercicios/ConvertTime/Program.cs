internal class Program
{
    private static void Main(string[] args)
    
    {
    
    int Totalsegundos, horas, minutos, segundos;

    Console.WriteLine("Informe o total de tempo em segundos");
    Totalsegundos = Int32.Parse(Console.ReadLine());

    horas = Totalsegundos / 3600;
    Totalsegundos = Totalsegundos % 3600;
    minutos = Totalsegundos / 60;
    segundos = Totalsegundos % 60;


    Console.WriteLine("Horas informadas: " + horas + minutos + segundos);
    
   
    
    }
}