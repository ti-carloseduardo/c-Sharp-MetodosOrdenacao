using System;

namespace MetodosOrdenacao.ClassesOrdenacao
{
    internal class QuickSort
    {
        public int[] VetorCopia { get; set; }
        public QuickSort() { }
        public QuickSort(int[] vetorCopia)
            {
            VetorCopia = vetorCopia;
            }       
       public int[] ObterVetorOrdenadoQuickSort()
       {
            return VetorCopia;
       }
        public void Ordenar()
            {
            QuickSortOrd(VetorCopia, 0, VetorCopia.Length - 1);
            }

        private void QuickSortOrd(int[] array, int esquerda, int direita)
            {
            if (esquerda < direita)
                {
                int indicePivo = Particionar(array, esquerda, direita);
                QuickSortOrd(array, esquerda, indicePivo - 1);
                QuickSortOrd(array, indicePivo + 1, direita);
                }
            }

        private int Particionar(int[] array, int esquerda, int direita)
            {
            int pivo = array[direita];
            int i = esquerda - 1;

            for (int j = esquerda; j < direita; j++)
                {
                if (array[j] <= pivo)
                    {
                    i++;
                    Trocar(array, i, j);
                    }
                }

            Trocar(array, i + 1, direita);
            return i + 1;
            }

        private void Trocar(int[] array, int i, int j)
            {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
            }


        }
    }