// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//string name = "Bilal Zaheer";

//object value1 = 12.42142;
//Console.WriteLine(value1.GetType());

//dynamic value2 = 'h';
//Console.WriteLine(value2);

//var value3 = "safjlas";
//Console.WriteLine(value3.GetType());

//Console.WriteLine();

//string str1 = "Test";
//for (int ctr = 0; ctr <= str1.Length - 1; ctr++)
//    Console.Write("{0} ", str1[ctr]);

//ternary operator

//string abc = "This Is Me Hexor Here";
//var a = abc;
//string d = a != abc ? a : ""; 

//Console.WriteLine(d);

// null coalescing operators:
//string a = "hello";
//var b = a ?? "Hello Brother";

//var c = a ? b :
//Console.WriteLine(b);

//Test
//int age = 19;
//string electedcandidate = age >= 18 ? "You are  Eligible To Cast Vote" : "Not Eligible";
//Console.WriteLine(electedcandidate);

////C# Raw String:
//var a1 = $$"""{"age" : {{electedcandidate}} , "name" : bilal} """;

//var ags = $$"""{}""";

//Console.WriteLine(a1);


//using Newtonsoft.Json;
//using System.Net.Http.Json;
//using System.Text.Json.Serialization;

//int electedcandidate = 30;
//string bilal = "Bilal";

//// Create an anonymous object with dynamic content
//var data = new
//{
//    age = electedcandidate,
//    name = bilal
//};

//// Serialize the object to a JSON-formatted string
//var jsonString = JsonConvert.SerializeObject(data);

//Console.WriteLine(jsonString);

//int num1 = 3;
//double num2 = 4;

// Registration For Casting Vote
//Console.WriteLine("Enter First Name");
//string firstname = Console.ReadLine();
//Console.WriteLine("Enter Last Name");
//string LastName = Console.ReadLine();
//Console.WriteLine("Enter Your Age");
//int age = Convert.ToInt32( Console.ReadLine());


//if (age > 18)
//{
//    Console.WriteLine(firstname);
//    Console.WriteLine(LastName);
//    Console.WriteLine(age);
//}
//else if ()
//{

//}
//else
//{
//    Console.WriteLine("You are Not Eligible For the Vote");
//}

////first Number
//Console.WriteLine("Enter First Number");
//int number1 = Convert.ToInt32(Console.ReadLine());

////Second Number
//Console.WriteLine("Enter Second Number");
//int number2 = Convert.ToInt32(Console.ReadLine());

////Operator
//Console.WriteLine("Select an Operator \n 1. Addition \n 2. Subtraction \n 3. Multiplication \n 4. Division");
//string Opeator = Console.ReadLine();

//if (Opeator == "+" || Opeator == "1")
//{
//    Console.WriteLine(number1 + number2);
//}
//else if (Opeator == "-" || Opeator == "2")
//{
//    Console.WriteLine(number1 - number2);
//}
//else if(Opeator == "*" || Opeator == "3")
//{
//    Console.WriteLine(number1 * number2);
//}
//else if (Opeator == "/" || Opeator == "4")
//{
//    Console.WriteLine(number1 / number2);
//}
//else
//{
//    Console.WriteLine("You Input Wrong Operator");
//}


Console.WriteLine("Input any number here for percentage");

int percentage = Convert.ToInt32(Console.ReadLine());

switch (percentage)
{
    case int i when (i > 49 && i < 60):
        Console.WriteLine("You pass the exam and got Grade' C");
        break;
    case int i when (i > 59 && i < 70):
        Console.WriteLine("You pass the exam and got Grade' B");
        break;
    case int i when (i > 69 && i < 80):
        Console.WriteLine("You pass the exam and got Grade' A");
        break;
    case int i when (i > 79 && i <= 100):
        Console.WriteLine("You pass the exam and got Grade' A+");
        break;

    default:
        Console.WriteLine("You Enter Wrong Number");
        break;

}
