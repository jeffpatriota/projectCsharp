using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
//            int j = 0;
//            while (j < 100) {
//                Console.WriteLine("Bom Dia");
//                j += 10;
//            }

//            for (int i = 0; i < 10; i++)
//            {
//                Console.WriteLine(i);
//            }

//            string[] nomes = { "Jefferson", "Jessica", "Selma", "Diego", "Silvia" };
//            foreach (string nome in nomes)
//            {
//                Console.WriteLine(nome);
//            }
//           while (true)
//            {
//                Console.WriteLine("Pressione C para continue");
//                Console.WriteLine("Pressione B para break");
//                string tecla = Console.ReadKey(true).KeyChar.ToString();
//                if (tecla == "c")
//                {
//                    continue;
//                }
//                else if (tecla == "b")
//                {
//                    break;
//                }
//                else 
//                {
//                    Console.WriteLine("Tecla desconhecida");
//                }
//                Console.WriteLine("Pressione qualquer tecla para continuar");
//                Console.ReadKey(true);  
//                Console.Clear();
//            }
//                Console.WriteLine("Pressione qualquer tecla para sair");
//                Console.ReadKey();

            while (true)
            {
                Console.WriteLine("Digite S para sair ou um número para calcular o fatorial");
                string opcao = Console.ReadLine();
                if (opcao == "s" || opcao == "S")
                    break;
                else
                {
                    int valor = Convert.ToInt32(opcao);
                    if (valor == 0)
                        Console.WriteLine("0! = 1");
                    else if (valor < 0)
                        Console.WriteLine("Impossível calcular o fatorial de um número negativo");
                    else
                    {
                        int resultado = 1;
                        Console.WriteLine(valor + " ! = " + resultado);
                        for (int i = valor; i > 0; i --)
                        {
                            resultado *= i;
                        if (i == 1)
                            {
                            Console.WriteLine(i + " = " + resultado);
                            Console.WriteLine();

                            }
                        else
                            {
                                Console.WriteLine(i + "x");
                            }
                        }
                       
                        
                    }
                    Console.WriteLine("Pressione qualquer tecla para finalizar");
                    Console.ReadKey();  
                }
            }


      }

       

       
   }

}
