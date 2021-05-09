using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Gestión_Instituto_APP
{
    class tValidaciones
    {
        //MÉTODO PARA LA VALIDACIÓN DEL DNI DE PROFESORES Y ALUMNOS
        public static string validarDNI()
        {
            char[] letras = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };
        pedir:
            Console.WriteLine("Introduce DNI");
            string dni = Console.ReadLine();
            //Obtengo la cadena de numeros.
            char letra = char.ToUpper(dni[8]); //Paso a mayuscula la letra y la obtengo.
            string numero = dni.Remove(8, 1);  //Elimina en la pisicion 8 un elemento. se hace para eliminar el int de la ultima posicion y que la letra vaya ahí.
            int i = 0;
            bool esnumero = int.TryParse(numero, out i);   //Averiguar si es un numero entero el introducido. coje el numero y lo mete en "J" si corresponde a un numero, si es falso se queda J a 0.
                                                           //comprobar letra
            if (!letras.Contains(letra))
            {
                Console.WriteLine("Error, Introduce el DNI con números y letra.");
                goto pedir;
            }
            //comprobar que es un numero
            if (!esnumero)
            {
                Console.WriteLine("Error, Introduce el DNI con números y letra.");
                goto pedir;
            }
               
            //comprobar la longitud de la cadena
            if (dni.Length != 9)
            {
                Console.WriteLine("Error, Introduce el DNI con números y letra.");
                goto pedir;
            }              
            //comprobar el dni y la letra juntos, calculo le la letra con el numero 
            int num = Convert.ToInt32(numero);
            int pos = num % 23;
            if (letras[pos] != letra)
            {
                Console.WriteLine("Error, Introduce el DNI con números y letra.");
                goto pedir;
            }
            else
                dni = numero + letra;
            return dni;
        }
    }
}
