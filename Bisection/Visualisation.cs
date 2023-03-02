namespace Bisection
{
    internal class Visualisation
    {
        static double startHigh;
        public static void setStartVal(double high)
        {
            startHigh = high; //Value to scale the length of both bars to
        }

        public static void drawBars(double low, double high)
        {
            double highLength = high / startHigh * 30; //Sets length of High bar
            double lowLength = low / startHigh * 30; //^ Low bar (*30 cause of the bars length of 30)
            
            string lowString = low + ""; //Buffer so its all alligned, 19 == max double string length
            int bufferLength = 19 - lowString.Length; 

            //Bar for the lower val
            string lowBar = "";
            for (int i = 0; i < bufferLength; i++) //Writes buffer
            {
                Console.Write(" ");
            }
            Console.Write(low + " ");

            for (int i = 0; i < lowLength; i++)
            {
                lowBar += "█";
            }
            for (int i = lowBar.Length; i < 30; i++) //Needed amount of empty rectangles for length of 30
            {
                lowBar += "░";
            }
            lowBar = Reverse(lowBar); //Reverses it so the filled part extends from the middle
            Console.Write(lowBar);

            Console.Write("|");

            //Bar for the higher val
            string highBar = "";
            for (int i = 0; i < highLength; i++)
            {
                highBar += "█";
            }
            for (int i = highBar.Length; i < 30; i++) //Needed amount of empty rectangles for length of 30
            {
                highBar += "░";
            }
            Console.Write(highBar);

            Console.Write( " " + high + "\n");
        }

        static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
