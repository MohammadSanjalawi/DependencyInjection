using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDependencyInjection
{
    internal class EmployeeBAL
    {
        public IEmployeeDAL employeeDAL;

        public EmployeeBAL(IEmployeeDAL employeeDAL)
        {
            this.employeeDAL = employeeDAL; 
        }


        public List<EmployeeData> GetAllEmmployees()
        {
            return employeeDAL.SelectAllEmployess();    
        }
    }
}
