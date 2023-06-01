


//double ratePerHour = 12.87;
//double numberOfHoursWorked = 7.5;
//ratePerHour += 3;
//double pay = ratePerHour * numberOfHoursWorked;
//Console.WriteLine(pay);



//int intMaxValue = int.MaxValue;
//int intMinValue = int.MinValue;



//char userSelection = 'a';

//char upperVersion = char.ToUpper(userSelection);


//Console.ReadLine();



//DateTime hireDate = new DateTime(2023, 4, 4);


//Console.WriteLine(hireDate);


//DateTime exitDate = new DateTime(2025, 4, 4);

//DateTime startDate = hireDate.AddDays(22);

//Console.WriteLine(startDate);

//DateTime currentDate = DateTime.Now;
//bool areWeInDst = currentDate.IsDaylightSavingTime();

//DateTime startHour = DateTime.Now;
//TimeSpan workTime = new TimeSpan(8, 35, 0);
//DateTime endHour = startHour.Add(workTime);

//Console.WriteLine(startHour.ToLongDateString());
//Console.WriteLine(endHour);

//long myLargeValue = 123456789;

//int intValue = (int)myLargeValue;





//int age1 = 16;
//int age2 = 64;
//bool d = (age1 >= 18) && (age2 <= 65);
//Console.WriteLine("Age1 is greater than 18 AND age2 is less than 65: " + d);
//bool e = (age1 >= 18) || (age2 <= 65);
//Console.WriteLine("Age1 is greater than 18 OR age2 is less than 65: " + e);








//Console.WriteLine("Enter the age of the new candidate: ");
//int age = int.Parse(Console.ReadLine());

//if (age < 18)
//    Console.WriteLine("Too young to apply");
//else
//    Console.WriteLine("Great, you can now start with the application!");








//Console.WriteLine("Enter the age of the new candidate: ");
//int age = int.Parse(Console.ReadLine());

//switch (age)
//{
//    case < 18:
//        Console.WriteLine("Too young to apply");
//        break;
//    case > 65:
//        Console.WriteLine("Sorry, the selected age is too old");
//        break;
//    case 23:
//        Console.WriteLine("Wow, exactly what we are looking for");
//        break;
//    default:
//        Console.WriteLine("Great, you can continue!");
//        break;
//}







//string selectedAction = "";

//do
//{
//    Console.WriteLine("Choose the action you want to do: ");
//    Console.WriteLine("1. Add employee");
//    Console.WriteLine("2. Update employee");
//    Console.WriteLine("3. Delete employee");
//    Console.WriteLine("99. Exit application");
//    selectedAction = Console.ReadLine();

//    switch (selectedAction)
//    {
//        case "1":
//            Console.WriteLine("Adding new employee...");
//            break;
//        case "2":
//            Console.WriteLine("Updating employee...");
//            break;
//        case "3":
//            Console.WriteLine("Deleting employee...");
//            break;
//        default:
//            Console.WriteLine("Invalid input");
//            break;
//    }

//} while (selectedAction != "99");

//Console.WriteLine("Closing application");



//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(i);
//}



//Console.WriteLine("Enter a first number: ");

//string stringValue1 = Console.ReadLine();

//Console.WriteLine("Enter a second number: ");

//string stringValue2 = Console.ReadLine();       

//int intValue1 = int.Parse(stringValue1);
//int intValue2 = int.Parse(stringValue2);

//if (intValue1 == intValue2)
//    Console.WriteLine("The values are equal!");
//else if (intValue1 < intValue2)
//    Console.WriteLine("The first value is smaller!");
//else
//    Console.WriteLine("The second value is smaller!");



//int i = 0;

//while (i < 11) { 
//    Console.WriteLine(i++);
//};


//Value entered counts down and adds to itself until reaches 0 to have a total sum. User enters 5. 5+4+3+2+1=15. 15 is sum.

//Console.WriteLine("Enter a value:");
//int sum = 0;

//string stringValue = Console.ReadLine();

//int startValue = int.Parse(stringValue);


//for (int i = startValue; i > 0; i--)
//{
//   sum += i;
//}


//Console.WriteLine("The sum is " + sum);


