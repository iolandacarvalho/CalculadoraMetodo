    
namespace Calculos
{
    public class Operacoes
    {
        public static void Somar(decimal num1, decimal num2)
        {
            Console.Write("\n\n" + num1 + " + " + num2 + " = " + (num1 + num2));
        }

        public static void Multiplicar(decimal num1, decimal num2)
        {
            Console.Write(num1 + " x " + num2 + " = " + (num1 * num2));
        }

        public static void Dividir(decimal num1, decimal num2)
        {
            Console.Write(num1 + " ÷ " + num2 + " = " + (num1 / num2));
        }

        public static void Subtrair(decimal num1, decimal num2)
        {
            Console.Write(num1 + " - " + num2 + " = " + (num1 - num2));
        }

    }
}