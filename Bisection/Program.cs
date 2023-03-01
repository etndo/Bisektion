internal class Program
{
    private static void Main(string[] args)
    {
    Start:
        Console.WriteLine("\n--Neue Rechnung--\n");

        double n;
    InputNumber:
        Console.Write("Wurzel aus: ");
        try { n = Convert.ToDouble(Console.ReadLine()); } catch { Console.WriteLine("Ungültige Eingabe!"); goto InputNumber; }
        double low = 0, high = n, middle = 0, lastm = 1;

        Console.WriteLine("Berechne Wurzel aus: " + n + "...");
        while (middle * middle != n && lastm != middle)
        {
            lastm = middle;
            middle = (low + high) / 2;
            if (middle * middle > n)
            {
                high = middle;
            }
            else low = middle;
            Console.WriteLine(middle);
        }
        Console.WriteLine("Wurzel: " + middle);
        goto Start;
    }
}