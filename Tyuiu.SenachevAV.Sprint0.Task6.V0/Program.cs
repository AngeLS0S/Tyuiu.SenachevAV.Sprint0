using Tyuiu.SenachevAV.Sprint0.Task6.V0.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        int[] numArray = new int[] { 1, 2, 3, 4, 5 };

        Console.WriteLine("Сумма элементов массива =" + DataService.AdditionArray(numArray));

        Console.WriteLine("Разность элементов массива =" + DataService.SubtractionArray(numArray));

        Console.WriteLine("Произведение элементов массива =" + DataService.MultiplicationArray(numArray));

        Console.ReadKey();
    }
}