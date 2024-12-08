
#region Q 1 

//var Number = Console.ReadLine();
//Console.WriteLine(" The Num Is " + Number);
#endregion

#region Q 2 
//Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen 


//Console.WriteLine("Enter a string to convert to an integer:");
//string input = Console.ReadLine();

//try
//{
//    int result = int.Parse(input);
//    Console.WriteLine($"Conversion successful! The integer is: {result}");
//}
//catch (FormatException)
//{
//    Console.WriteLine(" The input string contains non-numeric characters and cannot be converted to an integer.");
//}
//catch (OverflowException)
//{
//    Console.WriteLine( "The number is too large or too small for an integer.");
//};    

#endregion

#region Q 3 
//Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen


//Console.WriteLine("Enter the first floating-point number:");
//string input1 = Console.ReadLine();

//Console.WriteLine("Enter the second floating-point number:");
//string input2 = Console.ReadLine();
//var Result = float.Parse(input1) + float.Parse(input2);

//Console.WriteLine("The Result Is " + Result); 

#endregion

#region Write C# program that Extract a substring from a given string.
//Console.WriteLine("Enter the Word ");
//string input1 = Console.ReadLine();

//Console.WriteLine("Enter the Char ");
//string input2 = Console.ReadLine();

//Console.WriteLine("Enter the Length ");
//string input3 = Console.ReadLine();
//int StartChar = int.Parse(input2);
//int Length = int.Parse(input3);
//var SubString = input1.Substring(StartChar , Length); 
//Console.WriteLine("The Substring Is " + SubString);
#endregion

#region Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen


//int firstValue = 10;

// int secondValue = firstValue;

//Console.WriteLine($"Before modification:");
//Console.WriteLine($"firstValue = {firstValue}");
//Console.WriteLine($"secondValue = {secondValue}");

// firstValue = 20;

//Console.WriteLine("\nAfter modifying firstValue:");
//Console.WriteLine($"firstValue = {firstValue}");
//Console.WriteLine($"secondValue = {secondValue}");

//Console.WriteLine("\nExplanation:");
//Console.WriteLine("Value types are stored on the stack, and assigning them creates a copy of the value.");
//Console.WriteLine("Therefore, modifying one variable does not affect the other.");

#endregion

#region Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
// using System;

//class Program
//{
//    class MyClass
//    {
//        public int Value;
//    }

//    static void Main()
//    {
//        MyClass firstObject = new MyClass();
//        firstObject.Value = 10;

//         MyClass secondObject = firstObject;

//         Console.WriteLine($"Before modification:");
//        Console.WriteLine($"firstObject.Value = {firstObject.Value}");
//        Console.WriteLine($"secondObject.Value = {secondObject.Value}");

//         firstObject.Value = 20;

//         Console.WriteLine("\nAfter modifying firstObject.Value:");
//        Console.WriteLine($"firstObject.Value = {firstObject.Value}");
//        Console.WriteLine($"secondObject.Value = {secondObject.Value}");

//        Console.WriteLine("\nExplanation:");
//        Console.WriteLine("Reference types are stored on the heap, and assigning them creates a shared reference to the same object.");
//        Console.WriteLine("Therefore, modifying the object through one reference affects all references to that object.");
//    }
//}
#endregion

#region   Write C# program that take two string variables and print them as one variable 

//string firstString = "Hello";
//string secondString = "World";

// string concatenatedString = firstString + " " + secondString;
// Console.WriteLine("Concatenated String:");
//Console.WriteLine(concatenatedString);
#endregion

#region Which of the following statements is correct about the C#.NET code snippet given below?


//int d;
//d = Convert.ToInt32(!(30 < 20));


//A value 0 will be assigned to d.
//A value 1 will be assigned to d. IS the Correct Answer
//A value -1 will be assigned to d.
//The code reports an error.
//The code snippet will work correctly if ! is replaced by Not


//A value 1 will be assigned to d. IS the Correct Answer
#endregion


#region Which of the following is the correct output for the C# code given below?


////Console.WriteLine(13 / 2 + " " + 13 % 2);
//A-6.5 1
//B-6.5 0
//C-6 0
//D-6 1
//E-6.5 6.5

//Output Is 6 1

#endregion

#region 10-What will be the output of the C# code given below?

//int num = 1, z = 5;


//if (!(num <= 0))
//    Console.WriteLine(++num + z++ + " " + ++z);
//else
//    Console.WriteLine(--num + z-- + " " + --z);



//A-5 6
//B-6 5
//C-6 6
//D-7 7 

//The Result Is 7 7
#endregion