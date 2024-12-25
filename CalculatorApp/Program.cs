namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0;
            Console.Write("Enter The Value of X: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter The Value of Y: ");
            y = int.Parse(Console.ReadLine());
            Calculator Calc = new Calculator();
            Calc.X = x;
            Calc.Y = y;
            Console.WriteLine("Sum: " + Calc.Add());
            Console.WriteLine("Difference: " + Calc.Subtract());
            Console.WriteLine("Product: " + Calc.Multiply());
            Console.WriteLine("Quotient: " + Calc.Divide());
        }
    }
}
