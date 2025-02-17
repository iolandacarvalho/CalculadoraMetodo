// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Menu;
using Calculos;

        decimal num1, num2;
        string simb;

        Console.Clear();
        return1:
        Console.WriteLine("Digite o primeiro número:");
        if(decimal.TryParse(Console.ReadLine(), out num1))
        {
            return2:
            Console.WriteLine("Digite o segundo número:");
            if(decimal.TryParse(Console.ReadLine(), out num2))
            {
                Console.Clear();
                return3:
                Simbolo.ImprimirMenu();
                simb = Console.ReadLine();

                switch (simb)
                {
                    case "+":
                        Console.Clear();
                        Operacoes.Somar(num1, num2);
                    break;

                    case "x":
                        Console.Clear();
                        Operacoes.Multiplicar(num1, num2);
                    break;

                    case "/":
                        Console.Clear();
                        Operacoes.Dividir(num1, num2);
                    break;

                    case "-":
                        Console.Clear();
                        Operacoes.Subtrair(num1, num2);
                    break;

                    default:
                        Console.Clear();
                        Console.WriteLine("\n- Valor Inválido. Tente Novamente -\n");
                        Thread.Sleep(2000);
                        Console.Clear();
                        goto return3;
                    break;
                }
                
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n- Valor Inválido. Tente Novamente -\n");
                Thread.Sleep(2000);
                Console.Clear();
                goto return2;
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("\n- Valor Inválido. Tente Novamente -\n");
            Thread.Sleep(2000);
            Console.Clear();
            goto return1;
        }

        
