using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePortal_With_ISP
{
    public interface IEmployeeManagement
    {
        void AddEmployeeInformation();
        void EditEmployeeInformation();
        void DeleteEmployeeInformation();
    }
}
