using System.Threading;

namespace Calculadora
{
    class Programa
    {
        
        static void Main(string[] args)
            
        {
            Menu();
        }
            
        static void Menu() 
        {
            Console.WriteLine("Bem-vindo ao crônometro do Fellipe");
            Console.WriteLine("Para iniciar, digite o tempo desejado abaixo:");
            Console.WriteLine("1s = 1 segundo");
            Console.WriteLine("1m = 1 minuto");

            string entrada = Console.ReadLine().ToLower();
            char caracterUnico = char.Parse(entrada.Substring( entrada.Length - 1 , 1));
            int numeros = int.Parse(entrada.Substring(0, entrada.Length -1));
            
            if(caracterUnico == 'm')
            {
                Console.WriteLine("começando em 3");
                Minutos(numeros);
            }
            else if(caracterUnico == 's')
            {
                Segundos(numeros);
            }
            else if (caracterUnico != 'm')
            {
                Console.Clear();

                Console.WriteLine("Se atente aos carateres utilizados, utilize 's' ou 'm' após a execução da ordem");
            }
        }
        static void Segundos(int numeros)
        {

        

        int basic = 0;

        while (basic != numeros)
        {
            Console.Clear();
            basic++;
        Console.WriteLine(basic);
            Thread.Sleep(1000);
    
        }

        }
   static void Minutos(int numeros)
   {
        numeros = numeros * 60;
        int basic = 0;

        while (basic != numeros)
        {
            Console.Clear();
            basic++;
            Console.WriteLine(basic);
            Thread.Sleep(1000);
    
        }
   }

    }
}