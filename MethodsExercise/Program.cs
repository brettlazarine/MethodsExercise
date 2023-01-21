namespace MethodsExercise
{
    public class Program
    {
        public static void MadLib()
        {
            string name;
            string favColor;
            string favAnimal;
            string favBand;
            Console.WriteLine("How about a quick MadLib?");
            Console.Write("What's your name: ");
            name = Console.ReadLine();
            Console.Write("Favorite color: ");
            favColor = Console.ReadLine();
            Console.Write("Favorite animal: ");
            favAnimal = Console.ReadLine();
            Console.Write("Favorite band: ");
            favBand = Console.ReadLine();
            Console.WriteLine("OK, let's see what we've got.");
            Console.WriteLine($"{name} decided to have a night on the town.\n" +
                $"Naturally, it wouldn't be a night out without wearing their {favColor.ToLower()} shirt, since {favColor.ToLower()} is their favorite color!\n" +
                $"Sadly, it looks like nobody else is down to clown! Thankfully, {name} has their trusty stuffed {favAnimal.ToLower()} to keep them company!\n" +
                $"To round it all off, {name} and {favAnimal.ToLower()} decided to listen to their favorite band, {favBand}.\n" +
                $"Not a bad night.\n" +
                $"THE END!");
        }

        public static int Sum(params int[] list)
        {
            int sum = 0;
            for (int i = 0; i < list.Length; i++)
            {
                sum += list[i];
            }
            return sum;
        }

        public static int Subtract(int num1, int num2, int num3)
        {
            return num1 - num2 - num3;
        }

        public static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }

        public static int Divide(int num1, int num2) //For the sake of division with integers, make sure num1 is bigger than num2!
        {
            return num1 / num2;
        }

        static void Main(string[] args)
        {
            MadLib();
            Console.Write("Gimme a number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Ok no gimme another: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Final number: ");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Your numbers added together: {Sum(num1, num2, num3)}\n" +
                $"Your numbers subtracted from each other: {Subtract(num1 ,num2, num3)}\n" +
                $"Your numbers multiplied together: {Multiply(num1, num2, num3)}\n" +
                $"Your numbers diveded: {Divide(num1, num2)}");
           

        }
    }
}