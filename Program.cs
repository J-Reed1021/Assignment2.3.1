namespace Assignment2._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string writeText = "personalDetails";
            File.WriteAllText("details.txt", writeText);

            string readText = File.ReadAllText("details.txt");
            Console.WriteLine(readText);
        }
    }
}
