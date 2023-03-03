using static Bisection.Visualisation;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Bisection";
    Start:
        Console.WriteLine("\n--Neue Rechnung--\n");

        double n;
    InputNumber: //Gets the number to calculate the square root of
        Console.Write("Wurzel aus: ");
        try { n = Convert.ToDouble(Console.ReadLine()); } catch { Console.WriteLine("Ungültige Eingabe!"); goto InputNumber; }
        double low = 0, high = n, middle = 0, lastm = 1;

        Console.WriteLine("Berechne Wurzel aus: " + n + "...");
        setStartVal(high); //Value to scale the length of both bars to
        drawBars(low, high); //Visualizes initial input
        while (middle * middle != n /*Dont go on if solved*/ && lastm != middle /*Dont loop forever*/)
        {
            lastm = middle;
            middle = (low + high) / 2;
            if (middle * middle > n)
            {
                high = middle; //Sets the new cap
            }
            else low = middle; //Sets the new floor
            drawBars(low, high); //Visualizes
        }
        Console.WriteLine("Wurzel: " + middle);
        goto Start;
    }
}