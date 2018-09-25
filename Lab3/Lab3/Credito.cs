using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    public class Credito:Cuenta
    {

        private int numerocuenta;
        private decimal cobro;
        private decimal saldo;

        public Credito(string firstname, string Lastname, int numerocuenta, decimal cobro, decimal saldo) : base(firstname, Lastname)
        {
            this.numerocuenta = numerocuenta;

        }

        public override string GetSummary()
        {

            decimal saldocuenta = saldo;
            decimal cobrocuenta = cobro;
            string result = "EL resultado es de:" + (saldocuenta - cobrocuenta);

            if (saldocuenta == decimal.Zero)
            {
                decimal total = saldocuenta - cobrocuenta;
                string desgloce = "Lo que debe:" + "-" + " " + cobrocuenta;
            }
            return result;
        }
    }
}
}
