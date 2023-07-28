using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RPG_.Impostor.src.entidades;


namespace RPG_.Impostor.src
{

    class Program
    {
         static void Main(string[] args)
        {
            Sindrome sindrome = new Sindrome("impostor", 50);
            Estima  estima = new Estima ("Alto estima", 50);

            Console.WriteLine(sindrome.Attack());
            Console.WriteLine(estima.Attack(7));
        }
    }
}







