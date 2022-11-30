using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Societe_Developpeurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            iDeveloppeurs d = new CplusPlus(
                        new Csharp(
                        new Java(
                        new Web(
                        new Developpeurs("Bianca")))));

            iDeveloppeurs e = new Java(
                        new Python(
                        new Developpeurs("Renan")));

            iDeveloppeurs f = new Csharp(
                        new Web(
                        new Developpeurs("Claire")));

            iDeveloppeurs g = new CplusPlus(
                        new Csharp(
                        new Developpeurs("Brian")));

            iDeveloppeurs h = new Csharp(
                        new Developpeurs("Adam"));

            Console.WriteLine("Nom: " + d.getNom());
            Console.WriteLine("Competences: " + d.getCompetence());
            Console.WriteLine();

            Console.WriteLine("Nom: " + e.getNom());
            Console.WriteLine("Competences: " + e.getCompetence());
            Console.WriteLine();

            Console.WriteLine("Nom: " + f.getNom());
            Console.WriteLine("Competences: " + f.getCompetence());
            Console.WriteLine();

            Console.WriteLine("Nom: " + g.getNom());
            Console.WriteLine("Competences: " + g.getCompetence());
            Console.WriteLine();

            Console.WriteLine("Nom: " + h.getNom());
            Console.WriteLine("Competences: " + h.getCompetence());
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
