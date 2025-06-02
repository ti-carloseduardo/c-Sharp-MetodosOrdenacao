using System;

namespace MetodosOrdenacao.ClassesOrdenacao
    {
    public class SelectionSort
        {
      
        public int[] VetorOrdenadoSelectionSort { get; set; }

        public SelectionSort() { }
        
        public SelectionSort(int[] vetorCopia)
            {
            VetorOrdenadoSelectionSort = vetorCopia;
            }
        public int[] ObterVetorOrdenadoSelectionSort()
            {
            return VetorOrdenadoSelectionSort;
            }

        
        public void Ordenar()
            {
           // Console.WriteLine("Executando Selection Sort...");

            // Implementação do algoritmo Selection Sort
            int n = VetorOrdenadoSelectionSort.Length;
            for (int i = 0; i < n - 1; i++)
                {
                int menorIndice = i;
                for (int j = i + 1; j < n; j++)
                    {
                    if (VetorOrdenadoSelectionSort[j] < VetorOrdenadoSelectionSort[menorIndice])
                        {
                        menorIndice = j; // Encontra o menor elemento
                        }
                    }
                // Trocar elementos
                int temp = VetorOrdenadoSelectionSort[menorIndice];
                VetorOrdenadoSelectionSort[menorIndice] = VetorOrdenadoSelectionSort[i];
                VetorOrdenadoSelectionSort[i] = temp;
                }
            }
        }
    }