/*Crear una aplicación simple de consola para el siguiente escenario:

Escenario: Weather Forecast Mejorado(para una Estación Meteorológica)

Una estación meteorológica necesita gestionar y procesar datos de temperatura 
del interior de la cabina para un mes completo (31 días). 
Los datos deben registrarse en una colección tipo matriz, 
donde las filas representan las semanas, y las columnas los días. 
Se requiere implementar varias funcionalidades para gestionar y procesar estos datos.

Para este ejercicio, se deben utilizar:
Una  5 x 7 para almacenar las temperaturas diarias del mes.
Una  para almacenar las temperaturas promedio de cada semana.
Una  para almacenar las temperaturas por encima de un cierto umbral.
Requerimientos:
Implementar un algoritmo principal que permita la carga inicial de todas las temperaturas del mes, 
31 días (Puedes pedirle al usuario que cargue día por día, o bien simular la carga total de temperaturas). 
No importa si sobran lugares en la matriz al final, sólo deberemos usar 31 lugares.
Luego mostrar al usuario un menú con las opciones (Ver siguiente). 
El usuario elije una opción y luego se le da la opción de elegir si quiere otra opción o salir, 
y así sucesivamente hasta que elija salir.
Opción para ver temperatura de un día específico: Aquí vamos a usar lo del escenario anterior 
pero cambiándole el mensaje. Basándose en la temperatura del día elegido, 
la aplicación debería mostrar la temperatura y un mensaje:
 Si la temperatura es inferior a 0, mostrar "Hizo mucho frío."
 
 Si la temperatura está entre 0 y 20, mostrar "El clima estaba fresco."
 
 Si la temperatura es superior a 20, mostrar "Hizo calor afuera."
Opción para calcular y ver temperaturas promedios de cada semana. 
Aqui debes usar otra colección para el almacenamiento.Opción para encontrar y 
ver temperaturas por encima de 20° (Umbral). Aquí también debes usar 
otra colección para el almacenamiento.Opción para ver la temperatura promedio del mes. 
Aquí puedes usar la matriz principal o la colección de promedios de cada semana.
Opción para ver la temperatura más alta. Aquí debes usar la matriz principal.
Opción para ver la temperatura más baja. Aquí debes usar la matriz principal.
Opción para ver el pronóstico de 5 días posteriores al mes. 
Aquí también debes implementar lo del ejercicio anterior, 
sólo que puedes mejorar el código colocando la funcionalidad en una opción aparte.Opción para Salir.
Implementar una función para añadir las temperaturas diarias.
Implementar una función para calcular las temperaturas promedio de cada semana y almacenarlas en una colección.
Implementar una función para encontrar las temperaturas por encima de un umbral (20°) 
y almacenarlas en una colección.
Implementar una función para calcular la temperatura promedio del mes.
Implementar una función para encontrar la temperatura más alta y la más baja.
Utilizar una matriz 5x7 para almacenar las temperaturas diarias del mes.
Utilizar una colección adecuada para almacenar las temperaturas promedio de cada semana.
Utilizar una colección que creas más conveniente para almacenar las temperaturas por encima de un cierto umbral.
*/
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
int[,] temp = new int[5, 7];
Random random = new Random();
int num;
for (int i = 0; i < 5; i++)
{
    if (i == 4)
    {
        for (int j = 0; j < 3; j++)
        {
            num = random.Next(-9, 50);
            temp[i, j] = num;
        }
    }
    else
    {
        for (int j = 0; j < 7; j++)
        {
            num = random.Next(-20, 50);
            temp[i,j] = num;
        }
    }
}
string resp;
do
{
    Console.Clear();
    //Muestro las temperaturas mensuales para poder ir controlando los valores que calculo
    string[] dias = { "L", "M", "M", "J", "V", "S", "D" };
    foreach (string di in dias)
    {
        Console.Write($"{di,4}");
    }
    Console.WriteLine();
    for (int i = 0; i < 5; i++)
    {
        if (i == 4)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"{temp[i, j],4}");
            }
        }
        else
        {
            for (int j = 0; j < 7; j++)
            {
                Console.Write($"{temp[i, j],4}");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine("----------------------------------------------------");
    Console.WriteLine("------------------------MENU------------------------");
    Console.WriteLine("1. Para ver la temperatura de un día especifico.");
    Console.WriteLine("2. Para ver el promedio semanal.");
    Console.WriteLine("3. Para ver las temperaturas por encima de 20° ");
    Console.WriteLine("4. Para ver el promedio del mes");
    Console.WriteLine("5. Para ver las temparturas máximas y mínimas");
    Console.WriteLine("s. Para salir");
    Console.WriteLine("----------------------------------------------------");
    Console.WriteLine("----------------------------------------------------");
    resp = Console.ReadLine().ToLower();
    switch (resp){
        case "1":
            MostraTemp(temp);
            break;
        case "2":
            CalTempSem(temp);
            break;
        case "3":
            Vertem20(temp);
            break;
        case "4":
            PromMes(temp); 
            break;
        case "5":
            MaxyMin(temp); 
            break;
        case "s":
            break;
        default: 
            Console.WriteLine("Opción incorrecta, precione una tecla para continuar...");
            Console.ReadKey();
            break;
    }
} while (resp != "s");

static void MostraTemp(int[,]temp)
{
        int temp2;
        Console.WriteLine("Ingrese día que quiere ver del 1 al 31");
        string temp1 = Console.ReadLine();
        temp2 = ComprobarNumero(temp1);
        while (temp2 > 31 || temp2 <= 0) 
        {
            Console.WriteLine("Error, ingrese un numero del 1 al 31");
            temp1 = Console.ReadLine();
            temp2 = ComprobarNumero(temp1);
        }
            int i = temp2 / 7;
            int j= temp2 % 7;
            Console.Write(temp[i,j-1]+"° ");
            if (temp[i, j - 1] < 0)
            {
                Console.WriteLine("Hizo mucho frío");
            }else if(temp[i, j] >= 0 && temp[i,j-1]<=20)
            {
                Console.WriteLine("El Clima estaba fresco");
            }
            else
            {
                Console.WriteLine("Hizo calor afuera");
            }
        Fin();
}
static void CalTempSem(int[,]temp)
{
    float[] promedioSemanal = new float[5];
    for (int i = 0; i < 5; i++)
    {
        if (i == 4)
        {
            for (int j = 0; j < 3; j++)
            {
                promedioSemanal[i] = promedioSemanal[i] + temp[i, j];
            }
            promedioSemanal[i] = promedioSemanal[i] / 3;
            Console.WriteLine("El promedio de la semana " + (i + 1) + " es " + Math.Round(promedioSemanal[i], 2) + "°");
        }
        else
        {
            for (int j = 0; j < 7; j++)
            {
                promedioSemanal[i] = promedioSemanal[i] + temp[i, j] ;
            }
            promedioSemanal[i] = promedioSemanal[i] / 7;
            Console.WriteLine("El promedio de la semana " + (i + 1) + " es " + Math.Round(promedioSemanal[i], 2) + "°");
        }
        Console.WriteLine();
    }
    Fin();
}
static void Vertem20(int[,] temp)
{
    List<int> TempAlt= new List<int>();
    for (int i = 0;i < 5;i++)
    {
        for(int j = 0;j < 7; j++)
        {
            if(temp[i,j] > 20)
            {
                TempAlt.Add(temp[i,j]);
            }
        }
    }
    foreach (int tempe in TempAlt)
    {
        Console.Write(tempe + "° ");
    }
    Console.WriteLine();
    Fin();
}
static void PromMes(int[,] temp)
{
    double  suma=0;
    for (int i = 0; i < 31; i++)
    {
        int semana = i / 7;
        int dia = i % 7;
        suma += temp[semana, dia];
    }
    double promedio = suma / 31;
    Console.WriteLine("El promedio del mes es: " + promedio + "°");
    Fin();
}
static void MaxyMin(int[,] temp)
{
    int Max = 0;
    int Min = 99;
    for (int i = 0; i < 31; i++)
    {
        int semana = i / 7;
        int dia = i % 7;
        if (temp[semana, dia] < Min)
        {
            Min = temp[semana, dia];
        }
        if (temp[semana, dia] > Max)
        {
            Max = temp[semana, dia];
        }
    }
    Console.WriteLine("La temperatura Maxima fue: " + Max + "°");
    Console.WriteLine("La temperatura Minima fue: " + Min + "°");
    Fin();
}
static int ComprobarNumero(string num)
{
    int numv;

    while (true)
    {
        if (int.TryParse(num, out numv))
        {
            return numv;
        }
        Console.WriteLine("Error! Ingresar un numero: ");
        num = Console.ReadLine();
    }
    Fin();
}
static void Fin()
{
    Console.WriteLine("Precione una tecla para volver al menu: ");
    Console.ReadKey();
    Console.Clear();
}