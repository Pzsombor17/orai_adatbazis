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
            Console.WriteLine(model.LowestRating());
            Console.WriteLine(model.HighestRating("fény"));
            Console.WriteLine(model.AvgRating());
            Console.WriteLine(model.CountCity("Budapest"));
            model.EqualRating(4.5).ForEach(x => Console.WriteLine(x));
            model.Idontknow("fény", 4.5).ForEach(x => Console.WriteLine(x));
            model.BetweenRating(3.5,4.0).ForEach(x => Console.WriteLine(x));
        }
    }
}
