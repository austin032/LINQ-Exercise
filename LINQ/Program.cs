namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var sports = new List<string>() {"Basketball", "Football", "Golf", "Baseball", "Hockey", "Track"};

            var longerNames = sports.OrderByDescending(x => x.Length).ToList();
            
            longerNames.ForEach(x => Console.WriteLine(x));
        }
    }
}
