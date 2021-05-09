using System;
using System.Collections.Generic;
using System.Text;

namespace Gestión_Instituto_APP
{
    class Instituto
    {
        //LISTAS DONDE VAMOS A GUARDAR LOS DATOS DE CADA APARTADO
        tListaCursos listaCursos = new tListaCursos();
        tListaAlumnos listaAlumnos = new tListaAlumnos();
        tListaProfesores listaProfesores = new tListaProfesores();


        //MENÚ GESTION DE CURSOS
        public void LanzarGestionDeCursos()
        {
            int option = 0;
            do
            {
                option = UserInterface.GestionCursos();
                {
                    switch (option)
                    {
                        case 0:
                            UserInterface.Menu(); //RETURN MENÚ PRINCIPAL
                            break;
                        case 1:
                            UserInterface.MostrarInterfazAddCurso();  //OPCIÓN AÑADIR CURSO                                                                                                                                     
                            listaCursos.AddCurso();
                            break;
                        case 2:
                            UserInterface.MostrarInterfazEliminarCurso();  //OPCIÓN ELIMINAR CURSO
                            listaCursos.EliminarCurso();
                            break;
                        case 3:
                            UserInterface.MostrarInterfazImprimirCursos();
                            listaCursos.imprimirCursos();  //OPCIÓN IMPRIMIR CURSO
                            break;
                        case 4:
                            UserInterface.MostrarInterfazImprimirAlumnosPorCurso();  //OPCIÓN IMPRIMIR LISTA DE ALUMNOS POR CURSO
                            listaAlumnos.imprimirAlumnosPorCurso();
                            break;
                        default:
                            if (option > 4 || option < 0)
                            {
                                Console.WriteLine("Error de parámetros: Introduce una opción válida.");
                                Console.ReadLine();
                            }
                            break;
                    }
                }
            }
            while (option != 0);
        }


        //MENÚ GESTIÓN DE ALUMNOS
        public void LanzarGestionDeAlumnos()
        {
            int option = 0;
            do
            {
                option = UserInterface.GestionAlumnos();
                {
                    switch (option)
                    {
                        case 0:
                            UserInterface.Menu();
                            break;
                        case 1:
                            UserInterface.MostrarInterfazAddAlumno();
                            listaAlumnos.AddAlumno(listaCursos);
                            break;
                        case 2:
                            UserInterface.MostrarEliminarAlumno();
                            listaAlumnos.EliminarAlumno();
                            break;
                        case 3:
                            UserInterface.MostrarImprimirListaAlumnos();
                            listaAlumnos.imprimirListaAlumnos();
                            break;
                        case 4:
                            UserInterface.MostrarInterfazOrdenarAlumnos();
                            listaAlumnos.ordenarAlumnos();
                            break;
                        case 5:
                            UserInterface.MostrarInterfazNombreAlumno();
                            listaAlumnos.imprimirNombreAlumno();
                            break;
                        case 6:
                            UserInterface.MostrarInterfazImprimirCursoAlumnos();
                            listaAlumnos.imprimirAlumnosPorCurso();
                            break;
                        case 7:
                            UserInterface.MostrarInterfazAddNotaAlumno();
                            break;
                        case 8:
                            UserInterface.MostrarInterfazEliminarNotaAlumno();
                            break;
                        case 9:
                            UserInterface.MostrarInterfazImprimirNotaMediaAprobados();
                            break;
                        case 10:
                            UserInterface.MostrarInterfazImprimirNotaMediaSuspensos();
                            break;
                        default:
                            if (option > 10 || option < 0)
                            {
                                Console.WriteLine("Error de parámetros: Introduce una opción válida.");
                                Console.ReadLine();
                            }
                            break;
                    }
                }
            }
            while (option != 0);
        }

      
        //MENÚ GESTIÓN DE PROFESORES
        public void LanzarGestionDeProfesores()
        {
            int option;
            do
            {                
                option = UserInterface.GestionProfesores();
                {
                    switch (option)
                    {
                        case 0:
                            UserInterface.Menu();
                            break;
                        case 1:
                            UserInterface.AddProfesor();
                            break;
                        case 2:
                            UserInterface.eliminarProfesor();
                            break;
                        case 3:
                            UserInterface.imprimirProfesores();
                            break;
                        case 4:
                            UserInterface.ordenarProfesores();
                            break;
                        case 5:
                            UserInterface.imprimirDatosProfesores();
                            break;
                        case 6:
                            UserInterface.AddAsignaturaProfesor();
                            break;
                        case 7:
                            UserInterface.eliminarAsignaturaProfesor();
                            break;
                        case 8:
                            UserInterface.imprimirProfesorConAsignatura();
                            break;
                        default:
                            if (option > 8 || option < 0)
                            {
                                Console.WriteLine("Error de parámetros: Introduce una opción válida.");
                                Console.ReadLine();
                            }                           
                            break;
                    }
                }
            }
            while (option != 0);
        }

        //MENÚ PRINCIPAL  -- EN ESTE PUNTO SE EJECUTA EL PROGRAMA --
        public void Run()
        {         
            int option = 0;
            do
            {
                option = UserInterface.Menu();
                {                  
                    switch (option)
                    {
                        case 0:
                            break;
                        case 1:
                            //GESTIÓN DE CURSOS
                            LanzarGestionDeCursos();
                            break;
                        case 2:
                            //GESTIÓN DE ALUMNOS
                            LanzarGestionDeAlumnos();
                            break;
                        case 3:
                            //GESTIÓN DE PROFESORES
                            LanzarGestionDeProfesores();
                            break;                       
                        default:
                            if (option > 3 || option < 0)
                            {
                                Console.WriteLine("Error de parámetros: Introduce una opción válida.");
                                Console.ReadLine();
                            }
                            break;
                    }
                }
            }
            while (option != 0);         
        }    
    }
}
