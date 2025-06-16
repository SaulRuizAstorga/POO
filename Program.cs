
namespace CalculadoraPOO;

public class Calculadora
{
    public double Sumar(double a, double b)
    {
        return a + b;
    }
    public double restar(double a, double b)
    {
        return a - b;
    }
    public double Multiplicar(double a, double b)
    {
        return a * b;
    }
    public double Dividir(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("No se puede dividir entre 0");
        }
        return a / b;
    }
}
class program
{
    Calculadora calculadora = new Calculadora();
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido a la Calculadora POO");
        Console.WriteLine("Seleccionar una operacion:");
        Console.WriteLine("1.Sumar");
        Console.WriteLine("2.Restar");
        Console.WriteLine("3.Multiplicar");
        Console.WriteLine("4.Dividir");

        int opcion = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el primer numero:");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo numero:");
        double num2 = double.Parse(Console.ReadLine());

        try
        {
            Calculadora calculadora = new Calculadora();
            double resultado = 0;
            switch (opcion)
            {
                case 1:
                    resultado = calculadora.Sumar(num1, num2);
                    Console.WriteLine($"El resultado de la suma es: {resultado}");
                    break;
                case 2:
                    resultado = calculadora.restar(num1, num2);
                    Console.WriteLine($"El resultado de la resta es: {resultado}");
                    break;
                case 3:
                    resultado = calculadora.Multiplicar(num1, num2);
                    Console.WriteLine($"El resultado de la multiplicacion es: {resultado}");
                    break;
                case 4:
                    resultado = calculadora.Dividir(num1, num2);
                    Console.WriteLine($"El resultado de la division es: {resultado}");
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FormatException)
        {

            {
                Console.WriteLine("Formato de numero invalido");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");


        }

    }
}

