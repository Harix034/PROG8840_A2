using Calculator;

bool exit = false;

while (!exit)
{
    Prompts.PrintWelcomeMenu();
    Prompts.PrintOptions();
    Console.WriteLine("Enter operation number (or type 'exit' to close): ");
    string? OptionChoice = Console.ReadLine();

    if (OptionChoice?.ToLower() == "exit")
    {
        exit = true;
        break;
    }

    Console.WriteLine("Enter number 1: ");
    string? Number1 = Console.ReadLine();
    Console.WriteLine("Enter number 2: ");
    string? Number2 = Console.ReadLine();

    if (float.TryParse(Number1, out float Number1Converted) && float.TryParse(Number2, out float Number2Converted))
    {
        switch (OptionChoice)
        {
            case "1":
                float Sum = Evaluator.Eval("+", Number1Converted, Number2Converted);
                Console.WriteLine($"{Number1Converted} + {Number2Converted} = {Sum}");
                break;
            case "2":
                float subtract = Evaluator.Eval("-", Number1Converted, Number2Converted);
                Console.WriteLine($"{Number1Converted} - {Number2Converted} = {subtract}");
                break;
            case "3":
                float Product = Evaluator.Eval("*", Number1Converted, Number2Converted);
                Console.WriteLine($"{Number1Converted} * {Number2Converted} = {Product}");
                break;
            default:
                Console.WriteLine("Invalid option. Please select a valid operation.");
                break;
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter numeric values.");
    }

    Console.WriteLine("Do you want to perform another operation? (yes/no)");
    string? response = Console.ReadLine()?.ToLower();
    if (response != "yes")
    {
        exit = true;
    }
}

Console.WriteLine("Exiting the calculator. Goodbye!");