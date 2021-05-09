using System;
using System.Collections.Generic;
using System.Text;

namespace Gestión_Instituto_APP
{
    class tListaAlumnos
    {
        List<tAlumno> alumnos;

        public tListaAlumnos()
        {
            alumnos = new List <tAlumno>();
        }

        //MÉTODO PARA AÑADIR ALUMNOS GUARDANDO TODOS SUS DATOS EN UNA LISTA.
        public void AddAlumno(tListaCursos listaCursos)
        {
            tAlumno alumno = new tAlumno();
            Console.Write("Nombre: ");
            alumno.Setnombre(Console.ReadLine());
            string dni = tValidaciones.validarDNI();
            alumno.SetDNI(dni);
            Console.Write("Teléfono: ");
            alumno.SetTelefono(Console.ReadLine());
            Console.Write("Código del curso: ");
            string codigo_curso = Console.ReadLine();
            for (int i = 0; i < listaCursos.GetNumCursos(); i++)
            {
                if (codigo_curso == listaCursos.GetCursoPorPosicion(i).GetCodigo())
                    alumno.SetCodigo_curso(codigo_curso);
                else
                    Console.Write("Introduce un código de curso correcto");
            }
            alumnos.Add(alumno);
        }

        //MÉTODO PARA ELIMINAR ALUMNOS POR SU NOMBRE
        public void EliminarAlumno()
        {
            Console.Write("Introduce el nombre del alumno que deseas borrar: ");
            string nombre = Console.ReadLine();
            for (int i = 0; i < alumnos.Count; i++)
            {
                if (nombre == alumnos[i].Getnombre())
                {
                    alumnos.Remove(alumnos[i]);
                }
            }
        }

        //MÉTODO PARA MOSTRAR LA LISTA DE ALUMNOS
        public void imprimirListaAlumnos()
        {
            for (int i = 0; i < alumnos.Count; i++)
            {
                alumnos[i].InformacionAlumno();
                Console.ReadLine();
            }
        }

        //MÉTODO PARA ORDENAR LA LISTA DE ALUMNOS POR ORDEN ALFABÉTICO
        public void ordenarAlumnos()
        {
            for (int i = 0; i < alumnos.Count - 1; i++)
            {
                for (int j = i + 1; j < alumnos.Count; j++)
                {
                    string alumno1 = alumnos[i].Getnombre();
                    string alumno2 = alumnos[j].Getnombre();
                    if (alumno1.CompareTo(alumno2) > 0)
                    {
                        string aux = alumno1;
                        alumno1 = alumno2;
                        alumno2 = aux;
                    }
                }
            }
        }

        //MÉTODO PARA IMPRIMIR UN ALUMNO ULITIZANDO SU NOMBRE
        public void imprimirNombreAlumno()
        {
            Console.Write("Introduce el nombre del alumno que deseas obtener de la lista: ");
            string nombre = Console.ReadLine();
           
            for (int i = 0; i < alumnos.Count; i++)
            {
                if (nombre == alumnos[i].Getnombre())
                {
                    alumnos[i].InformacionAlumno();
                }
            }
        }

        //MÉTODO PARA MOSTRAR TODOS LOS ALUMNOS PERTENECIENTES A UN CURSO
        public void imprimirAlumnosPorCurso()
        {
            Console.Write("Introduce el Código del curso para obtener los Alumnos matriculados: ");
            string Codigo_curso = Console.ReadLine();
            for (int i = 0; i < alumnos.Count; i++)
            {
                if (Codigo_curso == alumnos[i].GetCodigo_curso())
                {
                    alumnos[i].InformacionAlumno();
                    Console.WriteLine();
                }
            }
        }


        //----------------- MÉTODOS PARA LAS NOTAS -----------------------


        //MÉTODO PARA AÑADIR NOTAS A ALUMNOS
        public void AddNotaAlumno(List<tAlumno> listaAlumnos)
        {
            Console.WriteLine("Introduce Alumno: ");
            string nombre = Console.ReadLine();
            for (int i = 0; i < listaAlumnos.Count; i++)
            {
                if (nombre == listaAlumnos[i].Getnombre())
                {
                    listaAlumnos[i].Setnotas(new List<double>());
                }
            }
            
            //Console.WriteLine("Introduce Notas: ");
            //Console.WriteLine();
            //Console.Write("Primer Trimestre: ");
            //double nota1 = double.Parse(Console.ReadLine());
            //notas.Setnotas(nota1);
            //Console.Write("Segundo Trimestre: ");
            //double nota2 = double.Parse(Console.ReadLine());
            //notas.Setnotas(nota2);
            //Console.Write("Tercer Trimestre: ");
            //double nota3 = double.Parse(Console.ReadLine());
            //notas.Setnotas(nota3);
            //notas.Add();
        }

        //MÉTODO PARA ELIMINAR NOTA DE UN ALUMNO
        public void EliminarNotaAlumno()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

        }

        //MÉTODO PARA IMPRIMIR LOS ALUMNOS CON NOTA MEDIA APROBADA
        public void ImprimirNotaMediaAprobados()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

        }

        //MÉTODO PARA IMPRIMIR LOS ALUMNOS CON NOTA MEDIA SUSPENDIDA
        public void ImprimirNotaMediaSuspensos()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

        }






    }  
}
