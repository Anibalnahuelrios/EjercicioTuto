using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anibal_capo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //tipo de dato// nombre de variable // valor//

            int escomoentero = 25;//solo numeros //es como el definir "COMO ENTER0"

           double escomoreal = 0;//puede ser numeros enteros y con coma es como definir "COMO REAL" 

            float otronumerico = 0;// es como real pero mas chico 

            string escomoalfanumerico = "0";//se puede numeros y letras  

            string[]conjuntos={ "hola", "chau"};//guardar conjuntos de valores

            char unosolo = '2';  //es para un solo valor

            //mostrar pantalla 

            //escribir 
            Console.WriteLine("hola soy mario");
            Console.WriteLine("mi edad es": +escomoentero + "y como pan");// el + para concatenar las cosas 
            Console.ReadKey(); //para terminar el programa pulsando una tecla.

            string nombre = "";

            //escribir 
            Console.WriteLine("hola; sos?");
            nombre= Console.ReadLine();

            Console.WriteLine("ahh vos sos" + nombre);

            //pasar a numero 
            int numero = 4;
            numero= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("mi edad es " + numero);
        }
    }
}
