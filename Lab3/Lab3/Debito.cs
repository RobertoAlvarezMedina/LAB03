using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    public class Debito
    {

        private int numerocuenta;
        private decimal cobro;
        private decimal saldo;

        public Debito(string firstname, string Lastname, int numerocuenta, decimal cobro, decimal saldo) : base(firstname, Lastname)
        {
            this.numerocuenta = numerocuenta;
            this.cobro = cobro;
            this.saldo = saldo;

        }

        public virtual string GetSummary()
        {
            decimal saldocuenta = saldo;
            decimal cobrocuenta = cobro;
            string result = "El resultado es:" + (saldocuenta - cobrocuenta);

            if (saldocuenta < cobrocuenta)
            {

                Console.WriteLine(saldocuenta);
                Console.ReadLine();

            }
            return result;
        }

    }
}
