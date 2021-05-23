using System;

namespace POO___C2_Ej7
{
    class Persona
    {
        internal static string nombre;
        internal static int edad;
        internal static string DNI;
        internal static string sexo;
        internal static decimal peso;
        internal static decimal altura;
        public const string hombre = "H";
        public const string mujer = "M";

        public Persona()
        {
            nombre = "";
            edad = 0;
            sexo = hombre;
            peso = 0;
            altura = 0;
        }

        public Persona(string nnombre, int nedad, string nsexo)
        {
            nombre = nnombre;
            edad = nedad;
            sexo = nsexo;
        }

        public Persona(string nnombre, int nedad, string nDNI, string nsexo, decimal npeso, decimal naltura)
        {
            nombre = nnombre;
            edad = nedad;
            DNI = nDNI;
            sexo = nsexo;
            peso = npeso;
            altura = naltura;
        }

    }
}
