using System.ComponentModel.Design;
using System.Threading.Channels;

int num1;
int num2;
int result;
string answer;




Console.WriteLine("Hello, welcome to the calculater program!");
Console.WriteLine("Please enter your first number.");

num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter your second number.");
num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Whats type of operation would you like to do?");
Console.WriteLine("Please enter a for addition, s for subtraction, m for multiplication or any other key for division.");


answer = Console.ReadLine();
if (answer == "a")
{
    result = num1 + num2;
}
else if (answer == "s")
{
    result = num1 - num2;
}
else if (answer == "m")
{
    result = num1 * num2;
}
else
{
    result = num1 / num2;
}
Console.WriteLine("The result is " + result);
Console.WriteLine("Thank you for using the calculator");


Console.ReadKey();