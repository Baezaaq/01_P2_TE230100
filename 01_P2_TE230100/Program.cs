Console.WriteLine("01_SISTEMA DE Motor DC");
Console.WriteLine();

// Clases: MotorDC
// Objetos: motor
// Propiedades: idMotor, voltaje y corriente
// Metodos: CalcularPotencia y ObtenerEstadoConsumo

MotorDC motor = new MotorDC();

// INGRESADO DE DATOS DEL MOTOR
Console.Write("Ingrese el identificador del motor: ");
motor.idMotor = Console.ReadLine();

Console.Write("Ingrese el voltaje de alimentación (V): ");
motor.voltaje = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la corriente consumida (A): ");
motor.corriente = Convert.ToDouble(Console.ReadLine());

// Solicitar al objeto los cálculos
double potencia = motor.CalcularPotencia();
string estado = motor.ObtenerEstadoConsumo();

// MOSTRAR RESULTADOS
Console.WriteLine();
Console.WriteLine($"Potencia eléctrica: {potencia} W");
Console.WriteLine($"Estado de consumo: {estado}");

// Definición de la clase
class MotorDC
{
    // Propiedades
    public string idMotor { get; set; }
    public double voltaje { get; set; }
    public double corriente { get; set; }

    // Método para calcular la potencia
    public double CalcularPotencia()
    {
        return voltaje * corriente;
    }

    // Método para determinar el estado de consumo
    public string ObtenerEstadoConsumo()
    {
        double potencia = CalcularPotencia();
        if (potencia <= 120.0)
        {
            return "Consumo normal";
        }
        else
        {
            return "Consumo elevado";
        }
    }
}