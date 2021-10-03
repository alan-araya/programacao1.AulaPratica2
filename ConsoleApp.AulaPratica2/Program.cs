using System;

namespace ConsoleApp.AulaPratica2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aula Prática de C# 2!");
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Arrays");
            Console.WriteLine("---------------------------------------");

            PraticaComArrays praticaComArrays = new PraticaComArrays();
            praticaComArrays.Exercicio1();
            praticaComArrays.Exercicio2();

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Boxing/Unboxing/Casting com listas");
            Console.WriteLine("---------------------------------------");
            PraticaComFilasBoxing praticaComFilasBoxing = new PraticaComFilasBoxing();
            praticaComFilasBoxing.ExercicioBoxingFilas();

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Manipulando listas");
            Console.WriteLine("---------------------------------------");
            PraticaManipulandoCollections manipulandoCollections = new PraticaManipulandoCollections();
            manipulandoCollections.Exercicio1();

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Extension Methods");
            Console.WriteLine("---------------------------------------");
            PraticaExtensionMethods extensionMethods = new PraticaExtensionMethods();
            extensionMethods.Exercicio1();
        }
    }
}
