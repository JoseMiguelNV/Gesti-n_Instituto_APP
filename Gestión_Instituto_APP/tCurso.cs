using System;
using System.Collections.Generic;
using System.Text;

namespace Gestión_Instituto_APP
{
    class tCurso
    {
        private string nombre;
        private string codigo;


        
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public void SetCodigo(string codigo)
        {
            this.codigo = codigo;
        }

        public string GetCodigo()
        {
            return codigo;
        }

        public void InformacionCurso()
        {
            Console.WriteLine("Información de cursos:");
            Console.WriteLine();
            Console.WriteLine("Curso : {0}", nombre);
            Console.WriteLine("Código : {0}", codigo);
        }
    }
}
