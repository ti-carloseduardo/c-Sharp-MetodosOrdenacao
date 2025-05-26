using System;
using System.IO;

namespace MetodosOrdenacao.Arquivos
    {
    class GravaArquivos
        {
        public string TargetPath { get; set; } = @"C:\Users\vboxuser\Documents\projetos\MetodosOrdenacao\Arquivos\";
            //@"C:\Users\Public\Documents\MetodosOrdenacao\Arquivos\";

        public string NomeArquivo { get; set; }
        public int[] Vetor { get; set; }

        public void GravarArquivo(string nomeArquivo, int[] vetor)
            {
            NomeArquivo = nomeArquivo;
            Vetor = vetor;

            try
                {
                string filePath = Path.Combine(TargetPath, NomeArquivo);
                using (StreamWriter writer = new StreamWriter(filePath))
                    {
                    foreach (int num in Vetor)
                        {
                        writer.Write(num);
                        writer.Write(", "); // Adiciona vírgula e espaço entre os números
                        }
                    }
                
                }
            catch (Exception ex)
                {
                Console.WriteLine($"Erro ao gravar o arquivo: {ex.Message}");
                }
            }
        }
    }