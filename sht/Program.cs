

class Program
{
    static void Main(string[] args)
    {
        int num1, num2;

        Math math = new Math();

        Console.WriteLine("Enter first number: ");
        num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number: ");
        num2 = int.Parse(Console.ReadLine());

        math.Add(num1, num2);
        math.Sub(num1, num2);
        math.Multi(num1, num2);
        math.Div(num1, num2);


    }
}
public class Math
{
    public void Add(int num1, int num2)
    {

        Console.WriteLine("Total: " + (num1 + num2));

    }
    public void Sub(int num1, int num2)
    {

        Console.WriteLine("Total: " + (num1 - num2));
    }
    public void Multi(int num1, int num2)
    {

        Console.WriteLine("Total: " + (num1 * num2));

    }
    public void Div(int num1, int num2)
    {
        Console.WriteLine("Total: " + (num1 * num2));
    }
}




