using System;
using System.Diagnostics; // Namespace necessário para Stopwatch

//organizacao projeto
using MetodosOrdenacao.ClassesOrdenacao;
using MetodosOrdenacao.ExibirVetorOrdenado;
using MetodosOrdenacao.ClassesOrdenacao.Enum;
using MetodosOrdenacao.Randomizador;
using MetodosOrdenacao.Menu;
using MetodosOrdenacao.Arquivos;



namespace MetodosOrdenacao
    {
    internal class ProcessFile

        {
        //private static int[] vetorRandomizado; // Tornando-a acessível globalmente e perde independencia vetores
        static void Main(string[] args)
            {
            MenuOrdenacao menu = new MenuOrdenacao(); // Instancia o menu
            RandomizadorVetor randomizar = new RandomizadorVetor();

            Stopwatch stopwatch = new Stopwatch(); // Instancia o cronômetro por metodo.
            Stopwatch stopwatchGeral = new Stopwatch(); // Instancia o cronômetro geral.
            
            // Instancia a classe de gravação de arquivos randomizados e ordenados.
            GravaArquivos gravaArquivo = new GravaArquivos();
            
            //Antes de chamar o menu ja gero um vetor randomizado e obrigatorio para os testes. 
            
            Console.WriteLine("Gerando novo vetor...");
            randomizar.LerTamanhoVetor();
            randomizar.Randomize();
            Console.WriteLine("Novo vetor gerado com sucesso!");
            

            while (true)
                {
                Console.Clear(); // Limpa a tela do console antes de exibir o menu novamente
                int opcao = menu.ExibirMenuPrincipal(); // Chama o método para exibir o menu
                // Verifica se a opção pertence ao TipoOrdenacaoEnum
                if (Enum.IsDefined(typeof(TipoOrdenacaoEnum), opcao))
                        {
                        TipoOrdenacaoEnum tipoOrdenacao = (TipoOrdenacaoEnum)opcao;
                        int[] vetorCopiaVetorRandomizado = randomizar.ObterCopiaVetorRandomizado();

                        Console.WriteLine($"Executando {tipoOrdenacao}...");
                        
                        stopwatch.Restart();// Reinicia o cronômetro para medir o tempo
                                            // de execução do algoritmo de ordenação
                                            // específico

                    // Chamando método de ordenação específico
                    switch (tipoOrdenacao)
                            {
                            case TipoOrdenacaoEnum.BubbleSort:
                                stopwatch.Start();
                                BubbleSort bubble = new BubbleSort(vetorCopiaVetorRandomizado);
                                bubble.Ordenar();
                                stopwatch.Stop(); // Para o cronômetro após a ordenação
                                Console.WriteLine("Bubble Sort concluído.");
                                int[] vetorOrdenadoBubble = bubble.ObterVetorOrdenadoBubbleSort();
                                gravaArquivo.GravarVetorOrdenado(nameof(TipoOrdenacaoEnum.BubbleSort), vetorOrdenadoBubble, stopwatch.Elapsed.TotalSeconds,randomizar.MinValue, randomizar.MaxValue);
                            break;

                            case TipoOrdenacaoEnum.SelectionSort:
                                stopwatch.Start();
                                SelectionSort selection = new SelectionSort(vetorCopiaVetorRandomizado);
                                selection.Ordenar();
                                stopwatch.Stop(); // Para o cronômetro após a ordenação
                                Console.WriteLine("Selection Sort concluído.");
                                int[] vetorOrdenadoSelection = selection.ObterVetorOrdenadoSelectionSort();
                                gravaArquivo.GravarVetorOrdenado(nameof(TipoOrdenacaoEnum.SelectionSort), vetorOrdenadoSelection, stopwatch.Elapsed.TotalSeconds, randomizar.MinValue, randomizar.MaxValue);
                            break;

                            case TipoOrdenacaoEnum.InsertionSort:
                                stopwatch.Start();
                                InsertionSort insertion = new InsertionSort(vetorCopiaVetorRandomizado);
                                insertion.Ordenar();
                                stopwatch.Stop(); // Para o cronômetro após a ordenação
                                Console.WriteLine("Insertion Sort concluído.");
                                int[] vetorOrdenadoInsertion = insertion.ObterVetorOrdenadoInsertionSort();
                                gravaArquivo.GravarVetorOrdenado(nameof(TipoOrdenacaoEnum.InsertionSort), vetorOrdenadoInsertion, stopwatch.Elapsed.TotalSeconds, randomizar.MinValue, randomizar.MaxValue);

                            break;

                            case TipoOrdenacaoEnum.MergeSort:
                                stopwatch.Start();
                                MergeSort merge = new MergeSort(vetorCopiaVetorRandomizado);
                                merge.Ordenar();
                                stopwatch.Stop();    
                                Console.WriteLine("Merge Sort Concluido");
                                int[] vetorOrdenadoMerge = merge.ObterVetorOrdenadoMergeSort();
                                gravaArquivo.GravarVetorOrdenado(nameof(TipoOrdenacaoEnum.MergeSort), vetorOrdenadoMerge, stopwatch.Elapsed.TotalSeconds, randomizar.MinValue, randomizar.MaxValue);

                            break;

                            case TipoOrdenacaoEnum.QuickSort:
                                stopwatch.Start();
                                QuickSort quick = new QuickSort(vetorCopiaVetorRandomizado);
                                quick.Ordenar();    
                                stopwatch.Stop(); // Para o cronômetro após a ordenação
                                Console.WriteLine("Quick Sort Concluido");
                                int[] vetorOrdenadoQuick = quick.ObterVetorOrdenadoQuickSort();
                                gravaArquivo.GravarVetorOrdenado(nameof(TipoOrdenacaoEnum.QuickSort), vetorOrdenadoQuick, stopwatch.Elapsed.TotalSeconds, randomizar.MinValue, randomizar.MaxValue);
                            break;

                            case TipoOrdenacaoEnum.AllSorts://todos os algoritmos de ordenação
                            stopwatchGeral.Start();
                            BubbleSort bubbleSort = new BubbleSort(vetorCopiaVetorRandomizado);
                            bubbleSort.Ordenar();
                            stopwatch.Stop(); // Para o cronômetro após a ordenação
                            double tempoExecucaoBubbleSort = stopwatch.Elapsed.TotalSeconds; // Captura o tempo de execução
                            Console.WriteLine("Bubble Sort concluído.");
                            Console.WriteLine($"Tempo de execução Bubble Sort: {tempoExecucaoBubbleSort} segundos\n");
                            stopwatch.Restart(); // Reinicia o cronômetro para o próximo algoritmo                        

                                                        
                            stopwatch.Start();
                            SelectionSort selectionSort = new SelectionSort(vetorCopiaVetorRandomizado);
                            selectionSort.Ordenar();
                            stopwatch.Stop(); // Para o cronômetro após a ordenação
                            double tempoExecucaoSelectionSort = stopwatch.Elapsed.TotalSeconds; // Captura o tempo de execução
                            Console.WriteLine("Selection Sort concluído.");
                            Console.WriteLine($"Tempo de execução Selection Sort: {tempoExecucaoSelectionSort} segundos\n");
                            stopwatch.Restart(); // Reinicia o cronômetro para o próximo algoritmo

                            
                            stopwatch.Start();
                            InsertionSort insertionSort = new(vetorCopiaVetorRandomizado);
                            insertionSort.Ordenar();
                            stopwatch.Stop(); // Para o cronômetro após a ordenação
                            double tempoExecucaoInsertionSort = stopwatch.Elapsed.TotalSeconds; // Captura o tempo de execução
                            Console.WriteLine("Insertion Sort concluído.");
                            Console.WriteLine($"Tempo de execução Insertion Sort: {tempoExecucaoInsertionSort} segundos\n");
                            stopwatch.Restart(); // Reinicia o cronômetro para o próximo algoritmo
                            
                            
                            stopwatch.Start();
                            MergeSort mergeSort = new(vetorCopiaVetorRandomizado);
                            mergeSort.Ordenar();
                            stopwatch.Stop();
                            double tempoExecucaoMergeSort = stopwatch.Elapsed.TotalSeconds; // Captura o tempo de execução
                            Console.WriteLine("Merge Sort Concluido");
                            Console.WriteLine($"Tempo de execução Merge Sort: {tempoExecucaoMergeSort} segundos\n");
                            stopwatch.Restart(); // Reinicia o cronômetro para o próximo algoritmo

                            
                            stopwatch.Start();
                            QuickSort quickSort = new QuickSort(vetorCopiaVetorRandomizado);
                            quickSort.Ordenar();
                            stopwatch.Stop(); // Para o cronômetro após a ordenação
                            double tempoExecucaoQuickSort = stopwatch.Elapsed.TotalSeconds; // Captura o tempo de execução
                            Console.WriteLine("Quick Sort Concluido");
                            Console.WriteLine($"Tempo de execução Quick Sort: {tempoExecucaoQuickSort} segundos\n");
                            stopwatch.Restart(); // Reinicia o cronômetro para o próximo algoritmo

                        
                            stopwatchGeral.Stop(); 
                            double tempoExecucaoGeral = stopwatchGeral.Elapsed.TotalSeconds;
                            Console.WriteLine($"\nTEMPO DE EXECUCAO TOTAL: {tempoExecucaoGeral} segundos\n");

                            //GRAVAR em arquivo os vetorres ordenados comforme o metodo de ordenação
                            //(tempo execução Ordenacao) e gravado no fim do arquivo.

                            Console.WriteLine("\nCaminhos para os vetores ordenados gravados em arquivos...");
                            
                            int[] vetorOrdenadoBubbleSort = bubbleSort.ObterVetorOrdenadoBubbleSort();
                            int[] vetorOrdenadoSelectionSort = selectionSort.ObterVetorOrdenadoSelectionSort();
                            int[] vetorOrdenadoInsertionSort = insertionSort.ObterVetorOrdenadoInsertionSort();
                            int[] vetorOrdenadoMergeSort = mergeSort.ObterVetorOrdenadoMergeSort();
                            int[] vetorOrdenadoQuickSort = quickSort.ObterVetorOrdenadoQuickSort();

                            gravaArquivo.GravarVetorOrdenado(nameof(TipoOrdenacaoEnum.BubbleSort), vetorOrdenadoBubbleSort, tempoExecucaoBubbleSort, randomizar.MinValue, randomizar.MaxValue);
                            gravaArquivo.GravarVetorOrdenado(nameof(TipoOrdenacaoEnum.SelectionSort), vetorOrdenadoSelectionSort, tempoExecucaoSelectionSort, randomizar.MinValue, randomizar.MaxValue);
                            gravaArquivo.GravarVetorOrdenado(nameof(TipoOrdenacaoEnum.InsertionSort), vetorOrdenadoInsertionSort, tempoExecucaoInsertionSort, randomizar.MinValue, randomizar.MaxValue);
                            gravaArquivo.GravarVetorOrdenado(nameof(TipoOrdenacaoEnum.MergeSort), vetorOrdenadoMergeSort, tempoExecucaoMergeSort, randomizar.MinValue, randomizar.MaxValue);
                            gravaArquivo.GravarVetorOrdenado(nameof(TipoOrdenacaoEnum.QuickSort), vetorOrdenadoQuickSort, tempoExecucaoQuickSort, randomizar.MinValue, randomizar.MaxValue);

                            break;
                            
                        }
                    }
                // Verifica se a opção pertence ao TipoOperacaoEnum
                else if (Enum.IsDefined(typeof(TipoOperacaoEnum), opcao))
                        {
                        TipoOperacaoEnum tipoOperacao = (TipoOperacaoEnum)opcao;

                        switch (tipoOperacao)
                            {
                            case TipoOperacaoEnum.ImprimirVetor:
                                Console.WriteLine("Imprimindo vetor de testes...");
                                randomizar.ExibirVetor();
                                break;

                        case TipoOperacaoEnum.GerarNovoVetor:
                                Console.WriteLine("Gerando novo vetor...");
                                randomizar.LerTamanhoVetor();
                                randomizar.Randomize();
                                Console.WriteLine("Novo vetor gerado com sucesso!");
                            break;


                        case TipoOperacaoEnum.GravarVetorRandomizado:
                            // Grava o vetorRandomizado em arquivo
                            gravaArquivo.GravarVetorRandomizado(randomizar.ObterCopiaVetorRandomizado(), randomizar.MinValue, randomizar.MaxValue);
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

               