

using DylanClassTest;

Console.WriteLine("Creating an employee");
Console.WriteLine("--------------------\n");

Employee dylan = new Employee("Dylan", "Drumgoole", "dylan@gmail.com", new DateTime(1998, 3, 5), 25);

dylan.DisplayEmployeeDetails();

dylan.PerformWork();
dylan.PerformWork();
dylan.PerformWork(5);
dylan.PerformWork();

double receivedWageDylan = dylan.ReceiveWage(true);
Console.WriteLine($"Wage paid (message from Program): {receivedWageDylan}");