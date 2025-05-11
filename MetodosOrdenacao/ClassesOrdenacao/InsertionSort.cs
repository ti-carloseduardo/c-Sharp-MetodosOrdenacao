using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.Intrinsics.X86;
namespace MetodosOrdenacao.ClassesOrdenacao
    {
    public class InsertionSort
        {
        public int[] VetorCopia { get; set; }

        public InsertionSort() { }

        public InsertionSort(int[] vetorCopia)
            {
            VetorCopia = vetorCopia;
            }

        public int[] ObterVetorOrdenadoInsertionSort()
            {
            return VetorCopia;
            }

        public void Ordenar()
            {
            //Console.WriteLine("Executando InsertionSort...");
            // Implementação do algoritmo InsertionSort
            int n = VetorCopia.Length;
                for (int i = 1; i < n; i++)
                    {
                    int key = VetorCopia[i];
                    int j = i - 1;

                    // Move os elementos maiores para frente
                    while (j >= 0 && VetorCopia[j] > key)
                        {
                    VetorCopia[j + 1] = VetorCopia[j];
                        j--;
                    }
                VetorCopia[j + 1] = key;
                }
        }
    }
}