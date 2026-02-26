namespace COMP003A.LectureActivity7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] scores = { 85, 90, 78, 92, 88 };

            Console.WriteLine("Display array values: ");

            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine(scores[i]);
            }

            Console.WriteLine();


            List<String> names = new List<string>();

            names.Add("Evan");
            names.Add("Marley");
            names.Add("Koa");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            Console.WriteLine("Enter a number between 1 and 3: ");
            string userInput = Console.ReadLine();

            try
            {
                int selection = int.Parse(userInput);

                if (selection >= 1 && selection <= 3)
                {
                    Console.WriteLine("Valid Number");
                }
                else
                {
                    Console.WriteLine("Number out of range");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number entered");
            }
        }
    }
}
