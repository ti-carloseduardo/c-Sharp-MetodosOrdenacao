using System;


namespace MetodosOrdenacao.Randomizador
    {
    class RandomizadorVetor
        {
        private int[] vetor;
        private System.Random random;

        public RandomizadorVetor(int tamanho)
        {
            if (tamanho <= 0)
                { 
                    Console.WriteLine(" Digite positivo maior que zero.");
                    return;
                }
                vetor = new int[tamanho];//criando as instancias
            random = new System.Random();
        }
        
        public void Randomize() 
        { 
            if(vetor == null){
                Console.WriteLine("Vetor nao foi inicializado(classeRandomizadorVetor");
                return;
            }
                for (int i = 0; i < vetor.Length; i++){ 
                    vetor[i] = random.Next(100);//ajustar para quantidade numeros que usuario pedir
                }
        }
        public void ExebirVetor()
        {
            Console.WriteLine("vetor randomizado");
            for (int i = 0; i < vetor.Length; i++) {
                Console.WriteLine(vetor[i] + " ");
                }
            Console.WriteLine();
        }
        
    }
}
