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


using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text.Json.Serialization;

int electedcandidate = 30;
string bilal = "Bilal";

// Create an anonymous object with dynamic content
var data = new
{
    age = electedcandidate,
    name = bilal
};

// Serialize the object to a JSON-formatted string
var jsonString = JsonConvert.SerializeObject(data);

Console.WriteLine(jsonString);

