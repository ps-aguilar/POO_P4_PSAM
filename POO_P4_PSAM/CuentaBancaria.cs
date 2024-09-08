using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_P4_PSAM
{
    internal class CuentaBancaria
    {
        private int numeroCuenta;
        private int saldo;
        private Cliente propietario;

        //CONSTRUCTOR
        public CuentaBancaria(Banco banco, Cliente propietario)
        {
            numeroCuenta = banco.GenerarNumeroCuenta();
            saldo = 0;
            this.propietario = propietario;
        }

        //PROPIEDADES

        public string NumeroCuenta
        {
            get { return this.NumeroCuenta;  }
            set { this.NumeroCuenta = value; }
        }

        public int Saldo
        {
            get { return this.saldo; }
            set { this.saldo = value; }
        }

        public Cliente Propietario
        {
            get { return this.propietario; }
            set { this.propietario = value; }
        }

        //METODOS

        public void Depositar()
        {

        }

        public void Retirar()
        {

        }

        public string ConsultarSaldo()
        {
            return "El saldo es de: $" + this.Saldo;
        }

        public void Transferencia(CuentaBancaria cuentaDestino)
        {

        }
    }
}
