using System;
class TrabajoPractico
{
    static void Main()
    {
        Console.WriteLine("Bienvenido al proceso de check-in del Aeropuerto Internacional de Córdoba.");
        
        Console.Write("Ingrese su nombre completo: ");
        string nombrecompletoPasajero = Console.ReadLine();

        Console.Write("Ingrese su DNI sin puntos: ");
        int dniPasajero = int.Parse(Console.ReadLine());

        Console.Write("Ingrese su edad: ");
        int edadPasajero = int.Parse(Console.ReadLine());

        Console.Write("Ingrese su destino: ");
        string destinoViaje = Console.ReadLine();

        Console.WriteLine("Seleccione su clase de vuelo eligiendo uno de los tres números según corresponda:");
        Console.WriteLine("1. Económica");
        Console.WriteLine("2. Ejecutiva");
        Console.WriteLine("3. Primera Clase");

        int clasedeVuelo= int.Parse(Console.ReadLine());

        Console.Write("¿Posee equipaje de mano? (Sí: 1, No: 0): ");
        bool tieneEquipajeMano = Console.ReadLine() == "1";

        Console.Write("¿Tiene el equipaje en bodega facturado? (Sí: 1, No: 0): ");
        bool tieneEquipajeBodega = Console.ReadLine() == "1";

        Console.Write("¿Viaja con un perro de servicio? (Sí: 1, No: 0): ");
        bool viajaConPerroServicio = Console.ReadLine() == "1";
    }
}