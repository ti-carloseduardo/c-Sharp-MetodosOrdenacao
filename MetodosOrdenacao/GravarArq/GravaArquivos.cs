using System;
using System.IO;

namespace MetodosOrdenacao.Arquivos
    {
    class GravaArquivos
        {
        public string TargetPath { get; private set; } =
        @"C:\Users\vboxuser\Documents\projetos\MetodosOrdenacao\MetodosOrdenacao\DadosOrdenacao"; 
        // Caminho padrão
                                                           
        public string NomeArquivo { get; set; }
        public int[] VetorRandomizado { get; set; }
        public int[] VetorOrdenado { get; set; }
        
       

        public GravaArquivos(string nomeArquivo, int[] vetorRandomizado, int[] vetorOrdenado)
            {
  
            VetorRandomizado = vetorRandomizado;
            VetorOrdenado = vetorOrdenado;
            NomeArquivo = nomeArquivo;
            }
        public GravaArquivos()
            {
            VetorOrdenado = [];
            VetorRandomizado = [];
            }


        public void GravarVetorRandomizado(int[] vetorRandomizado, int minValue, int maxValue)
            {
            try
                {
                Console.WriteLine("Digite o nome do arquivo para gravar o vetor randomizado (sem extensão): ");
                string nomeArquivo = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(nomeArquivo))
                    {
                    Console.WriteLine("Nome do arquivo inválido. Usando nome padrão 'VetorRandomizado.txt'.");
                    nomeArquivo = "VetorRandomizado.txt";
                    }
                else
                    {
                    nomeArquivo += ".txt";
                    }

                string filePath = Path.Combine(TargetPath, nomeArquivo);

                using (StreamWriter writer = new StreamWriter(filePath))
                    {
                    writer.WriteLine("=== Informações do Vetor ===");
                    writer.WriteLine($"Tamanho do Vetor: {vetorRandomizado.Length}");
                    writer.WriteLine($"Limites: min = {minValue}, max = {maxValue}");
                    writer.WriteLine("=== Vetor Randomizado ===");
                    writer.WriteLine(string.Join(", ", vetorRandomizado));
                    }

                Console.WriteLine($"Arquivo '{filePath}' criado com sucesso!");
                }
            catch (IOException ioEx)
                {
                Console.WriteLine($"Erro de I/O ao gravar o arquivo: {ioEx.Message}");
                }
            catch (Exception ex)
                {
                Console.WriteLine($"Erro inesperado ao gravar o arquivo: {ex.Message}");
                }
            }

        public void GravarVetorOrdenado(string algoritmo, int[] vetorOrdenado, double tempoExecucao, int minValue, int maxValue)
            {
            string nomeArquivo = $"{algoritmo}_VetorOrdenado.txt"; // Nome do arquivo com o algoritmo utilizado
            string filePath = Path.Combine(TargetPath, nomeArquivo);

            using (StreamWriter writer = new StreamWriter(filePath))
                {
                writer.WriteLine("=== Informações do Vetor ===");
                writer.WriteLine($"Algoritmo: {algoritmo}");
                writer.WriteLine($"Tamanho do Vetor: {vetorOrdenado.Length}");
                writer.WriteLine($"Limites: min = {minValue}, max = {maxValue}");
                writer.WriteLine($"Tempo de execução: {tempoExecucao} segundos");
                writer.WriteLine("=== Vetor Ordenado ===");
                writer.WriteLine(string.Join(", ", vetorOrdenado));
                }

            // Exibe nome e o endereço completo do arquivo
            Console.WriteLine($"Arquivo: '{nomeArquivo}' criado com sucesso!");
            Console.WriteLine($"Endereço: '{filePath}'");
            }
        }
    }