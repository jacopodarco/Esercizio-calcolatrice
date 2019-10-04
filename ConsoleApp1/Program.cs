using System;
using MyNameSpace;

namespace ConsoleApp1
{
    class Program
    {
        enum Operazioni
        {
            provaEnum,
            provaEnum2
        }
        static void Main(string[] args)
        {
            int x;
            int y;
            int z;
            int result;
            float result1;
            bool success;
            string a;
            do
            {
                do
                {
                    Console.WriteLine(
                        "--------------------------------------------------------------- \r\n"+
                        
                        "Benvenuto nella calcolatrice SUBWAY3000 \r\n Per iniziare scegli l'operazione: \r\n 1 = + \r\n 2 = - \r\n 3 = * \r\n 4 = / \r\n" +
                        "---------------------------------------------------------------");
                    string operazione = Console.ReadLine();
                    success = Int32.TryParse(operazione, out z);
                    if (!success || z < 1 || z > 4)
                    {
                        Console.WriteLine("il valore inserito non è corretto, inserire un valore intero tra 1 e 4");
                    }
                } while (!success || z < 1 || z > 4);

                if (z == 1)
                {
                    do
                    {
                        Console.WriteLine("Inserisci il primo numero e premi invio");
                        string numero1 = Console.ReadLine();
                        success = Int32.TryParse(numero1, out x);
                        if (!success)
                        {
                            Console.WriteLine("il valore inserito non è corretto \r\n"
                                + "---------------------------------------------------------------");
                        }
                    } while (!success);

                    do
                    {
                        Console.WriteLine("Inserisci il secondo numero e premi invio");
                        string numero2 = Console.ReadLine();
                        success = Int32.TryParse(numero2, out y);
                        if (!success)
                        {
                            Console.WriteLine("il valore inserito non è corretto \r\n"
                                + "---------------------------------------------------------------");
                        }
                    } while (!success);

                    result = Class1.Sum(x, y);
                    Console.WriteLine("La somma di" + x + " e " + y + " è: " + result);

                    //Console.ReadLine();
                }

                if (z == 2)
                {
                    do
                    {
                        Console.WriteLine("Inserisci il primo numero e premi invio");
                        string numero1 = Console.ReadLine();
                        success = Int32.TryParse(numero1, out x);
                        if (!success)
                        {
                            Console.WriteLine("il valore inserito non è corretto \r\n"
                                + "---------------------------------------------------------------");
                        }
                    } while (!success);

                    do
                    {
                        Console.WriteLine("Inserisci il secondo numero e premi invio");
                        string numero2 = Console.ReadLine();
                        success = Int32.TryParse(numero2, out y);
                        if (!success)
                        {
                            Console.WriteLine("il valore inserito non è corretto"+
                                "\r\n---------------------------------------------------------------");
                        }
                    } while (!success);

                    result = Class1.Diff(x, y);
                    Console.WriteLine("La differenza di" + x + " e " + y + " è: " + result+
                        "\r\n ---------------------------------------------------------------");

                    //Console.ReadLine();
                }

                if (z == 3)
                {
                    do
                    {
                        Console.WriteLine("Inserisci il primo numero e premi invio");
                        string numero1 = Console.ReadLine();
                        success = Int32.TryParse(numero1, out x);
                        if (!success)
                        {
                            Console.WriteLine("il valore inserito non è corretto \r\n" +
                                "---------------------------------------------------------------");
                        }
                    } while (!success);

                    do
                    {
                        Console.WriteLine("Inserisci il secondo numero e premi invio");
                        string numero2 = Console.ReadLine();
                        success = Int32.TryParse(numero2, out y);
                        if (!success)
                        {
                            Console.WriteLine("il valore inserito non è corretto \r\n" +
                                "---------------------------------------------------------------");
                        }
                    } while (!success);

                    result = Class1.Prod(x, y);
                    Console.WriteLine("Il prodotto di" + x + " e " + y + " è: " + result +
                        "\r\n--------------------------------------------------------------");

                    //Console.ReadLine();
                }

                if (z == 4)
                {
                    do
                    {
                        Console.WriteLine("Inserisci il primo numero e premi invio");
                        string numero1 = Console.ReadLine();
                        success = Int32.TryParse(numero1, out x);
                        if (!success)
                        {
                            Console.WriteLine("il valore inserito non è corretto\r\n" +
                                    "---------------------------------------------------------------");
                        }
                    } while (!success);

                    do
                    {
                        Console.WriteLine("Inserisci il secondo numero e premi invio");
                        string numero2 = Console.ReadLine();
                        success = Int32.TryParse(numero2, out y);
                        if (!success)
                        {
                            Console.WriteLine("il valore inserito non è corretto \r\n" +
                                    "---------------------------------------------------------------");
                        }
                        else
                        {
                            if (y == 0)
                            {
                                Console.WriteLine("Impossibile dividere per 0 \r\n" +
                                    "---------------------------------------------------------------");
                            }
                        }
                    } while (!success || y == 0);

                    result1 = Class1.Div(x, y);
                    Console.WriteLine("La divisione di" + x + " e " + y + " è: " + result1 +
                        "\r\n ---------------------------------------------------------------");
                    //Console.ReadLine();
                }

                Console.WriteLine("Premere n per uscire, qualsiasi tasto per continuare");
                a = Console.ReadLine();
            } while (a != "n");

        }
    }
}

