using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora.OO
{
    class Calculos
    {
        public string[] operacoesRealizadas = new string[50];
        public int operacoesFeitas = 0;
        public string simboloOperacao = "";
        public string opcao = "";
        public double primeiroNumero, segundoNumero;
        public double resultado = 0;

        public void Operacoes(string opcao, double resultado, double primeiroNumero, double segundoNumero, string simboloOperacao)
        {

            switch (opcao)
            {
                case "1":

                    resultado = primeiroNumero + segundoNumero;
                    simboloOperacao = "+";
                    Console.WriteLine("A soma dos numeros Totalizaram: " + resultado); break;
                case "2":

                    resultado = primeiroNumero - segundoNumero;
                    simboloOperacao = "-";
                    Console.WriteLine("a subtração totalizou: " + resultado); break;
                case "3":

                    resultado = primeiroNumero * segundoNumero;
                    simboloOperacao = "*";
                    Console.WriteLine("o Resultado da sua Multiplicação foi: " + resultado); break;
                case "4":

                    if (segundoNumero == 0)
                    {
                        Console.WriteLine("Atenção na Operação de Divisão do segundo numero não pode ser igual ha 0");
                        break;
                    }
                    resultado = primeiroNumero / segundoNumero;
                    simboloOperacao = "/";
                    Console.WriteLine("O resultado da sua divisão foi : " + resultado); break;

            }
        }
        public bool OpcaoSair(string opcao)
        {
            return opcao.Equals("s", StringComparison.OrdinalIgnoreCase);
        }

        public bool OpcaodeVisualizar(string opcao)
        {
            return opcao == "5";
        }

        public bool OpcaoEscolha(string opcao)
        {
            return opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5" && opcao != "S" && opcao != "s";
        }

        public void Menu()
        {
            Console.WriteLine("Calculadora Tabajara");

            Console.WriteLine();          

            Console.WriteLine("Digite 1 para somar");

            Console.WriteLine("Digite 2 para subtrair");

            Console.WriteLine("Digite 3 para multiplicação");

            Console.WriteLine("Digite 4 para divisão");

            Console.WriteLine("Digite 5 para visualizar as operações realizadas");

            Console.WriteLine("Digite S para sair");

        }
    }
}
