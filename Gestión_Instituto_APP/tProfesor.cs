using System;
using System.Collections.Generic;
using System.Text;

namespace Gestión_Instituto_APP
{
    class tProfesor
    {
        private string nombre;
        private string DNI;
        private string telefono;
        private string codigo_curso;
        private List<string> asignaturas;



        public void Setnombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string Getnombre()
        {
            return nombre;
        }

        public void SetDNI(string DNI)
        {
            this.DNI = DNI;
        }

        public string GetDNI()
        {
            return DNI;
        }

        public void SetTelefono(string telefono)
        {
            this.telefono = telefono;
        }

        public string GetTelefono()
        {
            return telefono;
        }

        public void SetCodigo_curso(string codigo_curso)
        {
            this.codigo_curso = codigo_curso;
        }

        public string GetCodigo_curso()
        {
            return codigo_curso;
        }

        public void SetAsignaturas_impartidas(string asignatura)
        {
            this.asignaturas.Add(asignatura);
        }

        public string GetAsignaturas_impartidas(int posicion)
        {
            return asignaturas[posicion];
        }


        //METODO IMPRIMIR PROFESOR
        public void InformacionProfesor()
        {
            Console.WriteLine("Información del Profesor:");
            Console.WriteLine();
            Console.WriteLine("Nombre: {0}", nombre);
            Console.WriteLine("DNI: {0}", DNI);
            Console.WriteLine("Teléfono: {0}", telefono);
            Console.WriteLine("Codigo del Curso: {0}", codigo_curso);
            //Console.WriteLine("Asignatura/as: {0}", asignaturas);
        }
    }
}
