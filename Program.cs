namespace Topic_4_pratice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double price;
            Console.WriteLine("what is the price");
            double.TryParse(Console.ReadLine(), out price);
            Console.WriteLine("the price is " + (price / 5).ToString("c"));




            
        }
    }
}
