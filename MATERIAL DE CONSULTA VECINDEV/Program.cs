using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATERIAL_DE_CONSULTA_VECINDEV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //VARIABLES
            int opcion;
            //PRESENTACION
            Console.WriteLine("MATERIAL DE CONSULTA DE LA VECINDEV - C#");
            Console.WriteLine("----------------------------------------");
            Console.ReadKey();
            Console.Clear();
            Console.Beep();

            //INSTANCIAMOS LA CLASE
            EnciclopediaVecindev material1 = new EnciclopediaVecindev();

            //INICIO MENU
            do
            {
                Console.Write("---------------------------------------");
                Console.WriteLine("MATERIAL DE CONSULTA C#");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("0. BUENAS PRACTICAS DE PROGRAMACION");
                Console.WriteLine("1. ELEMENTOS BASICOS DE UN PROGRAMA DE COMPUTADORA");
                Console.WriteLine("2. LA TOMA DE DECISIONES");
                Console.WriteLine("3. LOS CICLOS");
                Console.WriteLine("4. LOS METODOS");
                Console.WriteLine("5. LAS MATRICES");
                Console.WriteLine("6. LAS CLASES");
                Console.WriteLine("7. LAS COLECCIONES GENERICAS");
                Console.WriteLine("8. LAS CADENAS");
                Console.WriteLine("9. ESTRUCTURAS Y ENUMERACIONES");
                Console.WriteLine("10. FLUJOS Y ARCHIVOS");
                Console.WriteLine("11. DEPURACION");
                Console.WriteLine("12. SALIR");

                Console.Write("\nElija una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                
                switch (opcion)
                {
                    
                    case 0:
                        Console.WriteLine(material1.ConsultarBuenasPracticas());
                        break;
                    case 1:
                        Console.WriteLine(material1.ConsultarElementosBasicos());
                        break;

                        

                    //    break;
                    //case 2:
                    //    Console.Write("Ingrese el monto a retirar: $");
                    //    = Convert.ToDouble(Console.ReadLine());
                    //    break;
                    //case 3:
                    //    break;
                    //case 4:
                    //    Console.WriteLine(.ToString());
                    //    break;
                }


            } while (opcion >= 0 && opcion <= 4);


        }
    }
}
