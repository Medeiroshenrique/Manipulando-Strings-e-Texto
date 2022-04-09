using System;
using System.Globalization;
namespace Primeiro
{
    class Programa
    {
        static void Main(String[] args)
    {
        string produto1 = "Computador";
        string produto2 = "Mesa de escritório";
        byte idade = 30;
        int codigo = 5290;
        char genero= 'M';

        double preco1 = 2100;
        double preco2 = 650.50;
        double medida = 53.234567;
        Console.WriteLine("Produtos");
        Console.WriteLine(produto1+"produto1, cujo preço é $ "+preco1);
        Console.WriteLine(produto2+", cujo preço é $ "+ preco2);
        
        Console.WriteLine($"Registro: "+idade+ "de idade, código "+codigo+ "e gênero: "+genero);

        Console.WriteLine("Medida com oito casas decimais:"+ medida);
        Console.WriteLine("Arredondado: {0:f3}",medida);
        Console.WriteLine("Separador decimal invariant culture:"+medida.ToString("F3", CultureInfo.InvariantCulture));

    }
}
    }