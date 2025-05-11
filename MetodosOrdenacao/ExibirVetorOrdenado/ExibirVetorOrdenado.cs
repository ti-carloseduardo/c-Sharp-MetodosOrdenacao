/* classe responsavel por imprimir o vetor ordenado conforme metodo escolhido pelo usuario. */

using System.Text;

namespace MetodosOrdenacao.ExibirVetorOrdenado
    {
    class ExibirVetorOrd
        {
        public int[] VetorOrdenado { get; set; }

        public ExibirVetorOrd()
            {

            }
        public ExibirVetorOrd(int[] vetorOrdenado)
            {
            VetorOrdenado = vetorOrdenado;
            }
        public string ExibirVetorOrdem()
            {
            if (VetorOrdenado == null)
                {
                Console.WriteLine("Erro: vetorOrdenado não foi inicializado.");
                return "Erro: vetorOrdenado não foi inicializado.";
                }

            int count = 1;
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < VetorOrdenado.Length; i++)
                {
              //  Console.ForegroundColor = ConsoleColor.DarkGreen;
                //Console.Write(VetorOrdenado[i] + " "); //imprime numerico
                output.Append(VetorOrdenado[i] + " ");

                if (count >= 10)
                    {
                    //Console.WriteLine();//imprime numerico
                    output.AppendLine();
                    count = 0;
                    }
                count++;
                }

            //Console.ResetColor();
            Console.WriteLine();
            return output.ToString(); // Retorna os valores formatados
            }//metodo exibir vetor em Ordem. 
        }
    }


        
