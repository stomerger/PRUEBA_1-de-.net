using System;

namespace AgenciaVehiculos
{
    class Program
    {
        public static void Main(string[] args)
        {
            string contraseña;
            string admin;
            Console.WriteLine("Ingrese nombre: ");
            admin = Console.ReadLine();
            Console.WriteLine("Ingrese contraseña: ");
            contraseña = Console.ReadLine();

            while (contraseña !="abc1234" || admin != "admin")
            {
                Console.WriteLine("Fallo al iniciar sesion");
                Console.WriteLine("Ingrese usuario: ");
                admin = Console.ReadLine();
                Console.WriteLine("Ingrese contraseña: ");
                contraseña = Console.ReadLine();
            }
            int opcion = 0;

            
            Automovil vehiculo = new Automovil("Nissan",2019,1500,123, TipoMotor.CUATRO_TIEMPOS, 200,
                            3, TipoRecubrimiento.POLIUTERANO, 150, 200, TipoMezclador.INYECTOR, 8);

            do
            {
                Console.WriteLine("Eliga una opcion:\n" +
                "1. Mostrar datos" + "\n" +
                "2. Salir");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        string infoAutomovil = string.Format(
                            "Marca: {0}\n" +
                            "Año automovil: {1}\n" +
                            "Kilometraje: {2} km\n" +
                            "Id motor: {3}\n" +
                            "Tipo de motor: {4}\n" +
                            "Cilindrada: {5} cc\n" +
                            "Numero de ruedas: {6}\n" +
                            "Tipo de recubrimiento: {7}\n" +
                            "Minimo durometro: {8}\n" +
                            "Maximo durometro: {9}\n" +
                            "Tipo mezclador: {10}\n" +
                            "Capacidad estanque: {11} litros\n",
                            vehiculo.Marca,vehiculo.Año,vehiculo.Kilometraje,
                            vehiculo.Motor.ID, vehiculo.Motor.tipo, vehiculo.Motor.Cilindrada,
                            vehiculo.Ruedas.Length, vehiculo.Ruedas[0].Recubrimiento.ToString(),
                            vehiculo.Ruedas[0].Durometro[0],vehiculo.Ruedas[0].Durometro[1],
                            vehiculo.Mezclador.Tipo,vehiculo.Estanque.Capacidad);
                        Console.WriteLine(infoAutomovil);
                        break;
                    case 2:
                        Console.WriteLine("Saliendo de la aplicación...");
                        break;
                    default:
                        Console.WriteLine("Ingrese un numero valido");
                        break;
                }
                Console.ReadKey();
            } while (opcion != 2);
            
        }
    }
}
