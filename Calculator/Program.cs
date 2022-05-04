using Calculator;

Console.WriteLine("Calculator Application");
Console.WriteLine();
bool firstRep = true;
bool rep = true;

while (rep)
{
    List<double> listOfNum = new List<double>();
    Operations P = new Operations();
    double finalResult = 0;
    bool badchc = false;
    int length;

    if (firstRep)
    {
        Console.WriteLine("What would you like to do today?");
        firstRep = false;
    }
    else
        Console.WriteLine("What else would you like to do today?");

    Console.WriteLine("\n1.Add\n2.Subtract\n3.Multiply\n4.Divide\n");
    int chc = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    switch (chc)
    {
        case 1:
            Console.WriteLine("How many numbers would you like to add?");
            length = Convert.ToInt32(Console.ReadLine());
            listOfNum.Clear();
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter number: ");
                double num = Convert.ToDouble(Console.ReadLine());
                listOfNum.Add(num);
            }
            finalResult = P.Add(listOfNum);
            Console.WriteLine($"Sum is: {finalResult}");
            break;

        case 2:
            Console.WriteLine("How many numbers would you like to subtract?");
            length = Convert.ToInt32(Console.ReadLine());
            listOfNum.Clear();
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter number: ");
                double num = Convert.ToDouble(Console.ReadLine());
                listOfNum.Add(num);
            }
            finalResult = P.Subtract(listOfNum);
            Console.WriteLine($"Difference is: {finalResult}");
            break;

        case 3:
            Console.WriteLine("How many numbers would you like to divide?");
            length = Convert.ToInt32(Console.ReadLine());
            listOfNum.Clear();
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter number: ");
                double num = Convert.ToDouble(Console.ReadLine());
                listOfNum.Add(num);
            }
            finalResult = P.Divide(listOfNum);
            Console.WriteLine($"Quotient is: {finalResult}");
            break;

        case 4:
            Console.WriteLine("How many numbers would you like to multiply?");
            length = Convert.ToInt32(Console.ReadLine());
            listOfNum.Clear();
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter number: ");
                double num = Convert.ToDouble(Console.ReadLine());
                listOfNum.Add(num);
            }
            finalResult = P.Multiply(listOfNum);
            Console.WriteLine($"Product is: {finalResult}");
            break;

        default:
            Console.WriteLine("Invalid choice");
            badchc = true;
            break;
    }
    Console.WriteLine();
    if (badchc != true)
    {
        Console.WriteLine("Would you like to do anything else?");
        string repChoice = Console.ReadLine();
        repChoice.ToLower();
        if (repChoice == "no" || repChoice == "n" || repChoice == "nope")
            rep = false;
    }
    
}
Console.WriteLine();
Console.WriteLine("Thank you for using this program!");