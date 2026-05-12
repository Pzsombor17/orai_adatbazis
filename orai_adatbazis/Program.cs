namespace orai_adatbazis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Model model = new();
            Console.WriteLine(model.muzeums.Count);
            model.BeginChar('I').ForEach(x => Console.WriteLine(x));
        }
    }
}
