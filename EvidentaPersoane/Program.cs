using System;

namespace EvidentaPersoane
{
    partial class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Last name:");
            string last_name = Console.ReadLine();
            Console.WriteLine("First name:");
            string first_name = Console.ReadLine();
            Console.WriteLine("Age");
            int age = int.Parse(Console.ReadLine());
            if (age < 12)
            { Copil c = new Copil(last_name, first_name, age);
                Console.WriteLine(c.Buletin().ToString());
            }
            else
                if (age >= 12 && age < 18)
            { Adolescent c = new Adolescent(last_name, first_name, age);
                Console.WriteLine(c.Buletin().ToString());
            }
            else
            {
                Console.WriteLine("Casatorie:");
                string raspuns;
                bool casatorie;
                raspuns = Console.ReadLine();
                if (raspuns.ToLower() == "da")
                {
                    casatorie = true;
                }
                else
                    casatorie = false;

                Adult c = new Adult(last_name, first_name, age, casatorie);
              Console.WriteLine(c.Casatorie.ToString()); 
            }
          
        }
    }
}
