using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePortal_Without_ISP
{
    public class EmployeeManagment : IEmployee
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

        public void GetEmployeesReportAsExcel()
        {
            Console.WriteLine("Employee Report in Excel");
        }

        public void GetEmployeesReportAsPdf()
        {
            Console.WriteLine("Employee Report in PDF");
        }
    }
}
