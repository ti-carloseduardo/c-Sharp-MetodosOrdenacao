using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetodosOrdenacao.ClassesOrdenacao.Enum;

namespace MetodosOrdenacao.Menu
    {
    public class MenuOrdenacao
        {
        private int consoleWidth;

        public MenuOrdenacao()
            {
            consoleWidth = Console.WindowWidth;
            }

        private string CentralizeText(string text)
            {
            int padding = (consoleWidth - text.Length) / 2;
            return new string(' ', padding) + text;
            }

        public int ExibirMenuPrincipal()
            {
            Console.WriteLine(CentralizeText("=== MENU ==="));
            Console.WriteLine(CentralizeText($"{(int)TipoOrdenacaoEnum.BubbleSort}. {TipoOrdenacaoEnum.BubbleSort} (Ordenação por Bolha)"));
            Console.WriteLine(CentralizeText($"{(int)TipoOrdenacaoEnum.SelectionSort}. {TipoOrdenacaoEnum.SelectionSort} (Ordenação por Seleção)"));
            Console.WriteLine(CentralizeText($"{(int)TipoOrdenacaoEnum.InsertionSort}. {TipoOrdenacaoEnum.InsertionSort} (Ordenação por Inserção)"));
            Console.WriteLine(CentralizeText($"{(int)TipoOrdenacaoEnum.MergeSort}. {TipoOrdenacaoEnum.MergeSort} (Ordenação por Intercalação)"));
            Console.WriteLine(CentralizeText($"{(int)TipoOrdenacaoEnum.QuickSort}. {TipoOrdenacaoEnum.QuickSort} (Ordenação Rápida)"));
            Console.WriteLine(CentralizeText($"{(int)TipoOrdenacaoEnum.AllSorts}. {TipoOrdenacaoEnum.AllSorts} (Todos Metodos Ordenação)"));
            Console.WriteLine(CentralizeText($"{(int)TipoOperacaoEnum.ImprimirVetor}. Imprimir Vetor de testes"));
            Console.WriteLine(CentralizeText($"{(int)TipoOperacaoEnum.GravarVetorRandomizado}. Gravar Vetor Randomizado em arquivo de texto"));
            Console.WriteLine(CentralizeText($"{(int)TipoOperacaoEnum.GerarNovoVetor}. Gerar um novo Vetor para testes"));
            Console.WriteLine(CentralizeText($"{(int)TipoOperacaoEnum.Sair}. Sair"));
            Console.Write("Escolha uma opção: ");

            int opcao;  // decalarando a variável para armazenar a opção escolhida pelo usuário
            do
                {
                string escolha = Console.ReadLine();

                if (!int.TryParse(escolha, out  opcao) || opcao <= 0)//verifica se a entrada é um número inteiro positivo
                    {
                    Console.WriteLine("Entrada inválida! Por favor, digite um número inteiro positivo.");
                    }
                } while (opcao <= 0);
            return opcao; // Retorna a opção escolhida pelo usuário
            }
        }
    }
