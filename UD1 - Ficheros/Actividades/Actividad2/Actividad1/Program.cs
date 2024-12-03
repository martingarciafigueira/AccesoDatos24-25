namespace Actividad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcion = string.Empty;
            string textoIntroducido;
            bool continuaInsertandoFrases = true;

            while (opcion != "C")
            {
                //Obtenemos la opcion que quiere el usuario
                Console.WriteLine("Introduce una opción, por favor: ");
                Console.WriteLine("A) Escribir en un fichero ");
                Console.WriteLine("B) Leer de un fichero ");
                Console.WriteLine("C) Salir ");

                opcion = Console.ReadLine();

                if (opcion == "A")
                {
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
                else if (opcion == "B")
                {
                    int lineas = 0;
                    Console.Write("¿Cuántas líneas quieres leer? ");
                    int.TryParse(Console.ReadLine(), out lineas);

                    using (StreamReader fichLectura = new StreamReader("Log_Fichero.txt"))
                    {
                        string linea;
                        for (int i = 0; i < lineas; i++)
                        {
                            linea = fichLectura.ReadLine();
                            if (linea is not null)
                            {
                                Console.WriteLine(linea);
                            }
                        }
                    }
                }
                else
                {
                    break;
                }
                Console.ReadKey();
                Console.Clear();
            }
            Console.ReadKey();
        }
    }
}
