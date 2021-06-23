using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePortal_With_ISP
{
    public class EmployeeManagment:IEmployeeManagement
    {
        public void AddEmployeeInformation()
        {
            Console.WriteLine("Employee Added");
        }

        public void DeleteEmployeeInformation()
        {
            Console.WriteLine("Employee Removed");
        }

        public void EditEmployeeInformation()
        {
            Console.WriteLine("Employee Updated");
        }
    }
}
