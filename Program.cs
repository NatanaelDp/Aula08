using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08ListasERepeticao
{
    class Program
    {  
        static void Main(string[] args)
        {


            List<string> nomes = new List<string>();

            nomes.Add("Kennedy");
            nomes.Add("Natália");
            nomes.Add("Eduardo");
            nomes.Add("Mirela");


            int quantidade = nomes.Count;

            int contador = 0;
            while (contador<quantidade)
            {
                Console.WriteLine("Nome:" + nomes[contador]);
                contador += 1;
            }







            Console.ReadKey();
        }
               

        void repeticao()
        {
            int contador = 0;

            //Laço de repetição (loop)
            while (contador<50)
            {
                Console.WriteLine("Olá");
               // contador = contador+1;
                contador += 1; //essa é a mais comum de se usar
                //contador++;
            }




        }
        void listas()
        {
            List<string> nomes = new List<string>();

            nomes.Add(" Jonatas");
            nomes.Add(" Natanael");
            nomes.Add(" Bruno");
            

            Console.WriteLine("O primeiro nome é" + nomes[0]);
            Console.WriteLine("O primeiro nome é" + nomes[1]);
            Console.WriteLine("O primeiro nome é" + nomes[2]);
            Console.WriteLine("Digite o seu nome");
            nomes.Add(Console.ReadLine());
            

            nomes.Remove(" Natanael");

            int quantidade =  nomes.Count;
            Console.WriteLine($"Existem {quantidade} de usuários cadastrados");
;           Console.ReadKey();

        }
        void arrays()
        {

            string[] nomes = new string[3];

            nomes[0] = " Kennedy";
            nomes[1] = " Conradito";
            nomes[2] = " Joãozinho";

            Console.WriteLine("O nome da primeira posição é" + nomes[0]);
            Console.WriteLine("O nome da segunda posição é"  + nomes[1]);
            Console.WriteLine("O nome da segunda posição é"  + nomes[2]);



            Console.ReadKey();
        }
    }
}
