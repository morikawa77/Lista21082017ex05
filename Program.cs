using System;

namespace Lista21082017ex05
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int carrosVendidos;
            decimal valorVendas, salarioFixo, valorPorCarro, salarioFinal;

            Console.WriteLine("Digite a quantidade de carros vendidos: ");
            carrosVendidos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor total das vendas: ");
            valorVendas = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite o salário fixo do vendedor: ");
            salarioFixo = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite o valor ganho por carro: ");
            valorPorCarro = Convert.ToDecimal(Console.ReadLine());
            salarioFinal = salarioFixo + (valorPorCarro * carrosVendidos) + (valorVendas * (decimal)0.05);
            Console.WriteLine("O salário final do vendedor é R${0:###,##0.00}", salarioFinal);
            Console.ReadLine();
        }
    }
}
