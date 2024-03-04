namespace EJER_ANIMAL
{
    internal class Program
    {
        static void Main()
        {            
            Perro miPerro = new Perro();
            Gato miGato = new Gato();

            // Método HacerSonido para cada animal
            Console.WriteLine("Sonidos de los animales:");
            miPerro.HacerSonido();
            miGato.HacerSonido();
        }
    }
}
