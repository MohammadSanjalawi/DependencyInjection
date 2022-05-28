

using PropertyDependencyInjection;

EmployeeBAL employeeBAl = new EmployeeBAL();
employeeBAl.employeeDALObj = new EmployeeDAL();

List<EmployeeData> ListEmployee = employeeBAl.GetAllEmmployees();
foreach (EmployeeData emp in ListEmployee)
{
    Console.WriteLine("ID = {0}, Name = {1}, Department = {2}", emp.ID, emp.Name, emp.Department);
}
Console.ReadKey();
