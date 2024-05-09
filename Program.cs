using System;

class TrabajoPractico
{
    static void Main()
    {
        // Mensaje de bienvenida
        Console.WriteLine("Bienvenido al proceso de check-in del Aeropuerto Internacional de Córdoba.");

        // Solicitar información al pasajero
        Console.Write("\nIngrese su nombre completo: ");
        string nombreCompletoPasajero = Console.ReadLine();

        Console.Write("\nIngrese su DNI: ");
        string dniPasajero = Console.ReadLine();

        Console.Write("\nIngrese su edad: ");
        int edadPasajero = int.Parse(Console.ReadLine());

        Console.Write("\nIngrese su destino: ");
        string destinoViaje = Console.ReadLine();

        Console.WriteLine("\nSeleccione su clase de vuelo eligiendo uno de los tres números según corresponda:");
        Console.WriteLine("1. Económica");
        Console.WriteLine("2. Ejecutiva");
        Console.WriteLine("3. Primera Clase");
        int claseDeVuelo = int.Parse(Console.ReadLine());
        string nombreClaseVuelo = ".";

        // Asignar nombre a la clase de vuelo seleccionada.
        switch (claseDeVuelo)
        {
            case 1:
                nombreClaseVuelo = "Económica";
                break;
            case 2:
                nombreClaseVuelo = "Ejecutiva";
                break;
            case 3:
                nombreClaseVuelo = "Primera Clase";
                break;
        }

        Console.Write("\n¿Posee equipaje de mano? (Sí: 1, No: 0): ");
        bool tieneEquipajeMano = Console.ReadLine() == "1";

        Console.Write("\n¿Tiene el equipaje en bodega facturado? (Sí: 1, No: 0): ");
        bool tieneEquipajeBodegaFacturado = Console.ReadLine() == "1";

        Console.Write("\n¿Viaja con un perro de servicio? (Sí: 1, No: 0): ");
        bool viajaConPerroServicio = Console.ReadLine() == "1";

        // Si el pasajero es menor a 5 años, se solicita el DNI del adulto responsable.
        if (edadPasajero < 5)
        {
            Console.Write("\nEl pasajero es menor a 5 años. Por favor, escriba el DNI del adulto responsable que lo acompañará: ");
            int dniAdultoMenor5Años = int.Parse(Console.ReadLine());
        }

        // Si el pasajero tiene entre 5 y 11 años, se pregunta si solicita el Servicio de Menor No Acompañado.
        else if (edadPasajero >= 5 && edadPasajero <= 11)
        {
            Console.WriteLine("\nEl pasajero puede viajar solo, si se solicita el Servicio de Menor No Acompañado.");
            Console.Write("¿Solicita usted el servicio? (Sí: 1, No: 0): ");
            bool solicitudServicio = Console.ReadLine() == "1";
            if (solicitudServicio == false)
            {
                Console.Write("El menor deberá viajar con un adulto responsable. Por favor, escriba el DNI del adulto: ");
                int dniAdulto = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("El menor será acompañado por nuestro servicio durante su viaje.");
            }
        }

        // Verificación de la cantidad de equipaje de mano.
        if (tieneEquipajeMano == true)
        {
            Console.Write("\n¿Con cuánta cantidad de equipaje de mano desea viajar? ");
            Console.Write("Escriba aquí la cantidad: ");
            int equipajeManoCantidad = int.Parse(Console.ReadLine());

            // Verificar si excede la cantidad permitida.
            if (equipajeManoCantidad > 3)
            {
                Console.WriteLine("Usted excede la cantidad permitida por pasajero(3). No puede viajar a menos que reduzca esa cantidad.");
                Console.WriteLine("El programa se cerrará.");
                Environment.Exit(0); // Cierra el programa.
            }
            else
            {
                Console.WriteLine("\nUsted puede viajar con su equipaje de mano sin problemas.");
            }
        }

        // Verificación del peso del equipaje no facturado.
        if (tieneEquipajeBodegaFacturado == false)
        {
            Console.Write("\nIndique el peso de su equipaje (kg): ");
            double pesoEquipaje = double.Parse(Console.ReadLine());
            if (pesoEquipaje > 5 && claseDeVuelo == 1)
            {
                double precioAdicionalEconomica = (pesoEquipaje - 5) * 10;
                Console.WriteLine($"El peso total de su equipaje excede el límite permitido por su clase, usted deberá pagar {precioAdicionalEconomica} pesos adicionales.");
            }
            else if (pesoEquipaje > 10 && claseDeVuelo == 2)
            {
                double precioAdicionalEjecutiva = (pesoEquipaje - 10) * 10;
                Console.WriteLine($"El peso total de su equipaje excede el límite permitido por su clase, usted deberá pagar {precioAdicionalEjecutiva} pesos adicionales.");
            }
            else if (pesoEquipaje > 20 && claseDeVuelo == 3)
            {
                double precioAdicionalPrimeraClase = (pesoEquipaje - 20) * 10;
                Console.WriteLine($"El peso total de su equipaje excede el límite permitido por su clase, usted deberá pagar {precioAdicionalPrimeraClase} pesos adicionales.");
            }
            else
            {
                Console.WriteLine("Su equipaje no supera el límite de peso. Puede viajar sin pagar costos adicionales. ");
            }
        }

        //Verificación de requisitos del perro para viajar.
        if (viajaConPerroServicio == true)
        {
            Console.Write("\n¿El perro está identificado con su chaleco o distintivo de servicio? (Sí: 1, No: 0): ");
            bool chalecoPerro = Console.ReadLine() == "1";
            Console.Write("¿El perro trae su accesorio o correa para ser asegurado al cinturón de seguridad? (Sí: 1, No: 0): ");
            bool correaPerro = Console.ReadLine() == "1";
            if (chalecoPerro == false || correaPerro == false)
            {
                Console.WriteLine("Lo sentimos, pero no puede viajar con su perro, ya que no cumple con los requisitos.");
                Console.WriteLine("El programa se cerrará.");
                Environment.Exit(0); // Cierra el programa.
            }
        }

        // Generación número de tarjeta de embarque y fecha de emisión.
        Random random = new Random();
        string letraAleatoria1 = ((char)random.Next('A', 'Z' + 1)).ToString();
        string letraAleatoria2 = ((char)random.Next('A', 'Z' + 1)).ToString();
        string numeroAleatorio1 = random.Next(10000, 99999).ToString();
        string numeroAleatorio = Convert.ToString(numeroAleatorio1);
        string numeroTarjetaEmbarque = letraAleatoria1 + letraAleatoria2 + numeroAleatorio;

        DateTime fechaEmision = DateTime.Now;

        // Mostrar los datos del pasajero, la tarjeta de embarque y la fecha de emisión.
        Console.WriteLine("\nDatos del usuario:");
        Console.WriteLine($"Nombre: {nombreCompletoPasajero}");
        Console.WriteLine($"DNI: {dniPasajero}");
        Console.WriteLine($"Clase de vuelo: {nombreClaseVuelo}");
        Console.WriteLine($"Número de tarjeta de embarque: {numeroTarjetaEmbarque}");
        Console.WriteLine($"Fecha y hora de emisión: {fechaEmision}");

        // Aviso sobre costos adicionales en caso de no haber abonado el equipaje.
        if (tieneEquipajeBodegaFacturado == false)
        {
            Console.WriteLine("Recuerde que si su equipaje supera el límite de su clase, debe abonar un costo extra para poder viajar.");
        }

        // Mensaje de despedida.
        Console.WriteLine($"\n¡Buen viaje hacia {destinoViaje}!");
    }
}