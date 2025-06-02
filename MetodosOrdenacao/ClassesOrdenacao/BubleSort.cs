using System;

namespace MetodosOrdenacao.ClassesOrdenacao
    {
    
    public class BubbleSort
        {
       
        public int[] VetorOrdenadoBubbleSort { get; set; }

        
        public BubbleSort(int[] vetorCopia)
            {
            VetorOrdenadoBubbleSort = vetorCopia;
            }
        public int[] ObterVetorOrdenadoBubbleSort()
            {
            return VetorOrdenadoBubbleSort;
            }
        public BubbleSort() { }
                      
        public void Ordenar()
            {
            //Console.WriteLine("Executando Bubble Sort...");

            // Implementação do algoritmo Bubble Sort
            int n = VetorOrdenadoBubbleSort.Length;
            for (int i = 0; i < n - 1; i++)
                {
                for (int j = 0; j < n - i - 1; j++)
                    {
                    if (VetorOrdenadoBubbleSort[j] > VetorOrdenadoBubbleSort[j + 1])
                        {
                        // Trocar elementos
                        int temp = VetorOrdenadoBubbleSort[j];
                        VetorOrdenadoBubbleSort[j] = VetorOrdenadoBubbleSort[j + 1];
                        VetorOrdenadoBubbleSort[j + 1] = temp;
                    }
                }
            }
        }
    }
}


   

