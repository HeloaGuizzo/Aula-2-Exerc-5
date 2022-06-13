using System;

namespace Program;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("----- CÂMBIO DE MOEDAS -----");

        Console.WriteLine("Digite o valor em REAL: ");
        decimal valorReal = Convert.ToInt32(Console.ReadLine());

        double valorDolar = (double)valorReal * 4.90;
        double valorEuro = (double)valorReal * 5.25;
        double valorLibraEsterlina = (double)valorReal * 6.14;
        double valorDolarCanadense = (double)valorReal * 3.90;
        double valorPesoArgentino = (double)valorReal * 0.040;
        double valorPesoChileno = (double)valorReal * 0.0060;


        Console.WriteLine(" O valor em Dólar é: US$ " + (valorDolar));
        Console.WriteLine(" O valor em Euro é : " + (valorEuro));
        Console.WriteLine(" O valor em Libra Esterlina é: " + (valorLibraEsterlina));
        Console.WriteLine(" O valor em Dólar Canadense é: " + (valorDolarCanadense));
        Console.WriteLine(" O valor em Peso Argentino é: " + (valorPesoArgentino));
        Console.WriteLine(" O valor em Peso Chileno é: " + (valorPesoChileno));

    }
}