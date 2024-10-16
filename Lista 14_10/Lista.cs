using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_14_10
{
    internal class Lista
    {

        public  void Inversao()
        {

            int[] numeros = new int[10];

            Console.WriteLine("Digite 10 números,pressione Enter para cada número");

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());
            }




        }
        public void Anagrama()//4
        {
            // char -- para representar caracteres individuais,seja núm,letra,simbolo...
            //ToUpper() : Converte todos os caracteres da string para maiúsculos.
            //ToLower(): Converte todos os caracteres da string para minúsculos.

            char[] letras = new char[5];
            string palavra;
            for (int i = 0; i < letras.Length; i++)
            {
                Console.Write($"Digite a {i + 1}° letra : ");
                letras[i] = Convert.ToChar((Console.ReadLine()).ToLower());
            }

            Console.WriteLine("Digite agora uma palavra com 5 letras");
            palavra = Console.ReadLine().ToLower();

            char[] palavraArray = palavra.ToCharArray();
            //Ordena os nomes em ordem alfabética
            Array.Sort(letras);
            Array.Sort(palavraArray);
            //SequenceEqual compara os dois arrays ordenados. 
            bool saoAnagramas = letras.SequenceEqual(palavraArray);

            Console.WriteLine(saoAnagramas ? "São anagramas" : "Não são anagramas");


        }

        public void Repetidos()//3
        {
            int[] numeros = new int[10];

            Console.WriteLine("Digite 10 números,pressione Enter para cada número");

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine()); 
            }

            bool temRepetidos = false;
            for (int i = 0; i < numeros.Length - 1; i++)
            {
                for (int j = i + 1; j < numeros.Length; j++)
                {
                    if (numeros[i] == numeros[j])
                    {
                        temRepetidos = true;
                        break;
                    }
                }
                
            }

            if (temRepetidos)
            {
                Console.WriteLine("Há números repetidos no vetor.");
            }
            else
            {
                Console.WriteLine("Não há números repetidos no vetor.");
            }

        }

        public void Ordenacao()//2
        {
            string[] nomes = new string[5]; // Vetor de strings

            Console.WriteLine("Digite 5 nomes, pressione Enter para cada nome");
            for (int i = 0; i < nomes.Length; i++)
            {
                nomes[i] = Console.ReadLine();
            }

            // Ordena os nomes em ordem alfabética
            //Array.Sort(nomes);

            // realizar uma ordenação ignorando Letras Maiúsculas ou Minúsculas,  usar StringComparer.OrdinalIgnoreCase com o método Array.Sort.
            Array.Sort(nomes, StringComparer.OrdinalIgnoreCase);

            Console.WriteLine("\nNomes em ordem alfabética:");
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }



        public void Aritmetica()//1
        {
            double[] numeros = new double[10]; // vetor double
            double media, soma = 0;

            Console.WriteLine("Digite 10 números,pressione Enter para cada número");

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = double.Parse(Console.ReadLine());

               media=  soma += numeros[i]/ 10;
                
            }
            Console.WriteLine("Resultado da média "+soma);
            Console.ReadKey();
        }
    }
}
