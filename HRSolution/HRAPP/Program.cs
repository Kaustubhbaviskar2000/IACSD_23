using HRAPP.Entities;
using HRAPP.Services;
using HRAPP.Controllers;
using HRAPP.Views;

IEmployeeService svc=new EmployeeService();
EmployeesController controller=new EmployeesController(svc);
List<Employee> model=controller.GetAll();
ListView view=new ListView(model);
view.Render();
Console.WriteLine("Welcome to MVC in C#");


Console.WriteLine("enter employees details");
Employee emp = new Employee(int.Parse(Console.ReadLine()),Console.ReadLine());
svc.Insert(emp);

view.Render();