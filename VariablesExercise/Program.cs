namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hello, welcome to my basic Variables Exercise. Do you have a dog? If so, what is it's name?");
            string dogName = Console.ReadLine();
            Console.WriteLine($"Thank you, how old is {dogName}? (you can skip this if you are not sure)");
            string dogAge = Console.ReadLine();
            if (dogAge == "")
            {
                Console.WriteLine($"I understand, when adopting {dogName} they might not have known their an age.\n Adopting a dog was very cool of you!");
            }
            else
            {
                Console.WriteLine($"Your dog, {dogName} sounds awesome! It is great you have had them for {dogAge} years!");
            }

            Console.WriteLine($"\nNow to finish my assignment...");
            char ampersand = '&';
            Console.WriteLine($"\nThis is a example of a char type '{ampersand}'.");
            decimal numDecimal = 6.55m;
            Console.WriteLine($"\nThis number is a decimal '{numDecimal}' true or false?");
            string tFAnswer = Console.ReadLine();
            bool myBool = Convert.ToBoolean(tFAnswer);
            
            if (myBool == true) 
            {
                Console.WriteLine($"\nVery good! You also helped me with an example of a bool or boolean value,\n which is a {myBool} or False statement.");
            } 
            else 
            {
                Console.WriteLine($"\n12That isn't correct, but you did just help me with an example of a bool or boolean value,\n which is a True or {myBool} statement.");
            }
            Console.WriteLine($"\nSo the final type for this exercise is the 'double' value type. At first, I was a little confused \n until I thought of my geometry. When you try to find a circumfrence of a wheel, you use PI.\n\n So enter a diameter of a wheel, and I will tell you its circumfrence.");
            string diameter = Console.ReadLine();
            double newDiam = Convert.ToDouble(diameter);
            double pi = 3.14159265358979323846264338327950288419716939937510;
            double circumfrence = newDiam * pi;
            Console.WriteLine();
            Console.WriteLine(circumfrence.ToString());
            Console.WriteLine($"\nWell, Thank you so much for helping with my assignment. I learned a bunch and I hope you did too!");
        }
    }
}
