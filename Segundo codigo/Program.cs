/*1. Solicitar al usuario que introduzca la temperatura actual (en grados Celsius).
2. Basándose en la temperatura introducida, la aplicación debería mostrar un mensaje:
   - Si la temperatura es inferior a 0, mostrar "Hace mucho frío afuera, asegúrate de abrigarte bien."
   - Si la temperatura está entre 0 y 20, mostrar "El clima está fresco, una chaqueta ligera sería perfecta."
   - Si la temperatura es superior a 20, mostrar "Hace calor afuera, no necesitas una chaqueta."
3. Luego, la aplicación debería preguntar al usuario si quiere conocer el pronóstico para 
los próximos cinco días (sí/no).
4. Si el usuario responde 'sí', la aplicación debería generar y mostrar un pronóstico simple. 
5. Finalmente, la aplicación debería preguntar al usuario si quiere consultar otro pronóstico. 
Si el usuario responde 'sí', la aplicación debería comenzar de nuevo. Si el usuario responde 'no', 
la aplicación debería mostrar un mensaje de despedida y terminar.
 */
String resp="si";
int temp;
do
{
    if (resp =="si")
    {
        Console.WriteLine("Ingrese la temperatura: ");
        resp = Console.ReadLine();
        while (true)
        {
            if (int.TryParse(resp, out temp))
            {
                break;
            }
            else
            {
                Console.WriteLine("Error! Ingrese un numero: ");
                resp = Console.ReadLine();
            }
        }
        if (temp <= 0)
        {
            Console.WriteLine("Hace mucho frio afuera, asegúrate de abrigarte bien.");
        }
        else if (temp > 0 && temp < 21)
        {
            Console.WriteLine("El clima está fresco, una chaqueta ligera sería perfecta.");
        }
        else
        {
            Console.WriteLine("Hace calor afuera, no necesitas una chaqueta.");
        }
        Console.WriteLine("¿Desea conocer el pronostico para los próximos 5 días? si/no");
        resp = Console.ReadLine().ToLower();
        if (resp == "si")
        {
            Console.WriteLine("Lunes 20°");
            Console.WriteLine("Martes 22°");
            Console.WriteLine("Miercoles 21°");
            Console.WriteLine("Jueves 23°");
            Console.WriteLine("Viernes 25°");
        }
        else
        {
            while (resp != "no")
            {
                if (resp == "si")
                {
                    Console.WriteLine("Lunes 20°");
                    Console.WriteLine("Martes 22°");
                    Console.WriteLine("Miercoles 21°");
                    Console.WriteLine("Jueves 23°");
                    Console.WriteLine("Viernes 25°");
                    break;
                }
                Console.WriteLine("Opcion incorrecta: ");
                Console.WriteLine("¿Desea conocer el pronostico para los próximos 5 días? si/no");
                resp = Console.ReadLine().ToLower();
            }
        }
    }
    Console.WriteLine("¿Desea consultar otro pronostico? si/no" );
     resp = Console.ReadLine().ToLower();
} while (resp != "no");
Console.WriteLine("Saliendo...");
