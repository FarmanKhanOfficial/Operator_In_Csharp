using System;

class OperatersProgram
{
    static void Main()
    {
        Arithmetic_Operators();
        Comparison_Operators();
        Conditional_Operator();
        Ternary_Operator();
    }
    static void Arithmetic_Operators()
    {
        Console.WriteLine("Enter First number");
        float Number = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter Second number");
        float Number2 = float.Parse(Console.ReadLine());
        float Sum = Number + Number2;
        float Subtraction = Number - Number2;
        float Divide = Number / Number2;
        float Multiply = Number * Number2;
        float Reminder = Number % Number2;
        Console.WriteLine($"Sum = {Sum}, Subtraction = {Subtraction}, Divide = {Divide}, Multiplication = {Multiply}, Reminder = {Reminder}");
    }
    static void Comparison_Operators()
    {
        Console.WriteLine("Enter First number");
        float Number = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter Second number");
        float Number2 = float.Parse(Console.ReadLine());
        if (Number == Number2)
        {
            Console.WriteLine($"{Number} and {Number2} are Equals");
        }
        else if (Number > Number2)
        {
            Console.WriteLine($"{Number} is Greater Than {Number2}");
        }
        else
        {
            Console.WriteLine($"{Number2} is greater than {Number}");
        }           
    }
    static void Conditional_Operator()
    {
        Console.WriteLine("Please Enter your age");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Please Enter your country Starts With Capital letter");
        String Country = Console.ReadLine();
      
        if (age >= 18 && Country == "Pakistan")
        {
            Console.WriteLine("Your are Eligible to Vote");
        }
        else
        {
            Console.WriteLine("Your are not eligible to Vote");
        }
        Console.WriteLine(@"Here starts OR Condition.
Enter a number");
        int Number = int.Parse(Console.ReadLine());
        if (Number % 7 == 0 || Number % 11 == 0) 
        {
            Console.WriteLine("Multiples of 7 or 11");
        }
        else
        {
            Console.WriteLine("Not Multiple of 7 or 11");
        }
    }
    static void Ternary_Operator()
    {
        int total_Marks = 500;
        Console.WriteLine("Please Enter your Obtain Marks");
        int Obtain_Marks = int.Parse(Console.ReadLine());
        float Percentage = (Obtain_Marks * 100) / total_Marks;
        string Grade = Percentage >= 90 ? "A" :
            Percentage >= 80 ? "B" :
            Percentage >= 70 ? "C" :
            Percentage >= 60 ? "D" :
            "F";
        Console.WriteLine($"My Percentage is {Percentage} So My Grade is {Grade}");
    }
}