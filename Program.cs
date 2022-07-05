using CirclesLab;

bool validData = false;
bool playAgain = true;
double radius = 0;
string area = "";
string circumference = "";
int count = 0;

Console.WriteLine("Welcome to the circle tester.");  

while (playAgain == true)
{

    while (!validData)
    {
        try
        {
            Console.WriteLine("Please enter the radius:");
            radius = double.Parse(Console.ReadLine());
            if (radius < 0)
            {
                throw new Exception("Number must be positive");
            }
            else
            {
                validData = true;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            continue;
        }
    }

    // do calculations 

    Circle userCircle = new Circle(radius);  //make a new circle 

    area = userCircle.CalculateFormattedArea();
    circumference = userCircle.CalculateFormattedCircumference();
    count++;
    Console.WriteLine($"The area of your circle is {area}");
    Console.WriteLine($"The circumference of your circle is {circumference}");

    while (true)
    {
        Console.WriteLine("Do you want to run again? y/n ");
        string restart = Console.ReadLine().Trim().ToLower();

        if (restart == "y" || restart == "yes")
        {
            validData = false; // gotta get new data now 
            break;
        }
        else if (restart == "n" || restart == "no")
        {
            Console.WriteLine($"Goodbye! You calculated {count} circles.");
            playAgain = false;
            break;
        }
        else
        {
            Console.WriteLine("Please make a valid selection");
            continue;
        }
    }
}