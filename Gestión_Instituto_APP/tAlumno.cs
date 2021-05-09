using System;
using System.Collections.Generic;
using System.Text;

namespace Gestión_Instituto_APP
{
    class tAlumno
    {
        private string nombre;
        private string DNI;
        private string telefono;
        private string codigo_curso;
        private List<double> notas;

        //CONSTRUCTOR PARA ALUMNOS
        public tAlumno(string nombre, string DNI, string telefono, string codigo_curso)
        {
            this.nombre = nombre;
            this.DNI = DNI;
            this.telefono = telefono;
            this.codigo_curso = codigo_curso;
        }

        public tAlumno(List<double> notas)
        {
            this.notas = new List<double>();
        }

        public tAlumno()
        {
        }

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

        public void Setnotas(double notas)
        {
            this.notas.Add(notas); 
        }

        public double Getnotas(int posicion)
        {
            return notas[posicion];
        }

        public void Setnotas(List<double> notas)
        {
            this.notas = notas;
        }

        public List<double> Getnotas()
        {
            return notas;
        }


        //----------------------- PROCEDIMIENTOS -----------------------------

        //MÉTODO PARA OBTENER LOS DATOS A IMPRIMIR POR PANTALLA
        public void InformacionAlumno()
        {
            Console.WriteLine("Información del Alumno:");
            Console.WriteLine();
            Console.WriteLine("Nombre: {0}", nombre);
            Console.WriteLine("DNI: {0}", DNI); 
            Console.WriteLine("Teléfono: {0}", telefono);
            Console.WriteLine("Codigo del Curso: {0}", codigo_curso);
            Console.WriteLine("Notas: {0}", notas);
        }

        //MÉTODO PARA DEVOLVER EL VALOR DE LAS NOTAS
        public double devolverNota(int i)
        {
            return notas[i];
        }
    }
}
