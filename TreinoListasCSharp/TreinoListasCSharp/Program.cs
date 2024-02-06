using System;

namespace TreinoListasCSharp
{
    class Program
    {
        public class Aluno
        {
            public double Nota { get; set; }
            public string Nome { get; set; }
            public int Idade { get; set; }

            public Aluno(string nome, int idade, double nota)
            {
                this.Nome = nome;
                this.Idade = idade;
                this.Nota = nota;
            }
        }

        public static List<Aluno> alunos = new()
        {
            new Aluno("João", 32, 9.0),
            new Aluno("Maria", 21, 8.0),
            new Aluno("Eduardo", 19, 4.5),
            new Aluno("Gabriel", 25, 3.5),
            new Aluno("Ana", 30, 2.5),
        };


        // Função que teste modificador params
        public static double Soma(params double[] vetor) {
            double soma = 0;
            foreach (double valor in vetor)
            {
                soma += valor;
            }
            Console.WriteLine(vetor[vetor.Length - 2]);
            return soma;
        }

        static void Main(string[] args)
        {
            // Treinando Listas
            double mediaNotas = alunos.Average(a => a.Nota);
            Console.WriteLine(mediaNotas);

            List<Aluno> aprovados = alunos.Where(aluno => aluno.Nota >= 6.0).ToList();
            Console.WriteLine("Aprovados");
            foreach (Aluno aluno in aprovados)
            {
                Console.WriteLine($"{aluno.Nome}, {aluno.Nota}, {aluno.Idade}");
            }

            List<Aluno> reprovados = alunos.Where(aluno => aluno.Nota < 6.0).ToList();
            Console.WriteLine("Reprovados");
            foreach (Aluno aluno in reprovados)
            {
                Console.WriteLine($"{aluno.Nome}, {aluno.Nota}, {aluno.Idade}");
            }

            List<Aluno> ordemAlfabetica = alunos.OrderBy(aluno => aluno.Nome).ToList();
            Console.WriteLine($"Alunos ordenados por ordem alfabética:");
            foreach (Aluno aluno in ordemAlfabetica)
            {
                Console.WriteLine($"{aluno.Nome}, {aluno.Nota}, {aluno.Idade}");
            }

            int indexEduardo = alunos.FindIndex(aluno => aluno.Nome == "Eduardo");
            Console.WriteLine(alunos[indexEduardo].Nome);

            Aluno? alunoExistente = alunos.Find(aluno => aluno.Nome == "Mariaa");
            if (alunoExistente != null)
            {
                Console.WriteLine(alunoExistente.Nome);
            }
            else Console.WriteLine("Aluno não encontrado");

            // Treinando Modificador Params

            Console.WriteLine(Soma(1, 5, 9, 2023, 2024));

            
        }
    }
}

