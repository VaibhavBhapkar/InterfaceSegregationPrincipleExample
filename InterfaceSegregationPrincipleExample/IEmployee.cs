using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePortal_Without_ISP
{
    public interface IEmployee
    {
        void AddEmployeeInformation();
        void EditEmployeeInformation();
        void DeleteEmployeeInformation();
        void GetEmployeesReportAsPdf();
        void GetEmployeesReportAsExcel();
    }
}
