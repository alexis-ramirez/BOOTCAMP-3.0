//Con el tema de las 8hs no supe bien como manejarlo. Entonces dicidi implementar turnos
//00 a 08 turno mañana 08 a 16 tarde y 16 a 00 noche
//contemple 3 turnos por dia
public class Persona
{
    public string Nombre { get; set; }
    public string Turno { get; set; }
}

public class Profesional : Persona
{
    public string NumeroMatricula { get; set; }
}

public class Pasante : Persona
{
    public string NumeroLegajo { get; set; }
}

public class RegistroTemperatura
{
    public int Temperatura { get; set; }
    public Persona PersonaDeTurno { get; set; }
    public DateTime FechaRegistro { get; set; }
    public string Turno { get; set; }
}

public class EstacionMeteorologica
{
    private RegistroTemperatura[,] temperaturasMensuales = new RegistroTemperatura[5, 7 * 3];
    private List<Profesional> profesionales;
    private List<Pasante> pasantes;

    public EstacionMeteorologica()
    {
        InicializarPersonas();
        CargarTemperaturasIniciales();
    }

    private void InicializarPersonas()
    {
        profesionales = new List<Profesional>
        {
            new Profesional { Nombre = "Prof. Fer", NumeroMatricula = "12345" },
            new Profesional { Nombre = "Prof. Maria", NumeroMatricula = "67890" },
            new Profesional { Nombre = "Prof. Luis", NumeroMatricula = "11223" }
        };

        pasantes = new List<Pasante>
        {
            new Pasante { Nombre = "Pas. Kevin", NumeroLegajo = "45678" },
            new Pasante { Nombre = "Pas. Ana", NumeroLegajo = "98765" },
            new Pasante { Nombre = "Pas. Enzo", NumeroLegajo = "33445" }
        };
    }

    private void CargarTemperaturasIniciales()
    {
        Random random = new Random();

        for (int semana = 0; semana < 5; semana++)
        {
            for (int dia = 0; dia < 7; dia++)
            {
                if (semana == 4 && dia > 2) break;

                for (int turno = 0; turno < 3; turno++)
                {
                    temperaturasMensuales[semana, dia * 3 + turno] = new RegistroTemperatura
                    {
                        Temperatura = random.Next(-20, 50),
                        PersonaDeTurno = AsignarPersonaDeTurno(dia, turno),
                        FechaRegistro = new DateTime(2024, 8, (semana * 7) + dia + 1),
                        Turno = ObtenerTurno(turno)
                    };
                }
            }
        }
    }

    private Persona AsignarPersonaDeTurno(int dia, int turno)
    {
        if ((dia * 3 + turno) % 2 == 0)
        {
            return profesionales[(dia + turno) % 3];
        }
        else
        {
            return pasantes[(dia + turno) % 3];
        }
    }

    private string ObtenerTurno(int turno)
    {
        return turno == 0 ? "Día" : turno == 1 ? "Tarde" : "Noche";
    }

    public void RegistrarTemperatura(RegistroTemperatura registro, int semana, int dia, int turno)
    {
        if (semana < 0 || semana > 4)
        {
            Console.WriteLine("Semana inválida. Debe ser un valor entre 1 y 5.");
            return;
        }

        if ((semana < 4 && (dia < 0 || dia > 6)) || (semana == 4 && (dia < 0 || dia > 2)))
        {
            Console.WriteLine("Día inválido. Debe ser un valor entre 1 y 7 para las primeras 4 semanas, y entre 1 y 3 para la última semana.");
            return;
        }

        temperaturasMensuales[semana, dia * 3 + turno] = registro;
        Console.WriteLine("Temperatura registrada con éxito.");
    }

    public RegistroTemperatura[,] VerTemperaturas()
    {
        return temperaturasMensuales;
    }
    public RegistroTemperatura VerTemperaturaDiaEspecifico(int semana, int dia, int turno)
    {
        if (semana < 0 || semana > 4 || dia < 0 || dia > 6 || turno < 0 || turno > 2)
        {
            return null;
        }
        return temperaturasMensuales[semana, dia * 3 + turno];
    }

}

public static class CalculoTemperaturas
{
    public static double CalcularPromedioMes(RegistroTemperatura[,] temperaturas)
    {
        double suma = 0;
        int count = 0;
        foreach (var registro in temperaturas)
        {
            if (registro != null)
            {
                suma += registro.Temperatura;
                count++;
            }
        }
        return suma / count;
    }

    public static int EncontrarTemperaturaMaxima(RegistroTemperatura[,] temperaturas)
    {
        int max = int.MinValue;
        foreach (var registro in temperaturas)
        {
            if (registro != null && registro.Temperatura > max)
            {
                max = registro.Temperatura;
            }
        }
        return max;
    }

    public static int EncontrarTemperaturaMinima(RegistroTemperatura[,] temperaturas)
    {
        int min = int.MaxValue;
        foreach (var registro in temperaturas)
        {
            if (registro != null && registro.Temperatura < min)
            {
                min = registro.Temperatura;
            }
        }
        return min;
    }
}

class Program
{
    static void Main(string[] args)
    {
        EstacionMeteorologica estacion = new EstacionMeteorologica();
        Console.WriteLine("Cargando temperaturas iniciales...");
        var temperaturasIniciales = estacion.VerTemperaturas();
        MostrarTemperaturas(temperaturasIniciales);
        Console.WriteLine("Presione una tecla para continuar");
        Console.ReadKey();
        //realizo una carga manual aunque se podría realizar de manera interactiva, validando lo ingresado
        Console.WriteLine("\nRegistrando una nueva temperatura...");
        Console.WriteLine("Prof. Alexis,  Matricula: 99999, Semana 3, Dia 2, Turno Mañana");
        Console.ReadKey();
        RegistroTemperatura nuevoRegistro = new RegistroTemperatura
        {
            Temperatura = 25,
            PersonaDeTurno = new Profesional { Nombre = "Prof. Alexis", NumeroMatricula = "99999" },
            FechaRegistro = new DateTime(2024, 8, 15),
            Turno = "Día"
        };
        estacion.RegistrarTemperatura(nuevoRegistro, 2, 1, 0); // Semana 3, Día 2, Turno de Día
        Console.WriteLine("\nTemperaturas después de registrar una nueva:");
        MostrarTemperaturas(estacion.VerTemperaturas());
        Console.WriteLine("Presione una tecla para continuar");
        Console.ReadKey();
        Console.WriteLine("Ver un dia especifico");
        VerTemperaturaDiaEspecifico(estacion);
        Console.WriteLine();
        Console.WriteLine($"\nTemperatura promedio del mes: {CalculoTemperaturas.CalcularPromedioMes(estacion.VerTemperaturas()):F2}°C");
        Console.WriteLine($"Temperatura máxima registrada: {CalculoTemperaturas.EncontrarTemperaturaMaxima(estacion.VerTemperaturas())}°C");
        Console.WriteLine($"Temperatura mínima registrada: {CalculoTemperaturas.EncontrarTemperaturaMinima(estacion.VerTemperaturas())}°C");
    }

    static void MostrarTemperaturas(RegistroTemperatura[,] temperaturas)
    {
        for (int semana = 0; semana < 5; semana++)
        {
            for (int dia = 0; dia < 7; dia++)
            {
                if (semana == 4 && dia > 2) break;

                for (int turno = 0; turno < 3; turno++)
                {
                    var registro = temperaturas[semana, dia * 3 + turno];
                    if (registro != null)
                    {
                        Console.WriteLine($"Semana {semana + 1}, Día {dia + 1}, Turno {registro.Turno}: {registro.Temperatura}°C - {registro.PersonaDeTurno.Nombre}");
                    }
                }
            }
        }
    }
    static void VerTemperaturaDiaEspecifico(EstacionMeteorologica estacion)
    {
        Console.Write("Ingrese la semana (1-5): ");
        int semana = int.Parse(Console.ReadLine()) - 1;

        Console.Write("Ingrese el día (1-7): ");
        int dia = int.Parse(Console.ReadLine()) - 1;

        Console.Write("Ingrese el turno (0: Día, 1: Tarde, 2: Noche): ");
        int turno = int.Parse(Console.ReadLine());

        var registro = estacion.VerTemperaturaDiaEspecifico(semana, dia, turno);
        if (registro != null)
        {
            Console.WriteLine($"\nTemperatura del día específico:");
            Console.WriteLine($"Fecha: {registro.FechaRegistro.ToShortDateString()}, Turno: {registro.Turno}");
            Console.WriteLine($"Temperatura: {registro.Temperatura}°C");
            Console.WriteLine($"Registrado por: {registro.PersonaDeTurno.Nombre} ({(registro.PersonaDeTurno is Profesional ? "Profesional" : "Pasante")})");
        }
        else
        {
            Console.WriteLine("No hay registro de temperatura para el día y turno seleccionados.");
        }
    }

}
