using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePortal_With_ISP
{
    public class EmployeeReport:IEmployeeReport
    {
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
