using System;
using System.Numerics;


namespace MetodosOrdenacao.Randomizador
    {
    class RandomizadorVetor
        {
        private int[] vetorRandomizado;
        private int minValue;
        private int maxValue;
        private System.Random random;

        
       

        public void LerTamanhoVetor()
            {
            while (true)
                {
                Console.ForegroundColor = ConsoleColor.Green; // Define a cor do texto para verde
                Console.Write("Digite a quantidade de numeros aleatorios(tamanho vetor): ");
                string entrada = Console.ReadLine();

                Console.Write("\nDigite numero minValue sera usado no Random: ");
                if (!int.TryParse(Console.ReadLine(), out this.minValue))
                    {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
                    return;
                    }



                Console.Write("\nDigite numero maxValue sera usando no Random : ");
                if (!int.TryParse(Console.ReadLine(), out this.maxValue))
                   {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
                    return;
                    }
                Console.ResetColor(); // Restaura a cor padrão do console


                if (minValue > maxValue  )
                    {
                    Console.ForegroundColor = ConsoleColor.Red; // Define a cor do texto para vermelho
                    Console.WriteLine("Entrada inválida. Por favor, digite um número minimo menor que maximo.");
                    Console.ResetColor(); // Restaura a cor padrão do console
                }
                Console.ResetColor(); // Restaura a cor padrão do console

                if (int.TryParse(entrada, out int tamVetorInt))
                    {
                    random = new System.Random();
                    vetorRandomizado = new int[tamVetorInt];//criando as instancia
                                                            //passando o atributo com tamanho vetor
                    return;
                    }
                else
                    {
                    Console.ForegroundColor = ConsoleColor.Red; // Define a cor do texto para vermelho
                    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
                    Console.ResetColor(); // Restaura a cor padrão do console
                    }
                }
            }

        public void Randomize() 
        { 
            if(vetorRandomizado == null){
                Console.WriteLine("Vetor nao foi inicializado(classe RandomizadorVetor");
                return;
            }
                for (int i = 0; i < vetorRandomizado.Length; i++){ 
                    vetorRandomizado[i] = random.Next(minValue,maxValue);//ajustar para quantidade numeros que usuario pedir
                }
        }

        public int[] ObterCopiaVetorRandomizado()//passando uma copia do vetor original
        {return vetorRandomizado.ToArray();}

        public void ExibirVetor()
        {
            int count = 1;
            Console.ForegroundColor = ConsoleColor.Green; // Define a cor do texto para vermelho
            Console.WriteLine("");
            Console.WriteLine("\n EXIBINDO VETOR RANDOMIZADO: ");
            Console.ResetColor(); // Restaura a cor padrão do console
            for (int i = 0; i < vetorRandomizado.Length; i++) {
                Console.ForegroundColor = ConsoleColor.DarkGreen; // Define a cor do texto para vermelho
                Console.Write(vetorRandomizado[i] + " ");
                if (count >= 10)
                {
                    Console.WriteLine();
                    count = 0;
                }
            count++;
            }
            Console.ResetColor(); // Restaura a cor padrão do console
        }

    }
        
}

