using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_14_10
{

    //ToUpper() : Converte todos os caracteres da string para maiúsculos.
//ToLower(): Converte todos os caracteres da string para minúsculos.

    // Ctrl + K e Ctrl+D arruma o codigo selecionado.
    //CTRL+K e Ctrl+C deixa em comentário
    // Console.Clear();limpa a tela
    //Console.ReadKey(); dar pause no programa para a pessoa ler. congela a tela
    // menu com switch case
    // && é "ambos" e OU é  "||"


    internal class Program
    {
        static void Main(string[] args)
        {

            string opcao;
            Lista lista = new Lista();

            //Criando um manual com switch case
            do
            {


                Console.WriteLine("Escolha uma operação:\n");
                Console.WriteLine("1 - Média Aritmética");
                Console.WriteLine("2 - Ordenação Alfabética");
                Console.WriteLine("3 - Números Repetidos");
                Console.WriteLine("4 - Anagrama");

                int escolha = Convert.ToInt32(Console.ReadLine());

                switch (escolha)
                {
                    // LISTA 
                    case 1:
                        lista.Aritmetica();
                        break;

                        case 2:
                        lista.Ordenacao();
                        break;

                        case 3:
                        lista.Repetidos();
                        break;

                    case 4:
                        lista.Anagrama();
                        break;

                    default:

                        Console.WriteLine("Operação inválida.");
                        break;


                }

                Console.WriteLine("Deseja continuar no programa (S/N)");


                opcao = Console.ReadLine().ToUpper(); // to upper serve para ele ler o que o usuário digita independente de estar maiúsculo ou minúsculo




            } while (opcao == "S");

        }

       
    }
}
