using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.AulaPratica2
{
    public class PraticaComFilasBoxing
    {
        public void ExercicioBoxingFilas()
        {
            //inicializando listas
            var filaGenerics = new FilaGenerics<Animal>(10);
            var filaObject = new FilaObject(10);

            //instância das classes filhas
            Cachorro cachorro1 = new Cachorro();
            Gato gato1 = new Gato();

            //instânica com box para tipo "pai"
            Animal cachorro2 = new Cachorro();
            Animal gato2 = new Gato();

            //instância com box para interface 
            IBarulhento cachorro3 = new Cachorro();
            IBarulhento gato3 = new Gato();

            //Add na fila
            filaGenerics.Enqueue(cachorro1);
            filaGenerics.Enqueue(gato1);
            filaGenerics.Enqueue(cachorro2);
            filaGenerics.Enqueue(gato2);
            filaGenerics.Enqueue((Animal)cachorro3);
            filaGenerics.Enqueue((Animal)gato3);

            filaObject.Enqueue(cachorro1);
            filaObject.Enqueue(gato1);
            filaObject.Enqueue(cachorro2);
            filaObject.Enqueue(gato2);
            filaObject.Enqueue(cachorro3);
            filaObject.Enqueue(gato3);

            //filaObject.Enqueue(1000);


            //Remove da fila
            try
            {
                while (filaGenerics.Count > 0)
                {
                    IBarulhento animal = filaGenerics.Dequeue();
                    Console.WriteLine($"Meu type é {animal.GetType().BaseType.Name}. Sou um {animal.GetType().Name} e emito o seguinte som: {animal.EmitirSom()}");
                }

                while (filaObject.Count > 0)
                {
                    IBarulhento animal = (Animal)filaObject.Dequeue();
                    Console.WriteLine($"Meu type é {animal.GetType().BaseType.Name}. Sou um {animal.GetType().Name} e emito o seguinte som: {animal.EmitirSom()}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao realizar unboxing de um type.Erro: {ex.Message}");
            }

        }
    }
}
