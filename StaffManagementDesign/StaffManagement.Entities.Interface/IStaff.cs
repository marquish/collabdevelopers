using System;
using System.Collections.Generic;
using System.Text;

namespace StaffManagementDesign.StaffManagement.Entities.Interface
{
    public interface IStaff
    {
        int ID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Designation { get; set; }
    }
}
