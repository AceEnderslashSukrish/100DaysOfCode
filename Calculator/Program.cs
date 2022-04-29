using Calculator;

Console.WriteLine("Calculator Application");
Console.WriteLine();
Console.WriteLine("What would you like to do today?");
Console.WriteLine("\n1.Add\n2.Subtract\n3.Multiply\n4.Divide\n");
int chc = Convert.ToInt32(Console.ReadLine());

switch (chc)
{
    case 1:
        Console.WriteLine("How many numbers would you like to add?");
        int length = Convert.ToInt32(Console.ReadLine());
        double sum = 0;
        List<double> listOfNum = new List<double>();
        Operations P = new Operations();
        for (int i = 0; i < length; i++)
        {
            Console.Write("Enter number: ");
            double num = Convert.ToDouble(Console.ReadLine());
            listOfNum.Add(num);
        }
        sum = P.Add(listOfNum);
        Console.Write($"Sum is: {sum}");

        break;

    default:
        break;
}