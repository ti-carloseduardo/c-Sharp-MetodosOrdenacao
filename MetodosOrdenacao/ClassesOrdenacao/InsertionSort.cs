using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.Intrinsics.X86;
namespace MetodosOrdenacao.ClassesOrdenacao
    {
    public class InsertionSort
        {
        //public int[] VetorCopia { get; set; }
        public int[] VetorOrdenadoInsertSort { get; set; }

        public InsertionSort() { }

        public InsertionSort(int[] vetorCopia)
            {
            VetorOrdenadoInsertSort = vetorCopia;
            }

        public int[] ObterVetorOrdenadoInsertionSort()
            {
            return VetorOrdenadoInsertSort;
            }

        public void Ordenar()
            {
            // Implementação do algoritmo InsertionSort
            int n = VetorOrdenadoInsertSort.Length;
                for (int i = 1; i < n; i++)
                    {
                    int key = VetorOrdenadoInsertSort[i];
                    int j = i - 1;

                    // Move os elementos maiores para frente
                    while (j >= 0 && VetorOrdenadoInsertSort[j] > key)
                        {
                    VetorOrdenadoInsertSort[j + 1] = VetorOrdenadoInsertSort[j];
                        j--;
                    }
                VetorOrdenadoInsertSort[j + 1] = key;
                }
        }
    }
}