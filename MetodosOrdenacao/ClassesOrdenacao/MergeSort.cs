using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosOrdenacao.ClassesOrdenacao
{
    internal class MergeSort
        {
        //public int[] VetorCopia { get; set; }
        public int[] VetorOrdenadoMergeSort { get;set; }
            
        public MergeSort() { }
        public MergeSort(int[] vetorCopia)
        {
            VetorOrdenadoMergeSort = vetorCopia;
        }
        public int[] ObterVetorOrdenadoMergeSort()
            {
            return VetorOrdenadoMergeSort;
            }
        public void Ordenar()
            {
            MergeSortOrd(VetorOrdenadoMergeSort, 0, VetorOrdenadoMergeSort.Length - 1);
            }

        private void MergeSortOrd(int[] array, int esquerda, int direita)
            {
            if (esquerda < direita)
                {
                int meio = (esquerda + direita) / 2;

                MergeSortOrd(array, esquerda, meio);
                MergeSortOrd(array, meio + 1, direita);
                Mesclar(array, esquerda, meio, direita);
                }
            }

        private void Mesclar(int[] array, int esquerda, int meio, int direita)
            {
            int[] temp = new int[direita - esquerda + 1];
            int i = esquerda, j = meio + 1, k = 0;

            while (i <= meio && j <= direita)
                {
                if (array[i] <= array[j])
                    temp[k++] = array[i++];
                else
                    temp[k++] = array[j++];
                }

            while (i <= meio)
                temp[k++] = array[i++];

            while (j <= direita)
                temp[k++] = array[j++];

            for (k = 0, i = esquerda; i <= direita; i++, k++)
                array[i] = temp[k];
            }

        }

}
