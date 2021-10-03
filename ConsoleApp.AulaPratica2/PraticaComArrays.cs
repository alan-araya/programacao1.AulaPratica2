using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.AulaPratica2
{
    public class PraticaComArrays
    {
        public void Exercicio1()
        {
            //inicializa um array com 100.000 posições
            int[] arrayIntLinear = new int[100000];

            //populas as posições com seu valor de indice linearmente
            for (int i = 0; i < 100000; i++)
            {
                arrayIntLinear[i] = i;
            }

            //declara uma matriz 100x100
            int[,] matriz = new int[100,100];//Array.CreateInstance(typeof(int),new int[2] {100,100})
            var rand = new Random();

            //popula a matriz com valores randomicos de 1 a 300.000
            for (int i = 0; i < 100; i++) //100 max de linhas
            {
                for (int k = 0; k < 100; k++) //100 max de colunas
                {
                    matriz[i, k] = rand.Next(1, 300000);
                }
            }

            int countMatch = 0;
            for (int i = 0; i < matriz.GetUpperBound(0); i++) //GetUpperBound(0) retorna o max length da primeira dimensão da matriz (linhas)
            {
                for (int k = 0; k < matriz.GetUpperBound(1); k++) //GetUpperBound(1) retorna o max length da segunda dimensão da matriz (colunas)
                {
                    var valorNaMatriz = (int)matriz.GetValue(i, k); //GetValue é um método que retorna Object

                    for (int x = 0; x < arrayIntLinear.Length; x++)
                    {
                        if (arrayIntLinear[x] == valorNaMatriz)
                        {
                            countMatch++;
                        }
                    }
                }
            }

            Console.WriteLine($"Houveram {countMatch} entre os valores randômicos da matriz e do array linear!");

        }

        public void Exercicio2()
        {
            Console.WriteLine("****************************************");

            //declarando arrays de base para o exercicio
            char[] alfabetoArray = new char[] {'A','B','C','D','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z' };
            char[] arrayCharAleatorio = new char[100];
            char[] arrayFinal = new char[100];
            Random rand = new Random();

            //populando o array aleatorio
            for (int i = 0; i < 100; i++)
            {
                arrayCharAleatorio[i] = alfabetoArray[rand.Next(0,alfabetoArray.Length)];
            }

            int posInicial = 0;
            int posFinal = 0;

            Console.WriteLine("Informe um valor inicial para recortar do array original:");
            posInicial = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe um valor final (maior que valor anterior) para recortar do array original:");
            posFinal = int.Parse(Console.ReadLine());

            //recorte do array, conforme posicoes
            for (int i = posInicial; i < posFinal; i++)
            {
                arrayFinal[i] = arrayCharAleatorio[i];
            }

            //string final inicializada a partir do array
            var stringFinal = new string(arrayFinal);

            Console.WriteLine("A string final ficou assim:");
            Console.WriteLine(stringFinal);
        }
    }
}
