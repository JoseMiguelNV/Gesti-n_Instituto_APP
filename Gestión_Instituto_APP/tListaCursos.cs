using System;
using System.Collections.Generic;
using System.Text;

namespace Gestión_Instituto_APP
{
    class tListaCursos
    {
        private List<tCurso> cursos;

        public tListaCursos()
        {
            cursos = new List<tCurso>();
        }


        public int GetNumCursos()
        {
            return cursos.Count;
        }

        public tCurso GetCursoPorPosicion( int posicion)
        {
            return cursos[posicion];
        }

        //MÉTODO PARA AÑADIR UN CURSO
        public void AddCurso()
        {
            tCurso curso = new tCurso();
            Console.Write("Introduce Curso: ");
            curso.SetNombre(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Introduce Código: ");
            curso.SetCodigo(Console.ReadLine());
            curso.GetNombre();
            curso.GetCodigo();
            cursos.Add(curso);
        }

        //MÉTODO PARA ELIMINAR UN CURSO POR SU CÓDIGO
        public void EliminarCurso()
        {
            Console.Write("Introduce el Código del Curso que desea eliminar: ");
            Console.WriteLine();
            string codigo = Console.ReadLine();
            for (int i = 0; i < cursos.Count; i++)
            {
                if (codigo == cursos[i].GetCodigo())
                {
                    cursos.Remove(cursos[i]);
                }
            }
            Console.WriteLine("Curso eliminado correctamente...");
            Console.ReadLine();
        }

        //MÉTODO PARA MOSTRAR TODOS LOS CURSOS
        public void imprimirCursos()
        {
            for (int i = 0; i < cursos.Count; i++)
            {
                cursos[i].InformacionCurso();
                Console.WriteLine();
            }
        }
    }   
}
