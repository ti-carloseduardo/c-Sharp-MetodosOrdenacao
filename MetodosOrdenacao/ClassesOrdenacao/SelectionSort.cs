using System;

namespace MetodosOrdenacao.ClassesOrdenacao
    {
    public class SelectionSort
        {
        public int[] VetorCopia { get; set; }

        public SelectionSort() { }

        public SelectionSort(int[] vetorCopia)
            {
            VetorCopia = vetorCopia;
            }

        public int[] ObterVetorOrdenadoSelectionSort()
            {
            return VetorCopia;
            }

        public void Ordenar()
            {
           // Console.WriteLine("Executando Selection Sort...");

            // Implementação do algoritmo Selection Sort
            int n = VetorCopia.Length;
            for (int i = 0; i < n - 1; i++)
                {
                int menorIndice = i;
                for (int j = i + 1; j < n; j++)
                    {
                    if (VetorCopia[j] < VetorCopia[menorIndice])
                        {
                        menorIndice = j; // Encontra o menor elemento
                        }
                    }
                // Trocar elementos
                int temp = VetorCopia[menorIndice];
                VetorCopia[menorIndice] = VetorCopia[i];
                VetorCopia[i] = temp;
                }
            }
        }
    }