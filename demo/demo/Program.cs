


using  ClassLibrary1;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p= new Point();
            double distance = p.CalculateDistance(0, 0, 3, 4);
            Console.WriteLine($"The distance is: {distance}");
        }
    }
}
