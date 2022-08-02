Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
Console.WriteLine();

Console.WriteLine("Enter the room length: ");
double length = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the room width: ");
double width = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the room height: ");
double height = Convert.ToDouble(Console.ReadLine());

double area = length * width;
double perimeter = (length + width) * 2;
double volume = (length * width * height);
double surface = 2 * ((length * width) + (width * height) + (length * height));


Console.WriteLine($"Area: {area}");
Console.WriteLine($"Perimeter: {perimeter}");
Console.WriteLine($"Volume: {volume}");
Console.WriteLine($"Surface Area: {surface}");

if (area <= 250)
{
    Console.WriteLine("This is a small sized room.");
}
else if (area > 250 && area < 650)
{
    Console.WriteLine("This is a medium sized room.");
}
else
{
    Console.WriteLine("This is a large sized room.");
}
Console.WriteLine();
Console.WriteLine("Thank you for using the Room Detail Generator!");