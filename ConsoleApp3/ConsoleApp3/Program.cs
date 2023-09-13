using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] n = { "pedro", "gui", "renon","richard", "erick", "samuel", "lucas", "rafa", "edislon", "monique" };
            string[] p = { "Paulo", "Ricardo", "vagner" };
            int[] idade = { 17, 18, 25, 17, 17, 19, 18, 18, 23, 29 };
            int[] idadep = { 25,40,42};

            float sum = 0;

            Array.ForEach(idade, i => sum += i);
            sum = sum / idade.Length;
                     
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Professores");
            Console.WriteLine("\n");

            for (int i = 0; i < n.Length && i < idade.Length; i++) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(n[i]);
                Console.WriteLine(idade[i]);
            }
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Professores");
            Console.WriteLine("\n");

            for (int i = 0;i < p.Length && i < idadep.Length; i++) 
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(p[i]);
                Console.WriteLine(idadep[i]);
            }

            Console.ForegroundColor= ConsoleColor.Gray;
            Console.WriteLine("\n");
            Console.WriteLine("Idade media dos alunos");
            Console.WriteLine(sum);




            Console.ReadKey();

        }
    }
}
