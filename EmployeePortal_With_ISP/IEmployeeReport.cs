using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePortal_With_ISP
{
    public interface IEmployeeReport
    {
        void GetEmployeesReportAsPdf();
        void GetEmployeesReportAsExcel();
    }
}
