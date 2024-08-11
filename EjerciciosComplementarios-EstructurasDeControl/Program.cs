string resp;
do
{
    Console.WriteLine("--------------------MENU------------------------");
    Console.WriteLine("------------------------------------------------");
    Console.WriteLine("Seleccione una opcion: ");
    Console.WriteLine("1. Ejercicio 1");
    Console.WriteLine("2. Ejercicio 2");
    Console.WriteLine("3. Ejercicio 3");
    Console.WriteLine("4. Ejercicio 4");
    Console.WriteLine("5. Ejercicio 5");
    Console.WriteLine("6. Ejercicio 6");
    Console.WriteLine("7. Ejercicio 7");
    Console.WriteLine("8. Ejercicio 8");
    Console.WriteLine("9. Ejercicio 9");
    Console.WriteLine("10. Ejercicio 10");
    Console.WriteLine("11. Ejercicio 11");
    Console.WriteLine("12. Ejercicio 12");
    Console.WriteLine("13. Ejercicio 13");
    Console.WriteLine("14. Ejercicio 14");
    Console.WriteLine("15. Ejercicio 15");
    Console.WriteLine("16. Ejercicio 16");
    Console.WriteLine("17. Ejercicio 17");
    Console.WriteLine("18. Ejercicio 18");
    Console.WriteLine("19. Ejercicio 19");
    Console.WriteLine("20. Ejercicio 20");
    Console.WriteLine("21. Ejercicio 21");
    Console.WriteLine("s para Salir");
    Console.WriteLine("------------------------------------------------");
    Console.WriteLine("------------------------------------------------");
    resp = Console.ReadLine().ToLower();
    switch (resp)
    {
        case "1":
            Console.Clear();
            Console.WriteLine("Ejercicio 1");
            Ejer1();
            break;
        case "2":
            Console.Clear();
            Console.WriteLine("Ejercicio 2");
            Ejer2();
            break;
        case "3":
            Console.Clear();
            Ejer3();
            Console.WriteLine("Ejercicio 3");
            break;
        case "4":
            Console.Clear();
            Console.WriteLine("Ejercicio 4");
            Ejer4();
            break;
        case "5":
            Console.Clear();
            Console.WriteLine("Ejercicio 5");
            Ejer5();
            break;
        case "6":
            Console.Clear();
            Console.WriteLine("Ejercicio 6");
            Ejer6();
            break;
        case "7":
            Console.Clear();
            Console.WriteLine("Ejercicio 7");
            Ejer7();
            break;
        case "8":
            Console.Clear();
            Console.WriteLine("Ejercicio 8");
            Ejer8();
            break;
        case "9":
            Console.Clear();
            Console.WriteLine("Ejercicio 9");
            Ejer9();
            break;
        case "10":
            Console.Clear();
            Console.WriteLine("Ejercicio 10");
            Ejer10();
            break;
        case "11":
            Console.Clear();
            Console.WriteLine("Ejercicio 11");
            Ejer11();
            break;
        case "12":
            Console.Clear();
            Console.WriteLine("Ejercicio 12");
            Ejer12();
            break;
        case "13":
            Console.Clear();
            Console.WriteLine("Ejercicio 13");
            Ejer13();
            break;
        case "14":
            Console.Clear();
            Console.WriteLine("Ejercicio 14");
            Ejer14();
            break;
        case "15":
            Console.Clear();
            Console.WriteLine("Ejercicio 15");
            Ejer15();
            break;
        case "16":
            Console.Clear();
            Console.WriteLine("Ejercicio 16");
            Ejer16();
            break;
        case "17":
            Console.Clear();
            Console.WriteLine("Ejercicio 17");
            Ejer17();
            break;
        case "18":
            Console.Clear();
            Console.WriteLine("Ejercicio 18");
            Console.Clear();
            Ejer18();
            break;
        case "19":
            Console.Clear();
            Console.WriteLine("Ejercicio 19");
            Ejer19();
            break;
        case "20":
            Console.Clear();
            Console.WriteLine("Ejercicio 20");
            Ejer20();
            break;
        case "21":
            Console.Clear();
            Console.WriteLine("Ejercicio 21");
            Ejer21();
            break;
        case "s":
            Console.WriteLine("Saliendo...");
            break;
        default:
            Console.WriteLine("Opcion incorrecta");
            break;
    }
} while (resp != "s");


static void Ejer1()
{
    string num;
    int numv;
    Console.WriteLine("Enunciado: ");
    Console.WriteLine("1. Dado un valor, devolver un mensaje que diga " +
        "“El valor es mayor que 100” sólo cuando se cumpla dicha condición.\r\n");
    Console.WriteLine("Ingrese un numero: ");
    num = (Console.ReadLine());
    numv = ComprobarNumero(num);
    if (numv > 100)
    {
        Console.WriteLine("El número es mayor que 100");
    }
    Fin();
}
static void Ejer2()
{
    string num;
    int numv;
    Console.WriteLine("Consigna:");
    Console.WriteLine("2. Pedir un número entero por teclado y calcular si es par o impar.");
    Console.WriteLine("Ingrese un número");
    num = Console.ReadLine();
    numv = ComprobarNumero(num);
    if (numv % 2 == 0)
    {
        Console.WriteLine("El numero ingresado " + numv + " es par");
    }
    else
    {
        Console.WriteLine("El numero ingresado " + numv + " es impar");
    }
    Fin();
}
static void Ejer3()
{
    int numv;
    string num;
    Console.WriteLine("Consigna:");
    Console.WriteLine("3. Teniendo un valor entero, verificar si se cumple o no que ese valor " +
        "es el doble de un impar. Por ejemplo, 14 cumple con esta condición.");
    Console.WriteLine("Ingrese un número");
    num = Console.ReadLine();
    numv = ComprobarNumero(num);
    if ((numv / 2) % 2 != 0)
    {
        Console.WriteLine("El numero ingresado es el doble de un impar");
    }
    else
    {
        Console.WriteLine("El numero ingresado no es el doble de un impar");
    }
    Fin();

}
static void Ejer4()
{
    int numv;
    string num;
    Console.WriteLine("Consigna: ");
    Console.WriteLine("4. Dada un número del 1 al 10, devolver su “versión” en números romanos.");
    Console.WriteLine("Ingrese un número del 1 al 10.");
    num = Console.ReadLine();
    numv = ComprobarNumero(num);
    switch (numv)
    {
        case 1:
            Console.WriteLine("El número ingresado es " + numv + " y su version romana es I");
            break;
        case 2:
            Console.WriteLine("El número ingresado es " + numv + " y su version romana es II");
            break;
        case 3:
            Console.WriteLine("El número ingresado es " + numv + " y su version romana es III");
            break;
        case 4:
            Console.WriteLine("El número ingresado es " + numv + " y su version romana es IV");
            break;
        case 5:
            Console.WriteLine("El número ingresado es " + numv + " y su version romana es V");
            break;
        case 6:
            Console.WriteLine("El número ingresado es " + numv + " y su version romana esVI");
            break;
        case 7:
            Console.WriteLine("El número ingresado es " + numv + " y su version romana es VII");
            break;
        case 8:
            Console.WriteLine("El número ingresado es " + numv + " y su version romana es VII");
            break;
        case 9:
            Console.WriteLine("El número ingresado es " + numv + " y su version romana es IX");
            break;
        case 10:
            Console.WriteLine("El número ingresado es " + numv + " y su version romana es X");
            break;
        default:
            Console.WriteLine("El número ingresado es mayor a 10...");
            break;
    }
    Fin();
}
static void Ejer5()
{
    string nombre1, edad1, nombre2, edad2;
    int edad1v, edad2v;
    Console.WriteLine("Consigna: ");
    Console.WriteLine("5.Leer el nombre y las edades de dos personas y devolver el nombre del menor." +
        "En caso de que tengan la misma edad también debe indicarse." +
        "Devolver también la diferencia de edad en caso de corresponder");
    Console.WriteLine("nombre persona 1: ");
    nombre1 = Console.ReadLine();
    Console.WriteLine("edad persona 1: ");
    edad1 = Console.ReadLine();
    edad1v = ComprobarNumero(edad1);
    Console.WriteLine("nombre persona 2: ");
    nombre2 = Console.ReadLine();
    Console.WriteLine("edad persona 2: ");
    edad2 = Console.ReadLine();
    edad2v = ComprobarNumero(edad2);
    if (edad1v < edad2v)
    {
        Console.WriteLine(nombre1 + " es el menor con " + edad1v);
        Console.WriteLine("La resta de sus edades es: " + (edad2v - edad1v));

    }
    else if (edad1v > edad2v)
    {
        Console.WriteLine(nombre2 + " es el menor con " + edad2v);
        Console.WriteLine("La resta de sus edades es: " + (edad1v - edad2v));
    }
    else
    {
        Console.WriteLine("Los nombres ingresados tienen la misma edad");
        Console.WriteLine(nombre1 + " y " + nombre2 + " tiene la misma edad con " + edad1v);
    }
    Fin();
}
static void Ejer6()
{
    string lado1, lado2, lado3;
    int lado1v, lado2v, lado3v;
    Console.WriteLine("Consigna: ");
    Console.WriteLine("6. Escribir un programa que calcule el tipo de un triángulo conociendo ");
    Console.WriteLine( "la longitud de sus 3 lados. " +
        "También que calcule su perímetro y su área.");
    Console.WriteLine("Ingrese los lados de su tringulo");
    Console.WriteLine("Lado 1: ");
    lado1 = Console.ReadLine();
    lado1v = ComprobarNumero(lado1);
    Console.WriteLine("Lado 2: ");
    lado2 = Console.ReadLine();
    lado2v = ComprobarNumero(lado2);
    Console.WriteLine("Lado 3: ");
    lado3 = Console.ReadLine();
    lado3v = ComprobarNumero(lado3);
    if (lado1v == lado2v && lado1v == lado3v)
    {
        Console.WriteLine("El tringualo es Equilatero");
    }
    else if (lado1v == lado2v && lado1v != lado3v || lado2v == lado3v && lado1v != lado3v || lado1v == lado3v && lado1v != lado2v)
    {
        Console.WriteLine("El tringualo es Isósceles");
    }
    else
    {
        Console.WriteLine("El traingulo es Escaleno");
    }
    int perm = lado1v + lado2v + lado3v;
    Console.WriteLine("El permitro es " + perm);
    double semiperimetro = perm / 2.0;
    double area = Math.Sqrt(semiperimetro * (semiperimetro - lado1v) * (semiperimetro - lado2v) * (semiperimetro - lado3v));
    Console.WriteLine("El área es: " + area);
    Fin();
}
static void Ejer7()
{
    string vuelto;
    int vueltov,billeteb;
    Console.WriteLine("Consigna: ");
    Console.WriteLine("7. Desarrolle un programa que calcule el desglose de una cantidad dada, ");
    Console.WriteLine("en billetes y monedas tal que se minimice la cantidad de monedas y billetes. ");
    Console.WriteLine("Considere las denominaciones $1000, $500, $100, $50, $20, $10, $5, $2, $1, " +
        "donde los últimos tres son monedas. ");
    Console.WriteLine("Por ejemplo, para $1,723 se debe imprimir: “1 billete de $1000");
    Console.WriteLine("1 billete de $500, 1 billete de $200, 1 billete de $20, 1 moneda de $2, 1 moneda de $1");
    Console.WriteLine("Obviar los signos de billete ($) y tratar todos los valores como números, para los cálculos.\r\n");
    Console.WriteLine();
    Console.WriteLine("Ingrese el vuelto a dar: ");
    vuelto = Console.ReadLine();
    vueltov= ComprobarNumero(vuelto);
    int[] billetes = new int[9] {1000, 500, 100, 50, 20, 10, 5, 2, 1};
    while(vueltov != 0)
    {
       
        for (int i=0;i<billetes.Length; i++)
        {
            int cambio = 0;
            billeteb = 0;
            while (vueltov >= billetes[i])
            {
                vueltov = vueltov-billetes[i];
                cambio++;
                billeteb = billetes[i];
            }
            Console.WriteLine(cambio + " billetes " + "$" + billeteb);
        }
    }
    Fin();
}
static void Ejer8()
{
    Console.WriteLine("Consigna : ");
    Console.WriteLine("8. Pide un número N, y muestra todos los números del 1 al N.");
    Console.WriteLine("Ingrese un numero: ");
    string num = Console.ReadLine();
    int numv = ComprobarNumero(num);
    if(numv > 0)
    {
        for(int i = 1; i<=numv; i++)
        {
            Console.WriteLine(i);
        }
    }
    Fin();
}
static void Ejer9()
{
    int acu = 0;
    Console.WriteLine("Consigna: ");
    for (int i = 0; i < 15; i++)
    {
        Console.WriteLine("Ingrese un numero: ");
        string num = Console.ReadLine();
        int numv = ComprobarNumero(num);
        acu = acu + numv;
    }
    Console.WriteLine("Lo acumulado es: "+acu);
    Fin();
}
static void Ejer10()
{
    Console.WriteLine("Consigna: ");
    Console.WriteLine("10. Pide 5 números e indica si alguno es múltiplo de 3.");
    for(int i = 0; i < 5; i++)
    {
        Console.WriteLine("Ingrese un numero");
        string num = Console.ReadLine();
        int numv = ComprobarNumero(num);
        if (numv % 3 == 0)
        {
            Console.WriteLine("El numero" + numv + "es divisible por 3");
        }
    }
    Fin();
}
static void Ejer11() {
    Console.WriteLine("Consigna: ");
    Console.WriteLine("11. Escriba un programa que solicite una contraseña ");
    Console.WriteLine("el texto de la contraseña no es importante) y la vuelva a solicitar hasta que las dos contraseñas coincidan.");
    Console.WriteLine("Ingrese una contraseña: ");
    string pass = Console.ReadLine();
    Console.WriteLine("Vuelva a escribir la constraseña: ");
    string pass2 = Console.ReadLine();
    while (pass != pass2)
    {
        Console.WriteLine("Las contraseñas no coínciden vuleva a ingresar la contraseña");
        Console.WriteLine("Ingrese una contraseña: ");
        pass = Console.ReadLine();
        Console.WriteLine("Vuelva a escribir la constraseña: ");
        pass2 = Console.ReadLine();
    }
    Console.WriteLine("Contraseña Correcta!");
    Fin();
}
static void Ejer12()
{
    string pass, pass2;
    Console.WriteLine("12. Mismo que el anterior pero con un límite de tres peticiones. ");
    Console.WriteLine("Luego de las tres peticiones no debe solicitar más la contraseña y terminar el programa.");
    Console.WriteLine("Ingrese su contraseña: ");
    pass = Console.ReadLine();
    Console.WriteLine("Ingrese de nuevo su contraseña");
    pass2 = Console.ReadLine();
    int band = 3;
    while (pass != pass2 && band > 0)
    {
        Console.WriteLine("Error, las contraseñas no coiciden");
        Console.WriteLine("Le quedan " + band + " intentos");
        Console.WriteLine("Ingrese su contraseña: ");
        pass = Console.ReadLine();
        Console.WriteLine("Ingrese de nuevo su contraseña");
        pass2 = Console.ReadLine();
        band--;
    }
    if(pass == pass2)
    {
        Console.WriteLine("Ingreso correctamente");
    }else if(band == 0) 
    {
        Console.WriteLine("Usuario Bloqueado, supero el numero de intentos");
    }
    Fin();
}
static void Ejer13()
{
    Console.WriteLine("Consigna: ");
    Console.WriteLine("13. Proponer al usuario que adivine un número a base de intentarlo.");
    Console.WriteLine("Ingrese un numero entre el 1 y el 100");
    string num = Console.ReadLine();
    int numv = ComprobarNumero(num);
    Random random= new Random();
    int numr = random.Next(100);
    Console.WriteLine(numr);
    int intento = 1;
    while(numr != numv && numv <101)
    {
        Console.WriteLine("Mala suerte, sigue intentando...");
        Console.WriteLine("Si deseas rendirte elige un numero mayor a 100");
        num = Console.ReadLine();
        numv = ComprobarNumero(num);
        intento++;
    }
    if (numv == numr)
    {
        Console.WriteLine("Felicidades advinas el numero " + numr + " en " + intento + " intentos");
    }else
    {
        Console.WriteLine("Suerte la proxima, el numero era " + numr + " la cantidad de intentos utilizados fueron "+ intento);
    }
    Fin();
}
static void Ejer14()
{
    Console.WriteLine("Consigna: ");
    Console.WriteLine("14. Modificar el programa anterior para que vaya dando pistas del tipo «mayor» o «menor».");
    Random random = new Random();
    int num = random.Next(100);

    Console.WriteLine(num);
    Console.WriteLine("Ingrese un numero del 1 al 100");
    string num1 = Console.ReadLine();
    int numv = ComprobarNumero(num1);
    int intentos = 1;
    while (numv != num &&numv < 101)
    {
        if (numv < num)
        {
            Console.WriteLine("El numero ingresado es más chico");
            Console.WriteLine("Si se da por vencido escriba un numero mayor a 100");
            Console.WriteLine("Ingrese un numero del 1 al 100");
            num1 = Console.ReadLine();
            numv = ComprobarNumero(num1);
        }
        else
        {
            Console.WriteLine("El numero ingresado es más grande");
            Console.WriteLine("Si se da por vencido escriba un numero mayor a 100");
            Console.WriteLine("Ingrese un numero del 1 al 100");
            num1 = Console.ReadLine();
            numv = ComprobarNumero(num1);
        }
        intentos++;
    }
    if (numv == num)
    {
        Console.WriteLine("El numero fue encontrado y es el " + num +" y la cantidad de intentos fueron " + intentos);
    }
    Fin();
}
static void Ejer15()
{
    int num2;
    int sum = 0;
    Console.WriteLine("Consigna: ");
    Console.WriteLine("15. Crea un programa que permita sumar N números. ");
    Console.WriteLine("El usuario decide cuándo termina de introducir números al indicar la palabra ‘fin’");
    Console.WriteLine("Ingrese un numero para sumarlo, si desea finalizar la suma introducir 'fin'");
    string num= Console.ReadLine().ToLower();
    while (true)
    {
        if(int.TryParse(num,out num2)){
            sum = sum + num2;
            break;
        }else if(num == "fin")
        {
            sum = sum + num2;
            break;
        }
        else
        {
            Console.WriteLine("Error! Ingrese un numero para sumarlo, si desea finalizar la suma introducir 'fin'");
            num = Console.ReadLine().ToLower();
        }
    }
    while(num != "fin")
    {
        Console.WriteLine("El usuario decide cuándo termina de introducir números al indicar la palabra ‘fin’");
        Console.WriteLine("Ingrese un numero para sumarlo, si desea finalizar la suma introducir 'fin'");
        num = Console.ReadLine().ToLower();
        while (true)
        {
            if (int.TryParse(num, out num2))
            {
                sum = sum + num2;
                break;
            }
            else if (num == "fin")
            {
                break;
            }
            else
            {
                Console.WriteLine("Error! Ingrese un numero para sumarlo, si desea finalizar la suma introducir 'fin'");
                num = Console.ReadLine().ToLower();
            }
        }
;
    }
    Console.WriteLine("La sumatoria es: " + sum);
    Fin();
}
static void Ejer16()
{
    Console.WriteLine("Consigna: ");
    Console.WriteLine("16. Crea un programa que solicite al usuario una cadena de texto ");
    Console.WriteLine("y que verifique si es o no un palíndromo");
    Console.WriteLine("Ingrese un texto para saber si es palindromo");
    string pal=Console.ReadLine().ToLower();
    string palinv = string.Empty;
    char[] chars = pal.ToCharArray();
    for(int i= chars.Length-1; i >= 0; i--)
    {
        palinv += chars[i];
    }
    if (pal == palinv)
    {
        Console.WriteLine("Es palindromo");
    }
    else
    {
        Console.WriteLine("No es palindromo");
    }
    Fin();
}
static void Ejer17()
{
    Console.WriteLine("Consigna: "); //se lo podría hacer recursivo también.
    Console.WriteLine("17. Pide al usuario un número x y calcula su factorial");
    Console.WriteLine("Ingrese un número: ");
    string num = Console.ReadLine();
    int numv = ComprobarNumero(num);
    int fact = 1;
    for (int i = 1; i < numv; i++)
    {
        fact = fact+fact * i;
    }
    Console.WriteLine("El factorial del numero " + numv + " es " + fact);
    Fin();
}
static void Ejer18()
{
    Console.WriteLine("Consigna: ");
    Console.WriteLine("18. Crea un programa que convierta una temperatura en grados Celsius");
    Console.WriteLine("Fahrenheit o viceversa según la elección del usuario.");
    string temp;
    int tempv ,convert;
    string resp;
    do
    {
        Console.WriteLine("Escriba el tipo de temperatura al que desea convertir: Celsius c/Fahrenheit f ");
        resp = Console.ReadLine().ToLower();
       

        if (resp == "c")
        {
            Console.WriteLine("Ingresa la temperatura: ");
            temp = Console.ReadLine();
            tempv = ComprobarNumero(temp);
            convert = (tempv - 32) * 5 / 9;
            Console.WriteLine($"Temperatura en Celsius: "+convert);
            break;
        }
        else if (resp == "f")
        {
            Console.WriteLine("Ingresa la temperatura: ");
            temp = Console.ReadLine();
            tempv = ComprobarNumero(temp);
            convert = (tempv * 9 / 5) + 32;
            Console.WriteLine("Temperatura en Fahrenheit: "+convert);
            break;
        }
        else
        {
            Console.WriteLine("Error! Ingrese C o F");
        }
    } while (resp != "0");

    Fin();
}
static void Ejer19()
{
    Console.WriteLine("Consigna: "); //Se podría hacer recursivo pero es ineficiente ya que aqui se utiliza programación dinamica
    Console.WriteLine("19. Solicita al usuario un número entero positivo y muestra los primeros 50 números de la secuencia de Fibonacci ");
    Console.WriteLine("Ingrese un número: ");
    string num = Console.ReadLine();
    int numv = ComprobarNumero(num);
    int[]fibo = new int [numv+1];
    for (int i = 0; i <= numv; i++)
    {
        if (i == 0)
        {
            fibo[i] = 0;
        }
        else if (i == 1)
        {
            fibo[i] = 1;
        }
        else
        {
            fibo[i] = fibo[i - 1]+fibo[i-2];
        }
    }
    Console.WriteLine("El fibonacci de " + numv + " es " + fibo[numv]);
    Fin();
}
static void Ejer20()
{
    Console.WriteLine("20. Desarrolla un juego en el que el programa elija una palabra ");
    Console.WriteLine("y el usuario tenga que adivinarla letra por letra, con un límite de intentos\r\n");
    string[] pal = new string[] { "mesa", "casa", "avion", "perro", "codigo" };
    Random random = new Random();
    int alt = random.Next(pal.Length);
    char[] pala = pal[alt].ToCharArray();
    char[] pala2 = new char[pala.Length];
    int alt2, prueba;
    char caracterIngresado;
    int intento = pala.Length;
    for (int i = 0; i < pala.Length; i++)
    {
        alt2 = random.Next(pala.Length);
        if (alt2 == i)
        {
            pala2[i] = pala[i];
        }
        else
        {
            pala2[i] = '_';
        }

    }
    Console.WriteLine("La Palabra a adivinar es...");
    while (intento > 0 && !palabradaadivinada(pala, pala2)) 
    {
        foreach (char c in pala2)
        {
            Console.Write(c);
        }
        Console.WriteLine();
        Console.WriteLine("Cantidad de intentos: " + intento);
        Console.WriteLine("Ingrese una letra: ");
        string letra = Console.ReadLine().ToLower();
        while (true)
        {
            if (!string.IsNullOrEmpty(letra))
            {
                caracterIngresado = letra[0];
                break;
            }
            else
            {
                Console.WriteLine("No se ingresó ningún carácter.");
                 letra = Console.ReadLine().ToLower();
            }
        }
        for (int i = 0; i < pala.Length; i++)
        {
            if (pala[i] == caracterIngresado && pala2[i]=='_')
            {
                pala2[i] = caracterIngresado;
                intento++;
            }
        }
        intento--;
    }
    prueba = 0;
    for (int i = 0; i < pala.Length; i++)
    {
        if (pala[i] == pala2[i])
        {
            prueba++;
        }
    }
    if (prueba == pala.Length)
    {
        Console.WriteLine("Felicidades adivinaste la palabra");
    }
    else
    {
        Console.WriteLine("Mala suerte");
    }
    Console.WriteLine("La palabra era: ");
    foreach (char c in pala)
    {
        Console.Write(c);
    }
    static bool palabradaadivinada(char[] progreso, char[] completa)
    {
        for(int i = 0;i < progreso.Length; i++)
        {
            if(progreso[i] != completa[i])
            {
                return false;
            }
        }
        return true;
    }
    Console.WriteLine();
    Fin();

}
static void Ejer21()
{
    Console.WriteLine("Consigna: ");
    Console.WriteLine("21. (EXTRA). Adaptar el programa anterior para que a medida que el usuario falle, "); 
    Console.WriteLine("la aplicación autocomplete  la palabra letra a letra a modo de pistas para el usuario.");
    Console.WriteLine("El numero de intentos estará dado por la cantidad de letras restantes que el usuario tenga que adivinar. "); 
    Console.WriteLine("Ejemplo: La palabra ADIVINAR tendrá 8 intentos. Si la forma de la palabra es AD_V_NA_ son 3 intentos\r\n");
    string[] pal = new string[] { "mesa", "casa", "avion", "perro", "codigo" };
    Random random = new Random();
    int alt = random.Next(pal.Length);
    char[] pala = pal[alt].ToCharArray();
    char[] pala2 = new char[pala.Length];
    int alt2, prueba;
    char caracterIngresado;
    int intento = 0;
    for (int i = 0; i < pala.Length; i++)
    {
        alt2 = random.Next(pala.Length);
        if (alt2 == i)
        {
            pala2[i] = pala[i];
        }
        else
        {
            pala2[i] = '_';
            intento++;
        }

    }
    Console.WriteLine("La Palabra a adivinar es...");
    while (intento > 0 && !palabradaadivinada(pala, pala2))
    {
        foreach (char c in pala2)
        {
            Console.Write(c);
        }
        Console.WriteLine();
        Console.WriteLine("Cantidad de intentos: " + intento);
        Console.WriteLine("Ingrese una letra: ");
        string letra = Console.ReadLine().ToLower();
        while (true)
        {
            if (!string.IsNullOrEmpty(letra))
            {
                caracterIngresado = letra[0];
                break;
            }
            else
            {
                Console.WriteLine("No se ingresó ningún carácter.");
                letra = Console.ReadLine().ToLower();
            }
        }
        for (int i = 0; i < pala.Length; i++)
        {
            if (pala[i] == caracterIngresado && pala2[i] == '_')
            {
                pala2[i] = caracterIngresado;
                intento++;
            }
        }
        intento--;
    }
    prueba = 0;
    for (int i = 0; i < pala.Length; i++)
    {
        if (pala[i] == pala2[i])
        {
            prueba++;
        }
    }
    if (prueba == pala.Length)
    {
        Console.WriteLine("Felicidades adivinaste la palabra");
    }
    else
    {
        Console.WriteLine("Mala suerte");
    }
    Console.WriteLine("La palabra era: ");
    foreach (char c in pala)
    {
        Console.Write(c);
    }
    Console.WriteLine();
    Fin();
    static bool palabradaadivinada(char[] progreso, char[] completa)
    {
        for (int i = 0; i < progreso.Length; i++)
        {
            if (progreso[i] != completa[i])
            {
                return false;
            }
        }
        return true;
    }

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
}
static void Fin()
{
    Console.WriteLine("Precione una tecla para volver al menu: ");
    Console.ReadKey();
    Console.Clear();
}