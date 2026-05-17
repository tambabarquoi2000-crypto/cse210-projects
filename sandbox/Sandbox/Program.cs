using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Sandbox Project.");

        string myfile = "text.txt";

        string [] lines = System.IO.File.ReadAllLines(myfile);

        foreach(string line in lines)
        {
            string[] parts = line.Split(",");
            Console.WriteLine(parts);
        }
}
}