using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese (D) para debito o (C) para credito");
            string validar = Console.ReadLine();

            if (validar.Equals("D"))
            {
                Cuenta Debito = new Debito("Roberto", "Alvarez", 987986765, 3000, 5000);
                Console.WriteLine(PrintCuenta(Debito));
                Console.ReadKey();

            }
            else
            {
                if (validar.Equals("C"))
                {
                    Cuenta Credito = new Debito("Roberto", "Alvarez", 987986764, 5000, 3000);
                    Console.WriteLine(PrintCuenta(Credito));
                    Console.ReadKey();
                }
            }
        }

        private static string PrintCuenta(Cuenta c)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(c);
            sb.AppendLine();
            sb.Append(c.GetSummary());

            return sb.ToString();
        }
    }
    }
}
