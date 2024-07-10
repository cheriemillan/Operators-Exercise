namespace OperatorExercise
{
    public class Program
    {
        public static double AreaOfCircle(double radius)
        {
            double formula= Math.PI * Math.Pow(radius, 2);
            return formula;
        }
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int sum = a + b;
            int quotient = a / b;
            int remainder = a % b;
            
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}.");
            Console.WriteLine($"{a}+{b} is {sum} ");
            
            Console.WriteLine("\nWhat is the radius of your circle");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The area of a circle with the radius of {radius} is " + AreaOfCircle(radius));

        }
    }
}
