using System;

namespace PolarizadoDeCarros
{
    class Program
    {

        static void Main(string[] args)
        {
            //Identificación del programa
            Console.WriteLine("==============================================");
            Console.WriteLine("CONTROL DE SERVICIO DE POLARIZADO DE AUTOS.");
            Console.WriteLine("==============================================\n");

            //Variables de entrada
            string tecnico;
            int gradoPolarizado;
            string placa;
            int numPolarizados;
            bool tienePolarizadoAnterior;
            bool esReferido;
            bool esDeInstagram;

            //Variables de salida
            double costoPolarizado = 0;
            double descuentoReferido = 0;
            double costoQuitarPolarizado = 0;
            double descuentos;
            double descuentoInstagram = 0;
            double costoTotal;



            Console.Write("Ingrese el nombre del técnico: ");
            tecnico = Console.ReadLine();


            Console.WriteLine("Ingrese el grado de polarizado: ");
            Console.WriteLine("1 - Grado más oscuro");
            Console.WriteLine("2 - Grado legal");
            Console.WriteLine("3 - Grado más claro");
            gradoPolarizado = int.Parse(Console.ReadLine());

            switch (gradoPolarizado)
            {
                case 1:
                    Console.WriteLine("Ha seleccionado la opción 1\n");
                    costoPolarizado = 170;
                    // aquí va el código correspondiente a la opción 1
                    break;
                case 2:
                    Console.WriteLine("Ha seleccionado la opción 2\n");
                    // aquí va el código correspondiente a la opción 2
                    costoPolarizado = 75;
                    break;
                case 3:
                    Console.WriteLine("Ha seleccionado la opción 3\n");
                    costoPolarizado = 130;
                    // aquí va el código correspondiente a la opción 3
                    break;
                default:
                    Console.WriteLine("Opción inválida\n");
                    break;
            }


            Console.Write("Ingrese la placa del carro: ");
            placa = Console.ReadLine();


            Console.Write("\nIngrese el número de polarizados que ha realizado el técnico hoy: ");
            numPolarizados = int.Parse(Console.ReadLine());

            Console.WriteLine("¿El carro tiene un polarizado anterior que debe ser quitado?");
            Console.WriteLine("1 - Sí");
            Console.WriteLine("2 - No");
            tienePolarizadoAnterior = int.Parse(Console.ReadLine()) == 1;

            if (tienePolarizadoAnterior == true)
            {
                costoQuitarPolarizado = costoPolarizado * 0.10;
            }

            Console.WriteLine("¿El cliente fue referido por otro cliente?");
            Console.WriteLine("1 - Sí");
            Console.WriteLine("2 - No");
            esReferido = int.Parse(Console.ReadLine()) == 1;
            if (esReferido == true)
            {
                descuentoReferido = costoPolarizado * 0.05;
            }
            Console.WriteLine("El cliente encontró la información por Instagram?");
            Console.WriteLine("1 - Sí");
            Console.WriteLine("2 - No");
            esDeInstagram = int.Parse(Console.ReadLine()) == 1;
            if (esDeInstagram == true)
            {
                descuentoInstagram = costoPolarizado * 0.02;
            }

            //Proceso de datos
            descuentos = descuentoInstagram + descuentoReferido;
            costoTotal = costoPolarizado + costoQuitarPolarizado - descuentos;


            Console.Clear();
            Console.WriteLine("====SALIDA DE DATOS ====\n");
            Console.WriteLine("Nombre del técnico: {0}\n" +
                "N° de trabajos hechos por el técnico el día de hoy: {1}\n" +
                "Grado de polarizado: {2} \n" +
                "Placa del carro: {3} \n" +
                "Coste de los descuentos aplicados: ${4} \n" +
                "Coste polarizado: ${5}\n" +
                "Total a pagar: ${6}", tecnico, numPolarizados, gradoPolarizado, placa, descuentos, costoPolarizado, costoTotal);
            Console.ReadLine();
        }
    }
}
