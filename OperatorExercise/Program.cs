namespace OperatorExercise
{
    internal class Program
    {
        public static double AreaOfCircle(double radius)
        {
            var area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

        static void Main(string[] args)
        {
            var a = 17;
            var b = 4;
            var quotient = a / b;
            var remainder = a % b;
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            var areaOfCircle = AreaOfCircle(radius);
            Console.WriteLine($"The area of a circle with radius of {radius} is {areaOfCircle}");
           
            /*
             * Thought Exercise
            var i = 3;
            var j = 4;
            var k = ++i * j++;
            Console.WriteLine(k); //16
            Console.WriteLine(j); //5 ????
            Console.WriteLine(i); //4
            */
        }
    }
}