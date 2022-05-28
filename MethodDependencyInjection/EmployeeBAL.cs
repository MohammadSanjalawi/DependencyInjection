using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDependencyInjection
{
    internal class EmployeeBAL
    {
        public IEmployeeDAL employeeDAL;

        public List<EmployeeData> GetAllEmmployees(IEmployeeDAL employeeDAL)
        {
            this.employeeDAL = employeeDAL; 
            return employeeDAL.SelectAllEmployess();
        }
    }
}
