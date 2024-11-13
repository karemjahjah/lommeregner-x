
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

while (true){
    Console.WriteLine("Please select one of the following operators + - / *");

    string Operator = Console.ReadLine();
    var AcceptableOperators = "+ - / *".Split();

    while(!AcceptableOperators.Contains(Operator)){
        Console.WriteLine("Please use one of the following operators: " + string.Join (" or ", AcceptableOperators));
        Operator = Console.ReadLine();
    }

    if (Operator == AcceptableOperators[0]){
        Console.WriteLine("You have chosen +: please write the first part of the equation");
        string StringNumber1 = Console.ReadLine();
        float UserNumber1 = float.Parse(StringNumber1);
        Console.WriteLine("You have the first part of the equation. Please write the second");
        string StringNumber2 = Console.ReadLine();
        float UserNumber2 = float.Parse(StringNumber2);
        float FinalRes = UserNumber1 + UserNumber2; 
        Console.WriteLine("This equates to: " + FinalRes);
        }

    else if (Operator == AcceptableOperators[1]){
        Console.WriteLine("You have chosen -: please write the first part of the equation");
        string StringNumber1 = Console.ReadLine();
        float UserNumber1 = float.Parse(StringNumber1);
        Console.WriteLine("You have the first part of the equation. Please write the second");
        string StringNumber2 = Console.ReadLine();
        float UserNumber2 = float.Parse(StringNumber2);
        float FinalRes = UserNumber1 - UserNumber2; 
        Console.WriteLine("This equates to: " + FinalRes);
    }

    else if (Operator == AcceptableOperators[2]){
        Console.WriteLine("You have chosen /: please write the first part of the equation");
        string StringNumber1 = Console.ReadLine();
        float UserNumber1 = float.Parse(StringNumber1);
        Console.WriteLine("You have the first part of the equation. Please write the second");
        string StringNumber2 = Console.ReadLine();
        float UserNumber2 = float.Parse(StringNumber2);
        float FinalRes = UserNumber1 / UserNumber2; 
        Console.WriteLine("This equates to: " + FinalRes);
    }

    else if (Operator == AcceptableOperators[3]){
        Console.WriteLine("You have chosen *: please write the first part of the equation");
        string StringNumber1 = Console.ReadLine();
        float UserNumber1 = float.Parse(StringNumber1);
        Console.WriteLine("You have the first part of the equation. Please write the second");
        string StringNumber2 = Console.ReadLine();
        float UserNumber2 = float.Parse(StringNumber2);
        float FinalRes = UserNumber1 * UserNumber2; 
        Console.WriteLine("This equates to: " + FinalRes);
    }
}










