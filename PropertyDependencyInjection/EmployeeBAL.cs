using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyDependencyInjection
{
    internal class EmployeeBAL
    {
        public IEmployeeDAL employeeDAL;

        public IEmployeeDAL employeeDALObj
        {

            set { this.employeeDAL = value; }
            get
            {
                if (employeeDALObj == null)
                {
                    throw new Exception("Employee is not initialized");
                }
                else
                {
                    return employeeDAL;
                }

            }

        }


        public List<EmployeeData> GetAllEmmployees()
        {
            return employeeDAL.SelectAllEmployess();
        }
    }
}
