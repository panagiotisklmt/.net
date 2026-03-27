Console.WriteLine("Give me a number");
string inputString = Console.ReadLine();
int num1 = 0;

bool isNumber = int.TryParse(inputString, out num1);

if(isNumber)
{
    Console.WriteLine("Well done, you entered a number");
}
else
{
    Console.WriteLine("Haha you troll. You should've entered a number");
}



Console.ReadKey();