using Refleksja;



var employees = EmployeeProvider.GetEmployees();
Employee? employee;

bool programRunning = true;
while (programRunning)
{
    Console.WriteLine("Search for an employee with ID: ");
    var id = Console.ReadLine();

    if (int.TryParse(id, out int employeeId))
    {
        employee = employees.Where(e => e.Id == employeeId).FirstOrDefault();
    }
    else
    {
        Console.WriteLine("Wrong value provided");
        continue;
    }
    if (employee == null)
    {
        Console.WriteLine("Employee not found");
        continue;
    }
    

    ObjectHelper.Display(employee);

    Console.WriteLine("Provide name of the value to change: ");

    var valueToChange = Console.ReadLine();

    if (valueToChange == null)
    {
        Console.WriteLine("Wrong value provided");
        continue;
    }

    Console.WriteLine("The new value: ");

    var newValue = Console.ReadLine();

    if (newValue == null)
    {
        Console.WriteLine("Wrong value provided");
        continue;
    }

    ObjectHelper.ChangeValue(employee, valueToChange, newValue);
    ObjectHelper.Display(employee);
}

