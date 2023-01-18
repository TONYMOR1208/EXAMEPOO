using System;
using System.Collections.Generic;
using System.Text;

namespace EXA_POO
{
    class EMPLEADOCOMERCIAL : EMPLEADOS, Imensaje
    {

        public double comision { get; set; }

        public EMPLEADOCOMERCIAL(string Nombre, int Edad, double salario, double comision) : base(Nombre, Edad, salario)
        {
            this.comision = comision;
        }

        public void mesaje()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("PRESENTACION");
            Console.WriteLine("SOY UN EMPLEADO ");
            Console.WriteLine("--------------------");
        }

        public override  void imprimir()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("NOMBRE: " + Nombre);
            Console.WriteLine("EDAD: " + Edad);
            Console.WriteLine("COMISION: " + comision);
           

        }
        public override void plus()
        {
            if (Edad > 30 && comision > 200)
            {
                salario = salario + PLUS;
              
          
            }
           
            Console.WriteLine("SALARIO: " + salario);
       
        }
       

    }
}
