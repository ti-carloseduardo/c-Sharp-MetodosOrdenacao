using System;

using System.Numerics;


namespace MetodosOrdenacao.Randomizador
    {
    class RandomizadorVetor
        {
        private int[] vetorRandomizado;
        private System.Random random;
        public int MinValue { get; private set; }
        public int MaxValue { get; private set; }

        public int TamanhoVetor => vetorRandomizado?.Length ?? 0; // Propriedade para obter o tamanho do vetor
        public RandomizadorVetor(int[] vetorRandomizado, Random random, int minValue, int maxValue)
            {
            this.vetorRandomizado = vetorRandomizado;
            this.random = random;
            MinValue = minValue;
            MaxValue = maxValue;
            }
        public RandomizadorVetor()
            {
          
            }

        public void LerTamanhoVetor()
            {
            while (true)
                {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Digite a quantidade de números aleatórios (Tamanho vetor): ");
                string entrada = Console.ReadLine();

                if (!int.TryParse(entrada, out int tamVetorInt) || tamVetorInt <= 0)
                    {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro positivo.");
                    Console.ResetColor();
                    continue;
                    }

                random = new System.Random();
                vetorRandomizado = new int[tamVetorInt];


                while (true)
                    {
                    Console.Write("\nDigite o número minValue (será usado no Random): ");
                    if (!int.TryParse(Console.ReadLine(), out int minValueTemp))
                        {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
                        Console.ResetColor();
                        continue;
                        }

                    Console.Write("\nDigite o número maxValue (será usado no Random): ");
                    if (!int.TryParse(Console.ReadLine(), out int maxValueTemp))
                        {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
                        Console.ResetColor();
                        continue;
                        }

                    if (minValueTemp > maxValueTemp)
                        {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Entrada inválida. minValue deve ser menor que maxValue.");
                        Console.ResetColor();
                        continue;
                        }

                    // Agora pode atribuir os valores às propriedades
                    MinValue = minValueTemp;
                    MaxValue = maxValueTemp;

                    break;
                    }

                Console.ResetColor();
                return;
                }
            }
        public void Randomize() 
        { 
            if(vetorRandomizado == null){
                Console.WriteLine("Vetor nao foi inicializado(classe RandomizadorVetor");
                return;
            }
                for (int i = 0; i < vetorRandomizado.Length; i++){ 
                    vetorRandomizado[i] = random.Next(MinValue,MaxValue);//ajustar para quantidade numeros que usuario pedir
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

