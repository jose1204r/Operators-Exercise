


namespace OperatorExercise
{
    internal class Program
    {

        // RADIO METHOD

       
            public static double radioMethod(double radius)

            {

                return Math.PI * (radius * radius);

            }

            static void Main(string[] args)

            {

                var a = 17;
                var b = 4;
                var div = a / b;
                var mod = a % b;

                Console.WriteLine($"{a}/{b} is {b} reminder {mod}");

                



            //_____________________Exercie 2 ___________________________________________________________


            Console.WriteLine("what is the radio of your circle?");

                var radius = double.Parse(Console.ReadLine());


                var result = radioMethod(radius);

                Console.WriteLine($"The area of the circle with radio of {radius} is {result}");

            }
        }
     }