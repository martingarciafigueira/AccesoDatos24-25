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

                    string nombreFichero;
                    Console.WriteLine("Dame el nombre del fichero");
                    nombreFichero = Console.ReadLine();

                    using (StreamReader fichLectura = new StreamReader(nombreFichero))
                    {
                        string linea;
                        int contador = 0;

                        while (!fichLectura.EndOfStream)
                        {
                            linea = fichLectura.ReadLine();
                            if (linea is not null)
                            {
                                Console.WriteLine(linea);
                            }
                            if (contador == 10)
                            {
                                contador = 0;
                                Console.ReadKey();
                            }
                            contador++;
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
