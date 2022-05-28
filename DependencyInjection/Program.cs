

using ConstructorDependencyInjection;

EmployeeBAL employeeBAL = new EmployeeBAL(new EmployeeDAL());

List<EmployeeData> ListEmployee = employeeBAL.GetAllEmmployees();
foreach (EmployeeData emp in ListEmployee)
{
    Console.WriteLine("ID = {0}, Name = {1}, Department = {2}", emp.ID, emp.Name, emp.Department);
}
Console.ReadKey();
