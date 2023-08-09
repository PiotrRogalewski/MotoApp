using MotoApp;

var stack = new BasicStack<double>();
stack.Push(5.5);
stack.Push(39);
stack.Push(222.7);

double sum = 0.0;

var stackForString = new BasicStack<string>();
stackForString.Push("Company X");
stackForString.Push("Company Y");
stackForString.Push("Company Z");


while (stack.Count > 0)
{ 
double item = stack.Pop();
    Console.WriteLine($"Item: {item}");
    sum += item;
}

Console.WriteLine($"Sum: {sum}\n");


//using MotoApp.Data;
//using MotoApp.Entities;
//using MotoApp.Repositories;

//var employeeRepository = new SqlRepository<Employee>(new MotoAppDbContext());
//AddEmployees(employeeRepository);
//AddManagers(employeeRepository);
//WriteAllToConsole(employeeRepository);

//static void AddEmployees(IRepository<Employee> employeeRepository)
//{
//    employeeRepository.Add(new Employee { FirstName = "Adam" });
//    employeeRepository.Add(new Employee { FirstName = "Piotr" });
//    employeeRepository.Add(new Employee { FirstName = "Zuzia" });
//    employeeRepository.Save();
//}

//static void AddManagers(IWriteRepository<Manager> managerRepository)
//{
//    managerRepository.Add(new Manager { FirstName = "Przemek" });
//    managerRepository.Add(new Manager { FirstName = "Tomek" });
//    managerRepository.Save();
//}

//static void WriteAllToConsole(IReadRepository<IEntity> repository)
//{
//    var items = repository.GetAll();
//    foreach (var item in items)
//    {
//        Console.WriteLine(item);
//    }
//}