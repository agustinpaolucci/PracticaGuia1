using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGuia1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Persona p01 = new Persona("Agustin",47,"24.603.259");
            Persona p02 = new Persona("Maria", 39);
            Persona p03 = new Persona("Pedro", 22, "40.555.775") ;
            Persona p04 = new Persona("Juana","16.620.902");
            Persona p05 = new Persona();

            p03.Edad = 25;
            p01.Nombre = "Guillermo";

            p01.Cumpleanos();

            Console.WriteLine(p01.ToString());
            Console.WriteLine(p02.ToString());
            Console.WriteLine(p03.ToString());
            Console.WriteLine(p04.ToString());
            Console.WriteLine(p05.ToString());

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Presione una tecla para finalizar...");
            Console.ReadKey();
        }
    }
}


/*

<tipoDevuelto> <nombreMétodo> (<parametros>) 
{
    <instrucciones>
}
*/