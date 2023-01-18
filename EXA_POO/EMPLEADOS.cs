using System;
using System.Collections.Generic;
using System.Text;
namespace EXA_POO
{
     class EMPLEADOS
    {
        public string Nombre { get; set; }
        public int Edad {get; set; }
        public double salario { get; set; }

        public  double PLUS = 300;

        public EMPLEADOS(string Nombre, int Edad, double salario)
        {
            this. Nombre = Nombre;
            this.Edad = Edad;
            this.salario = salario;
        }

        public virtual  void imprimir()
        {
        }

        public virtual void plus()
        {
        }

    }

}
