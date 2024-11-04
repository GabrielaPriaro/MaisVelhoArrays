//Utilizando Arrays:
//Problema "mais_velho"
//Fazer um programa para ler um conjunto de nomes de pessoas e suas respectivas idades. Os nomes
//devem ser armazenados em um vetor, e as idades em um outro vetor. Depois, mostrar na tela o nome da pessoa mais velha. 

namespace MaisVelhoArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, idadePessoaMaisVelha = 0, posicaoPessoaMaisVelha = 0;

            Console.Write("Quantas pessoas voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            string[] nome = new string[n];
            int[] idade = new int[n];   

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Dados da {i+1}a pessoa:");
                Console.Write("Nome: ");
                nome[i] = Console.ReadLine();
                Console.Write("Idade: ");
                idade[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                if (idade[i] > idadePessoaMaisVelha)
                {
                    idadePessoaMaisVelha = idade[i];
                    posicaoPessoaMaisVelha = i;
                }
            }

            Console.WriteLine($"PESSOA MAIS VELHA: {nome[posicaoPessoaMaisVelha]}");
        }
    }
}
