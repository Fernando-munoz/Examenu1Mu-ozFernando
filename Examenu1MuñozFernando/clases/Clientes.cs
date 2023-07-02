using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Examenu1MuñozFernando.clases
{
    internal class Clientes
    {

        public string Nombre { get; set; }

        public string edad { get; set; }
        public string numero { get; set; }

        public void contacto()
        {
            Console.WriteLine("Por favor ingrese cuidadosamente los datos del Cliente");

            Console.WriteLine("Nombre del cliente");
        
            Nombre = Console.ReadLine();

            Console.WriteLine("Apellido del Cliente");
        
            edad = Console.ReadLine();

            Console.WriteLine("Ingrese el numero del cliente ");
         
            numero = Console.ReadLine();

        }
        public void imprimir()
        {
            Console.WriteLine(this.Nombre);
            Console.WriteLine(this.numero);
            Console.WriteLine(this.edad);
        
        }

   
        

    }

}

