using Tyuiu.SenachevAV.Sprint0.Task2.V0.Lib;
namespace Tyuiu.SenachevAV.Sprint0.Task2.V0
{
    internal class Program

    {
        private static void Main(string[] args)
        {
            Console.WriteLine(DataService.GetMessage("Андрей"));
            Console.ReadKey();
        }
    }
}