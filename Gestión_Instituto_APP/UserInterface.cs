using System;
using System.Collections.Generic;
using System.Text;

namespace Gestión_Instituto_APP
{
    class UserInterface
    {
        
        //MENÚ PRINCIPAL
        public static int Menu()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("---------- I.E.S. MARE NOSTRUM ----------");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();
            Console.WriteLine(" 1) GESTIÓN DE CURSOS ");
            Console.WriteLine(" 2) GESTIÓN DE ALUMNOS");
            Console.WriteLine(" 3) GESTIÓN DE PROFESORES");
            Console.WriteLine(" 0) SALIR");
            Console.WriteLine();
            try
            {
                return Convert.ToInt32(Console.ReadLine());
            }
            catch 
            {
                Console.WriteLine("Error de parámetros: Introduce una opción válida.");
                Console.ReadLine();
                return UserInterface.Menu();
            }
        }

        //GESTIÓN DE CURSOS
        public static int GestionCursos()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("----------------- GESTIÓN DE CURSOS -------------------");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine(" 1) AÑADIR CURSO");
            Console.WriteLine(" 2) ELIMINAR CURSO");
            Console.WriteLine(" 3) MOSTRAR TODOS LOS CURSOS");
            Console.WriteLine(" 4) MOSTRAR TODOS LOS ALUMNOS PERTENECIENTES A UN CURSO");
            Console.WriteLine(" 0) MENÚ PRINCIPAL");
            try
            {
                return Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Error de parámetros: Introduce una opción válida.");
                Console.ReadLine();
                return UserInterface .GestionCursos();
            }
        }

        //SUBMENÚ GESTIÓN DE CURSOS
        public static void MostrarInterfazAddCurso()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("---------------- AÑADIR CURSO -------------------");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();
        }

        public static void MostrarInterfazEliminarCurso()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("--------------- ELIMINAR CURSO ------------------");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();
        }

        public static void MostrarInterfazImprimirCursos()
        {
            //Console.Clear();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("-------------- IMPRIMIR CURSOS ----------------");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine();
        }

        public static void MostrarInterfazImprimirCursoAlumnos()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("--------- IMPRIMIR CURSO POR ALUMNOS ------------");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();
        }


        //GESTIÓN DE ALUMNOS
        public static int GestionAlumnos()
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("----------------- GESTIÓN DE ALUMNOS -----------------");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("---------------------- ALUMNOS -----------------------");
            Console.WriteLine();
            Console.WriteLine(" 1) INTRODUCIR ALUMNO");
            Console.WriteLine(" 2) ELIMINAR ALUMNO");
            Console.WriteLine(" 3) MOSTRAR LISTA DE ALUMNOS");
            Console.WriteLine(" 4) ORDENAR ALFABÉTICAMENTE A LOS ALUMNOS");
            Console.WriteLine(" 5) MOSTRAR DATOS DEL ALUMNO(POR NOMBRE)");
            Console.WriteLine(" 6) MOSTRAR ALUMNOS PERTENECIENTES A UN CURSO");
            Console.WriteLine(" 0) MENÚ PRINCIPAL");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("----------------------- NOTAS ------------------------");
            Console.WriteLine();
            Console.WriteLine(" 7) AÑADIR NOTAS A UN ALUMNO");
            Console.WriteLine(" 8) ELIMINAR NOTAS DE UN ALUMNO");
            Console.WriteLine(" 9) MOSTRAR ALUMNOS CON NOTA MEDIA IGUAL O MAYOR A 5.");
            Console.WriteLine(" 10) MOSTRAR ALUMNOS CON NOTA MEDIA MENOR QUE 5.");
            try
            {
                return Convert .ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Error de parámetros: Introduce una opción válida.");
                Console.ReadLine();
                return UserInterface.GestionAlumnos();
            }
        }


        //--------------------------- A L U M N O S -------------------------------

        //SUBMENÚ GESTIÓN DE ALUMNOS
        public static void MostrarInterfazAddAlumno()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("---------------- AÑADIR ALUMNO ------------------");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();
        }
        public static void MostrarEliminarAlumno()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("--------------- ELIMINAR ALUMNO -----------------");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine(); 
        }
        public static void MostrarImprimirListaAlumnos()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("--------------- IMPRIMIR ALUMNOS ----------------");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();        
        }
        public static void MostrarInterfazOrdenarAlumnos()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("--------------- ORDENAR ALUMNOS -----------------");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Pusa 'Enter' para ordenar la lista de los Alumnos:");
        }
        public static void MostrarInterfazNombreAlumno()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("-------- IMPRIMIR POR NOMBRE DEL ALUMNO ---------");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();
        }
        public static void MostrarInterfazImprimirAlumnosPorCurso()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("--------- IMPRIMIR ALUMNOS DE UN CURSO ----------");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();
        }


        //---------------------------- N O T A S ----------------------------------

        //GESTIÓN DE NOTAS
        public static void MostrarInterfazAddNotaAlumno()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("----------- AÑADIR NOTAS A ALUMNO ---------------");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();
        }
        public static void MostrarInterfazEliminarNotaAlumno()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("----------- ELIMINAR NOTA DE ALUMN --------------");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();
        }
        public static void MostrarInterfazImprimirNotaMediaAprobados()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("---- IMPRIMIR NOTA MEDIA DE ALUMNOS APROBADOS -----");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine();
        }
        public static void MostrarInterfazImprimirNotaMediaSuspensos()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("---- IMPRIMIR NOTA MEDIA DE ALUMNOS SUSPENDIDOS ----");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();
        }




        //GESTIÓN DE PROFESORES
        public static int GestionProfesores()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("-------------- GESTIÓN DE PROFESORES ---------------");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("-------------------- PROFESORES --------------------");
            Console.WriteLine();
            Console.WriteLine(" 1) INTRODUCIR PROFESOR");
            Console.WriteLine(" 2) ELIMINAR PROFESOR");
            Console.WriteLine(" 3) MOSTRAR LISTA DE PROFESORES");
            Console.WriteLine(" 4) ORDENAR ALFABÉTICAMENTE A LOS PROFESORES");
            Console.WriteLine(" 5) MOSTRAR DATOS DE LOS PROFESORES");
            Console.WriteLine(" 0) MENÚ PRINCIPAL");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("------------------- ASIGNATURAS --------------------");
            Console.WriteLine();
            Console.WriteLine(" 6) AÑADIR ASIGNATURA A UN PROFESOR");
            Console.WriteLine(" 7) ELIMINAR ASIGNATURA A UN PROFESOR");
            Console.WriteLine(" 8) MOSTRAR PROFESORES QUE IMPARTAN UNA ASIGNATURA");
            try
            {
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Error de parámetros: Introduce una opción válida.");
                Console.ReadLine();
                return UserInterface.GestionProfesores();
            }
        }


        //------------------------ P R O F E S O R E S -------------------------------


        //SUBMENÚ GRSTIÓN DE PROFESORES
        public static void AddProfesor()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("----------------- AÑADIR PROFESOR ------------------");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();
        }

        public static void eliminarProfesor()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("---------------- ELIMINAR PROFESOR -----------------");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();
        }

        public static void imprimirProfesores()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("--------------- IMPRIMIR PROFESORES ----------------");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();
        }

        public static void ordenarProfesores()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("----------- ORDENAR LISTA DE PROFESORES ------------");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();
        }

        public static void imprimirDatosProfesores()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("---------- AÑADIR ASIGNATURA A PROFESOR -----------");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine();
        }


        //------------------------- A S I G N A T U R A S ----------------------------


        //GESTIÓN ASIGNATURAS
        public static void AddAsignaturaProfesor()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("---------- AÑADIR ASIGNATURA A PROFESOR -----------");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine();
        }

        public static void eliminarAsignaturaProfesor()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("--------- ELIMINAR ASIGNATURA A PROFESOR ----------");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine();
        }

        public static void imprimirProfesorConAsignatura()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("------- IMPRIMIR PROFESORES POR ASIGNAATURA -------");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine();
        }

      

        //metodo readkey para que continue el programa solo si se pulsa enter
        //public static void Salida()
        //{
        //    do
        //    {
        //        Console.WriteLine("Pulse Enter para continuar:");
        //    }
        //    while (Console.ReadKey(true).Key == ConsoleKey.Enter); //por defecto es FALSE Y CARGA EL TECLADO EN PANTALLA Y LO MUESTRA EN PANTALLA. TRUE hace que lo cargue en memoria y no lo muestre por pantalla.


            //if (Console.ReadKey().Key == ConsoleKey.Enter)
            //{
            //    Console.WriteLine("Adiós!");
            //}
        
    }
}
