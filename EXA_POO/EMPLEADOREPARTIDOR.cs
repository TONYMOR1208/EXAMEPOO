using System;
using System.Collections.Generic;
using System.Text;

namespace EXA_POO
{
    class EMPLEADOREPARTIDOR : EMPLEADOS, Imensaje
    {
        public string zona { get; set; }

        public EMPLEADOREPARTIDOR(string Nombre, int Edad, double salario, string zona) : base(Nombre, Edad, salario)
        {
            this.zona = zona;
        }
        public void mesaje()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("PRESENTACION");
            Console.WriteLine("SOY UN EMPLEADO ");
            Console.WriteLine("--------------------");
        }

        public  override void imprimir()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("NOMBRE: " + Nombre);
            Console.WriteLine("EDAD: " + Edad);
            Console.WriteLine("ZONA: " + zona);
        }
        public override void plus()
        {
            if (Edad < 25 && zona.Equals("Zona 3"))
            {
                double nuevoSalario = salario + PLUS;
                salario = (nuevoSalario);

            }
            Console.WriteLine("SALARIO: " + salario);
          

        }

    }
}