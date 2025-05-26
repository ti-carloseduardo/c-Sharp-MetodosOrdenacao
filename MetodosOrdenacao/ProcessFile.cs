using System;
using System.Diagnostics; // Namespace necessário para Stopwatch


using MetodosOrdenacao.ClassesOrdenacao;
using MetodosOrdenacao.ExibirVetorOrdenado;
using MetodosOrdenacao.ClassesOrdenacao.Enum;
using MetodosOrdenacao.Randomizador;
using MetodosOrdenacao.Menu;



namespace MetodosOrdenacao
    {
    internal class ProcessFile

        {
        //private static int[] vetorRandomizado; // Tornando-a acessível globalmente e perde independencia vetores
        static void Main(string[] args)
            {
            MenuOrdenacao menu = new MenuOrdenacao(); // Instancia o menu

            Stopwatch stopwatch = new Stopwatch(); // Instancia o cronômetro por metodo.
            Stopwatch stopwatchGeral = new Stopwatch(); // Instancia o cronômetro geral.
            RandomizadorVetor randomizar = new RandomizadorVetor();// delclarado aqui para ser acessado nos if e cases.
            //antes de chamar o menu ja gero um vetor para os testes. 
            Console.WriteLine("Gerando novo vetor...");
            randomizar.LerTamanhoVetor();
            randomizar.Randomize();
            Console.WriteLine("Novo vetor gerado com sucesso!");
            // acesso global.responsavel por randomizar o vetor
            // variaveis private e vetor passado por copia. 
            //  int[] vetorRandomizado = randomizar.ObterCopiaVetorRandomizado();//pegar copia vetor randomizado
            //private static int[] vetorRandomizado; // Tornando-a acessível globalmente
            //ordenacoes(menu e chamada classes e metodos)
            //uso do enum no controle menu organizacao e facilidade manutencao
            //TipoOrdenacaoEnum tipoOrdenacao; //TipoOperacaoEnum tipoOperacao;


            while (true)
                {
                Console.Clear(); // Limpa a tela do console antes de exibir o menu novamente
                int opcao = menu.ExibirMenuPrincipal(); // Chama o método para exibir o menu
                // Verifica se a opção pertence ao TipoOrdenacaoEnum
                if (Enum.IsDefined(typeof(TipoOrdenacaoEnum), opcao))
                        {
                        TipoOrdenacaoEnum tipoOrdenacao = (TipoOrdenacaoEnum)opcao;
                        int[] vetorTeste = randomizar.ObterCopiaVetorRandomizado();

                        Console.WriteLine($"Executando {tipoOrdenacao}...");
                        stopwatch.Restart();

                        // Chamando método de ordenação específico
                        switch (tipoOrdenacao)
                            {
                            case TipoOrdenacaoEnum.BubbleSort:
                                BubbleSort bubble = new BubbleSort(vetorTeste);
                                bubble.Ordenar();
                                Console.WriteLine("Bubble Sort concluído.");
                                break;

                            case TipoOrdenacaoEnum.SelectionSort:
                                SelectionSort selection = new SelectionSort(vetorTeste);
                                selection.Ordenar();
                                Console.WriteLine("Selection Sort concluído.");
                                break;

                            case TipoOrdenacaoEnum.InsertionSort:
                                InsertionSort insertion = new InsertionSort(vetorTeste);
                                insertion.Ordenar();
                                Console.WriteLine("Insertion Sort concluído.");
                                break;

                            case TipoOrdenacaoEnum.MergeSort:
                                MergeSort merge = new MergeSort(vetorTeste);
                                merge.Ordenar();
                                Console.WriteLine("Merge Sort Concluido");
                            break;

                            case TipoOrdenacaoEnum.QuickSort:
                                QuickSort quick = new QuickSort(vetorTeste);
                                quick.Ordenar();    
                            Console.WriteLine("Quick Sort Concluido");
                            break;

                            case TipoOrdenacaoEnum.AllSorts://todos os algoritmos de ordenação

                            stopwatchGeral.Start(); // Inicia o cronômetro geral
                            stopwatch.Start();
                            QuickSort quickSort = new QuickSort(vetorTeste);
                            quickSort.Ordenar();
                            stopwatch.Stop();
                            Console.WriteLine("Quick Sort Concluido");
                            Console.WriteLine($"Tempo de execução: {stopwatch.Elapsed.TotalSeconds} segundos\n");
                            stopwatch.Reset();

                            stopwatch.Start();
                            MergeSort mergeSort = new MergeSort(vetorTeste);
                            mergeSort.Ordenar();
                            stopwatch.Stop();
                            Console.WriteLine("Merge Sort Concluido");
                            Console.WriteLine($"Tempo de execução: {stopwatch.Elapsed.TotalSeconds} segundos\n");
                            stopwatch.Reset();

                            stopwatch.Start();
                            InsertionSort insertionSort = new InsertionSort(vetorTeste);
                            insertionSort.Ordenar();
                            stopwatch.Stop();                                
                            Console.WriteLine("Insertion Sort Concluido");
                            Console.WriteLine($"Tempo de execução: {stopwatch.Elapsed.TotalSeconds} segundos\n");
                            stopwatch.Reset();

                            stopwatch.Start();  
                            SelectionSort selectionSort = new SelectionSort(vetorTeste);
                            selectionSort.Ordenar();
                            stopwatch.Stop();
                            Console.WriteLine("Selection Sort Concluido");
                            Console.WriteLine($"Tempo de execução: {stopwatch.Elapsed.TotalSeconds} segundos\n");
                            stopwatch.Reset();

                            stopwatch.Start();
                            BubbleSort bubbleSort = new BubbleSort(vetorTeste);
                            bubbleSort.Ordenar();
                            stopwatch.Stop();
                            Console.WriteLine("Bubble Sort Concluido");
                            Console.WriteLine($"Tempo de execução: {stopwatch.Elapsed.TotalSeconds} segundos\n");
                            stopwatch.Reset();
                                                        
                            break;
                        }

                        stopwatchGeral.Stop();
                        Console.WriteLine($"\nTempo de execução Geral: {stopwatchGeral.Elapsed.TotalSeconds} segundos");
                    //ajustar nova instancia para usar stowhatch para metodos individuais. 
                    }
                // Verifica se a opção pertence ao TipoOperacaoEnum
                else if (Enum.IsDefined(typeof(TipoOperacaoEnum), opcao))
                        {
                        TipoOperacaoEnum tipoOperacao = (TipoOperacaoEnum)opcao;

                        switch (tipoOperacao)
                            {
                            case TipoOperacaoEnum.ImprimirVetor:
                                Console.WriteLine("Imprimindo vetor de testes...");
                                if (randomizar != null)
                                    {
                                    randomizar.ExibirVetor();
                                    }
                                else
                                    {
                                    Console.WriteLine("Nenhum vetor foi inicializado! Crie um vetor primeiro.");
                                    }
                                break;

                        case TipoOperacaoEnum.GerarNovoVetor:
                                Console.WriteLine("Gerando novo vetor...");
                                randomizar.LerTamanhoVetor();
                                randomizar.Randomize();
                                Console.WriteLine("Novo vetor gerado com sucesso!");
                                break;

                            case TipoOperacaoEnum.Sair:
                                Console.WriteLine("Saindo do programa opcao menu!...");
                                return; // Sai do loop e encerra o programa
                            }
                        }
                    else
                        {
                        Console.WriteLine("Opção inválida! Tente novamente.");
                    }
                    if (opcao != (int)TipoOperacaoEnum.Sair) // Evita a pausa ao sair
                        {
                        Console.WriteLine("\nPressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        }
            }//while (true);
        }//Main
    }//class program 
} //namespace  

               