using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();
            Persona p2 = new Persona();
            Persona p3 = new Persona();
            p1.Nome = Console.ReadLine();
            p1.Eta = int.Parse(Console.ReadLine());
            p2.Nome = Console.ReadLine();
            p2.Eta = int.Parse(Console.ReadLine());
            p3.Nome = Console.ReadLine();
            p3.Eta = int.Parse(Console.ReadLine());
            List<Persona> personas = new List<Persona>();
            personas.Add(p1);
            personas.Add(p2);
            personas.Add(p3);
            for(int i = 0; i < personas.Count; i++)
            {
                if (personas[i].Eta >= 18)
                    Console.WriteLine(personas[i].Nome);
                else
                    continue;
            }
            Console.ReadLine();
        }
    }
}
