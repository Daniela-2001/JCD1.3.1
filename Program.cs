namespace jcd1._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a tabuada do 5!");

            for (int i = 1; i <= 10; i++)
            {
                int numero = 5;
                int resultado = numero * i;

                Console.WriteLine(numero + " X " + i + " = " + resultado);

            }
        }
    }
}