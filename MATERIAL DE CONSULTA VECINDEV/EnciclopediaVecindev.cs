using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATERIAL_DE_CONSULTA_VECINDEV
{
    public class EnciclopediaVecindev
    {
        public string ConsultarBuenasPracticas()
        {
            string mensaje;

            mensaje = "►Las buenas prácticas de programación son un conjunto formal o informal de reglas, pudiendo ser opcionales u obligatorias, que se adoptan con el fin general de mejorar la calidad del software.\n\nPermiten\n\n ► Facilitar el proceso de desarrollo para el programador.\n\n ► Aumentar o mejorar la legibilidad y mantenibilidad del código fuente, lo que ayuda a otros desarrolladoreso a versiones futuras del autor inicial-a comprender el software.\n\n ► Evitar cierta clase de errores comunes, por ejemplo equivocarse por 1 en los límites de una iteración\n\n ► Sentencia, una debajo de otra por comodidad.";
            
            return mensaje;
        }
        public string ConsultarElementosBasicos()
        {
            string mensaje;
           
                
            mensaje = "TIPOS DE VARIABLES\n\nC# proporciona los siguientes tipos de valor integrados, también conocidos como tipos simples: \n\nTipos numéricos integrales \n\nTipos numéricos de punto flotante \n\nbool, que representa un valor booleano \n\nchar, que representa un carácter Unicode UTF - 16\n\n VARIABLES, espacio  memoria, almacena un valor de tipo particular. Las palabras reservadas no se usan más que para llamar a una tarea del compilador (bool, int, while, double, etc). Variables locales. estan escritas dentro de los miembros. Tipos de datos. De valor. \n\nVARIABLES DE tipos simples. enteros con signos: sbyte, short, int, long.. \n\nEnteros sin signos (NUMEROS ADELANTE DEL CERO, ENTEROS) byte, ushort, uint, ulong. \n\nCaracteres unicode: char. \n\npunto flotante binario: float, double. \n\npunto flotante decimal: decimal. \n\nBooleano: bool. \n\nVARIABLES de tipos de enumeracion tipos definidos por el usuario: enum E {. . .} \n\nDe referencia.\n\n\n\nLa diferencia principal entre ConsoleWrite y consoleWriteLine es que el primero refleja el mensaje en la misma linea de codigo,  en cambio WriteLine escribe los datos especificados, seguidos del terminador de línea actual (salto de linea)" + "\n\n\nDECLARACION DE VARIABLE [VARIABLE] [TIPO(nombre de identificador)];\n\n\nDARLE UN VALOR A LA VARIABLE (INICIALIZAR UNA VARIABLE) \n[TIPO] = 500; \n\nEL OPERADOR DE ASIGNACION ES = ASIGNA EL VALOR DE SU DERECHA A LOS QUE TENGA DE SU LADO IZQUIERDO\n\nDECLARAR E INICIALIZAR UNA VARIABLE \n\n[VARIABLE] [TIPO] = 5000;";

          
            return mensaje;
        }
    }
}
