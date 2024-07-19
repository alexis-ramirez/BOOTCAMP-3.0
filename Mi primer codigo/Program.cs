// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World");

//Comentario una linea
/*
 * Comentario varias lineas
 */
//Value Type
int edad = 35;
char mander = 'M';

//References Type
string nombre = "Juan";
string apellido = "Perez";
//Constantes
const double pi = 3.1416;

int numero = 3;//incializa en 0
int numero2 = 3 ;
var resultado = numero + numero2;
var NombreCompleto = nombre + " " + apellido;
Console.WriteLine("El resultado es: " + resultado);
Console.WriteLine();
Console.WriteLine("El nombre completo es " + NombreCompleto);
Console.WriteLine(pi);
Console.WriteLine("Ingrese un numero: ");
int numeroIngresado = int.Parse(Console.ReadLine());

var texto = Console.ReadLine();
var casteo = Convert.ToInt32(texto); //Convierte un string a entero
var casteo2 = int.Parse(texto); 

if (numeroIngresado > 10)
{
    Console.WriteLine("El numero ingresado es mayor a 10");
}
else if (numeroIngresado == 10)
{
    Console.WriteLine("El numero ingresado es 10");
}
else
{
    Console.WriteLine("El numero ingresado es menor a 10");
}