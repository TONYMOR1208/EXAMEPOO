using System;
using System.Collections.Generic;
using System.Text;

namespace EXA_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            EMPLEADOCOMERCIAL comercial_1 = new EMPLEADOCOMERCIAL("Anthony Moreira", 28, 200, 150);
      
            EMPLEADOCOMERCIAL comercial_2 = new EMPLEADOCOMERCIAL("Maria Arauz", 35, 250, 210);
           

            EMPLEADOREPARTIDOR repartidor_1 = new EMPLEADOREPARTIDOR("Camila Intriago", 26, 125, "Zona 1");

            EMPLEADOREPARTIDOR repartidor_2 = new EMPLEADOREPARTIDOR("Joel Catagua", 23, 125, "Zona 3");


            List<EMPLEADOS> empleado = new List<EMPLEADOS>();

            empleado.Add(comercial_1);
            empleado.Add(comercial_2);
            empleado.Add(repartidor_1);
            empleado.Add(repartidor_2);

            foreach (EMPLEADOS A in empleado)
            {
                comercial_1.mesaje();
                A.imprimir();
                A.plus();
            


            }
          
        }
    }
}

