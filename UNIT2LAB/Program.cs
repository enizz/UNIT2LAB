Console.WriteLine("Hello, what is your name?");

string name = Console.ReadLine();

do
{

    Console.WriteLine("Hi " + name + "! Please enter an integer between 1 and 100.");
    int userInput = int.Parse(Console.ReadLine());

    while ((userInput < 1) || (userInput > 100))
    {
        Console.WriteLine(name + ", please provide a proper integer between 1 and 100.");
        userInput = int.Parse(Console.ReadLine());
    }

    bool isInputEven = false;

    if (userInput % 2 == 0)
    {
        isInputEven = true;
    }


    //analyze number

    if (isInputEven == false && userInput > 60)
    {
        Console.WriteLine(name + ", your number is odd and greater than 60.");
    }

    else if (isInputEven == false && userInput < 60)
    {
        Console.WriteLine(name + ", your number is odd and less than 60.");
    }

    else if (isInputEven == true && userInput > 60)
    {
        Console.WriteLine(name + ", your number is even and greather than 60.");
    }
    else if (isInputEven == true && userInput <= 60 && userInput >= 26)
    {
        Console.WriteLine(name + ", your number is even and between 26 and 60 inclusive.");
    }
    else
    {
        Console.WriteLine(name + ", your number is even and less than 25.");
    }

    Console.WriteLine(name + ", do you want to start over? (Y/N)?");
}
while (Console.ReadLine() != "N");