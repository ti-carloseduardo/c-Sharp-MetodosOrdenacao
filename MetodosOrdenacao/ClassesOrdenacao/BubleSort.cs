using System;

namespace MetodosOrdenacao.ClassesOrdenacao
    {
    public class BubbleSort
        {
        public int[] VetorCopia { get; set; }
        public BubbleSort()
            {

            }

        public BubbleSort(int[] vetorCopia)
            {
            VetorCopia = vetorCopia;
            }

        public int[] ObterVetorOrdenadoBubbleSort()
            {
            return VetorCopia;
            }

        public void Ordenar()
            {
            //Console.WriteLine("Executando Bubble Sort...");

            // Implementação do algoritmo Bubble Sort
            int n = VetorCopia.Length;
            for (int i = 0; i < n - 1; i++)
                {
                for (int j = 0; j < n - i - 1; j++)
                    {
                    if (VetorCopia[j] > VetorCopia[j + 1])
                        {
                        // Trocar elementos
                        int temp = VetorCopia[j];
                        VetorCopia[j] = VetorCopia[j + 1];
                        VetorCopia[j + 1] = temp;
                    }
                }
            }
        }
    }
}


   

