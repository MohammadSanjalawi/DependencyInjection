using MethodDependencyInjection;

EmployeeBAL employeeBAL = new EmployeeBAL();

List<EmployeeData> ListEmployee = employeeBAL.GetAllEmmployees(new EmployeeDAL());

foreach (EmployeeData emp in ListEmployee)
{
    Console.WriteLine("ID = {0}, Name = {1}, Department = {2}", emp.ID, emp.Name, emp.Department);
}
Console.ReadKey();
