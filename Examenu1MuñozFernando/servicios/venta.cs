using Examenu1MuñozFernando.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Examenu1MuñozFernando.servicios
{
    internal class venta
    {

        public void date()
        {
            DateTime currentDateTime = DateTime.Now;
            string formattedDateTime = currentDateTime.ToString("dddd, dd MMMM yyyy HH:mm:ss");
            Console.WriteLine(" Fecha de la compra : " + formattedDateTime);
        }

        public void datos()
        {
            Console.WriteLine();

        }


        public void suma()
        {
            try
            {

                int nv;
                float valor = 0;
                float acumulado = 0;

                double porciento = 0;
                float div = 0;

                Clientes cliente = new Clientes();

                cliente.contacto();



                Console.WriteLine("Ingresa el total");
                acumulado = int.Parse(Console.ReadLine());


                Console.WriteLine("               el total a pagar es de :" + acumulado);
                if (acumulado >= 2000 && acumulado <= 2999)
                {
                    porciento = acumulado - (acumulado * 0.20);
                    Console.WriteLine($"        su pago con el 20% es de: {(porciento)}");
                    cliente.imprimir();

                }
                else if (acumulado >= 3000 && acumulado <= 4999)
                {
                    porciento = +(acumulado * 0.10);
                    Console.WriteLine($"  Usted gano el %10 en puntos con su compra su total es de:    :  {(porciento)}");
                    cliente.imprimir();

                }

                else if (acumulado >= 5000 && acumulado <= 9999)
                {
                    Console.WriteLine("felicidades su pago participa en la promocion de 3,6 ,12meses sin intereses por favor elija su oferta");
                    Console.WriteLine("precione tecla 1 si desea su pago a 3 meses \n tecla 2 si desea pagar a 6 meses \n tecla 3 si desea pagar a 12");
                    Meses meses = new Meses();
                    meses.MenuMeses(acumulado);
                    Console.WriteLine(" \n los datos del cliente son \n ");
                    cliente.imprimir();
                    Meses date = new Meses();
                    date.date();
                }


           

            }


            catch (Exception error)
            {

                throw new Exception("Error de datos ingresados" + error.Message);
            }

        }

    }


}

































