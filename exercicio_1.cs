using System;

class Program
{
    static void Main()
    {
        int opcao;

        do
        {
            Console.WriteLine("\nEscolha uma operação:");
            Console.WriteLine("1 - Calcular Média");
            Console.WriteLine("2 - Verificar Número Primo");
            Console.WriteLine("3 - Calcular Fatorial");
            Console.WriteLine("4 - Converter Celsius para Fahrenheit");
            Console.WriteLine("5 - Calcular Potência");
            Console.WriteLine("0 - Sair");
            Console.Write("Opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite o primeiro número: ");
                    float num1 = float.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo número: ");
                    float num2 = float.Parse(Console.ReadLine());
                    Console.Write("Digite o terceiro número: ");
                    float num3 = float.Parse(Console.ReadLine());
                    Console.WriteLine($"A média é: {CalcularMedia(num1, num2, num3)}");
                    break;

                case 2:
                    Console.Write("Digite um número inteiro: ");
                    int numero = int.Parse(Console.ReadLine());
                    if (EhPrimo(numero))
                        Console.WriteLine($"{numero} é primo.");
                    else
                        Console.WriteLine($"{numero} não é primo.");
                    break;

                case 3:
                    Console.Write("Digite um número inteiro positivo: ");
                    int n = int.Parse(Console.ReadLine());
                    Console.WriteLine($"O fatorial de {n} é: {CalcularFatorial(n)}");
                    break;

                case 4:
                    Console.Write("Digite a temperatura em Celsius: ");
                    float celsius = float.Parse(Console.ReadLine());
                    Console.WriteLine($"A temperatura em Fahrenheit é: {ConverterParaFahrenheit(celsius)}");
                    break;

                case 5:
                    Console.Write("Digite a base: ");
                    int baseNum = int.Parse(Console.ReadLine());
                    Console.Write("Digite o expoente: ");
                    int expoente = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Resultado: {CalcularPotencia(baseNum, expoente)}");
                    break;
            }
        } while (opcao != 0);
    }

    static float CalcularMedia(float a, float b, float c)
    {
        return (a + b + c) / 3;
    }

    static bool EhPrimo(int num)
    {
        if (num < 2) return false;
        for (int i = 2; i <= Math.Sqrt(num); i++)
            if (num % i == 0) return false;
        return true;
    }

    static long CalcularFatorial(int n)
    {
        long fatorial = 1;
        for (int i = 2; i <= n; i++)
            fatorial *= i;
        return fatorial;
    }

    static float ConverterParaFahrenheit(float celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    static long CalcularPotencia(int baseNum, int expoente)
    {
        long resultado = 1;
        for (int i = 0; i < expoente; i++)
            resultado *= baseNum;
        return resultado;
    }
}
