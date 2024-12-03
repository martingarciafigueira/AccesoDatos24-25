namespace Actividad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textoIntroducido;
            bool continuaInsertandoFrases = true;

            using (StreamWriter fichero = new StreamWriter("Log_Fichero.txt"))
            {
                while (continuaInsertandoFrases)
                {
                    Console.Write("Introduce una frase, por favor: ");
                    textoIntroducido = Console.ReadLine();

                    if (textoIntroducido == "END")
                    {
                        continuaInsertandoFrases = false;
                        break;
                    }

                    fichero.WriteLine(textoIntroducido);
                }
            }
        }
    }
}
