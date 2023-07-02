using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examenu1MuñozFernando.servicios
{
    public  class Meses
    {


        public void MenuMeses(float acumulado)
        {
            double porciento = 0;
            float div = 0;

            string op = Console.ReadLine();

            switch (op)
            {
                case "1":
                    float resultado =Meses3(acumulado);
                    Console.WriteLine($"\n su pago a 3 meses sera de : {( resultado)}");
                    break;
                    

                case "2":
                    div = (acumulado / 6);
                    Console.WriteLine($"\n su pago a 6 meses sera de : {(div)}");
                    break;

                case "3":
                    div = (acumulado / 12);
                    Console.WriteLine($"\n su pago a 12 meses será de :{(div)}");
                    break;
            }

            return;
        }
        public void date()
        {
            DateTime currentDateTime = DateTime.Now;
            string formattedDateTime = currentDateTime.ToString("dddd, dd MMMM yyyy HH:mm:ss");
            Console.WriteLine(" \n Fecha de la compra : \n" + formattedDateTime);
        }


        public float Meses3(float acumulado)
        {
          
            return acumulado / 3;

        }

        public float Meses6(float acumulado)
        {
            
            return acumulado/6;
        }

        public float Meses12(float acumulado)
        {
      
                return acumulado / 12;
        }
    }
}
