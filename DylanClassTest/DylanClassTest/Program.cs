

using System.Text;
using DylanClassTest;



Console.WriteLine("Creating an employee");
Console.WriteLine("--------------------\n");

Employee dylan = new Employee("Dylan", "Drumgoole", "dylan@gmail.com", new DateTime(1998, 3, 5), 25);


string dylanAsJson = dylan.ConvertToJson();
Console.WriteLine(dylanAsJson);


//string name = "Bethany";
//string anotherName = name;
//name += " Smith";

//Console.Write("Name: " + name);
//Console.WriteLine("Another name: " + anotherName);

//string indexes = string.Empty;

//for (int i = 0; i < 2500; i++)
//{
//    indexes += i.ToString();
//}

//StringBuilder builder = new StringBuilder();

//builder.Append("Last name: ");
//builder.AppendLine(lastName);
//builder.Append("First name: ");
//builder.Append(firstName);
//string result= builder.ToString();




//dylan.PerformWork(55);

//int minimumBonus = 100;
//int receivedBonus = dylan.CalculateBonus(minimumBonus);

//Console.WriteLine($"The minimum bonus is {minimumBonus} and {dylan.firstName} has received a bonus of {receivedBonus}");
//dylan.DisplayEmployeeDetails();

//dylan.PerformWork();
//dylan.PerformWork();
//dylan.PerformWork(5);
//dylan.PerformWork();

//int a = 42;
//int aCopy = a;


//Console.WriteLine($"{a},{aCopy}");

//double receivedWageDylan = dylan.ReceiveWage(true);
//Console.WriteLine($"Wage paid (message from Program): {receivedWageDylan}");