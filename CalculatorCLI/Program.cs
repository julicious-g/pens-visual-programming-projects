// See https://aka.ms/new-console-template for more information

using System.ComponentModel.DataAnnotations;

Console.WriteLine("Calculator CLI.");

var firstNumber = int.Parse(Environment.GetCommandLineArgs()[1]);
var secondNumber = int.Parse(Environment.GetCommandLineArgs()[3]);
var opr = Environment.GetCommandLineArgs()[2];

var result = 0;

switch (opr)
{
    case "+":
        result = firstNumber + secondNumber;
        break;
    case "-":
        result = firstNumber - secondNumber;
        break;
    default:
        Console.WriteLine($"Operator '{opr}' is not supported yet.");
        return;
}

Console.WriteLine($"Result is : {result}");
Console.WriteLine("Done");
