using Calculadora.OO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPOO.consoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculos calc = new Calculos();
            while (true)
            {
                calc.Menu();

                calc.opcao = Console.ReadLine();

                if (calc.OpcaoEscolha(calc.opcao))
                {
                    Console.WriteLine("Opcao Inválida");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                if (calc.OpcaodeVisualizar(calc.opcao))
                {
                    if (calc.operacoesFeitas == 0)
                    {
                        Console.WriteLine("Nenhuma operação foi feita até o momento.");
                    }
                    else
                    {
                        for (int i = 0; i < calc.operacoesRealizadas.Length; i++)
                        {
                            if (calc.operacoesRealizadas[i] != null)
                                Console.WriteLine(calc.operacoesRealizadas[i]);
                        }
                    }
                    Console.ReadLine();
                    Console.Clear();

                    continue;
                }

                if (calc.OpcaoSair(calc.opcao))
                {
                    break;
                }

                Console.Write("Digite o primeiro número: ");
                calc.primeiroNumero = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite o segundo número: ");
                calc.segundoNumero = Convert.ToDouble(Console.ReadLine());

                calc.Operacoes(calc.opcao,  calc.resultado, calc.primeiroNumero, calc.segundoNumero, calc.simboloOperacao);

                string operacaoRealizada =
                    calc.primeiroNumero.ToString() + " " + calc.simboloOperacao + " " +
                    calc.segundoNumero.ToString() + " = " + calc.resultado.ToString();

                calc.operacoesRealizadas[calc.operacoesFeitas] = operacaoRealizada;

                calc.operacoesFeitas++;

                Console.WriteLine();
                Console.ReadLine();
                Console.Clear();
            }

        }

    }
}