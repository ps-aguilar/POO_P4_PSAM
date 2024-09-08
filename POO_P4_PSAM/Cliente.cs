using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace POO_P4_PSAM
{
    internal class Cliente
    {
        private string nombre;
        private string apellido;
        private int numeroIdentificacion;
        private List<CuentaBancaria> cuentasBancarias;


        //CONSTRUCTOR
        public Cliente(string nombre, string apellido, int numeroIdentificacion)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.numeroIdentificacion = numeroIdentificacion;
            cuentasBancarias = new List<CuentaBancaria>();
        }

        //PROPIEDADES (Muestra de encapsulamiento)

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        public int NumeroIdentificacion
        {
            get { return this.numeroIdentificacion; }
            set { this.numeroIdentificacion = value; }
        }

        public List<CuentaBancaria> CuentasBancarias
        {
            get { return this.cuentasBancarias; }
            set { this.cuentasBancarias = value; }
        }

        //METODOS

        public void AgregarCuenta(CuentaBancaria cuentaNueva)
        {
           cuentasBancarias.Add(cuentaNueva);
        }

        public void ConsultarCuentas()
        {

        }
    }
}
