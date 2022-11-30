using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGuia1
{
    public class Persona
    {
        // ATRIBUTOS
        private string nombre; // Campo de cada objeto Persona que almacena su nombre

        private int edad; // Campo de cada objeto Persona que almacena su edad

        private string dni; // Campo de cada objeto Persona que almacena su NIF


        // PROPERTIES
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        // CONSTRUCTOR SIN PARAMETROS

        public Persona()
        {
            nombre = string.Empty;
            edad = 0;
            dni = string.Empty;
        }

        // CONSTRUCTOR CON 2 PARAMETROS
        public Persona(string nombre, string dni)
        {
            this.nombre = nombre;
            this.dni = dni;
        }

        // CONSTRUCTOR CON 2 PARAMETROS
        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        // CONSTRUCTOR CON 3 PARAMETROS
        public Persona(string nombre, int edad, string dni)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dni = dni;
        }

        


        public void Cumpleanos()
        {
            edad++;
        }








        // METODO TOSTRING
        public override string ToString()
        {
            return "\nNOMBRE: " + nombre + "\nEDAD: " + edad + "\nDNI: " + dni;
        }




    }
}
