using System;

class Program
{
    static void Main()
    {
        // Entrada del usuario
        Console.Write("Ingrese la hora: ");
        int h = int.Parse(Console.ReadLine());

        Console.Write("Ingrese los minutos: ");
        int m = int.Parse(Console.ReadLine());

        // Cálculo de los ángulos
        double anguloHora = (h % 12) * 30 + m * 0.5;
        double anguloMinuto = m * 6;

        // Cálculo del ángulo entre las manecillas
        double angulo = Math.Abs(anguloHora - anguloMinuto);
        angulo = Math.Min(angulo, 360 - angulo);

        // Mostrar el resultado
        Console.WriteLine("El ángulo entre las manecillas es: " + angulo + " grados");
    }
}