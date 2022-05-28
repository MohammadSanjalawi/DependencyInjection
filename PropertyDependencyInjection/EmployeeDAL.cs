using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyDependencyInjection
{
    internal interface IEmployeeDAL
    {
        List<EmployeeData> SelectAllEmployess();
    }
    internal class EmployeeDAL : IEmployeeDAL
    {
        public List<EmployeeData> SelectAllEmployess()
        {
            List<EmployeeData> ListEmployees = new List<EmployeeData>();
            //Get the Employees from the Database
            //for now we are hard coded the employees
            ListEmployees.Add(new EmployeeData() { ID = 1, Name = "Pranaya", Department = "IT" });
            ListEmployees.Add(new EmployeeData() { ID = 2, Name = "Kumar", Department = "HR" });
            ListEmployees.Add(new EmployeeData() { ID = 3, Name = "Rout", Department = "Payroll" });
            return ListEmployees; ;
        }
    }
}
