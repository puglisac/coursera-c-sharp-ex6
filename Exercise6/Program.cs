using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an angle in degrees: ");
            try
            {
                float angleDeg = float.Parse(Console.ReadLine());
                float cosine = (float)Math.Cos((Math.PI / 180) * angleDeg);
                float sine = (float)Math.Sin((Math.PI / 180) * angleDeg);
                Console.WriteLine($"The cosine of {angleDeg} is {cosine}.");
                Console.WriteLine($"The sine of {angleDeg} is {sine}.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
