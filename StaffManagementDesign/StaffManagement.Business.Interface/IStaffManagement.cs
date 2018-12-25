using StaffManagementDesign.StaffManagement.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace StaffManagementDesign.StaffManagement.Business.Interface
{
    public interface IStaffManagement
    {
        bool AddStaff(IStaff staff);
        bool UpdateStaff(IStaff staff);
        bool DeleteStaff(int staffID);
        IList<IStaff> GetAllStaffs();
        IStaff GetStaffByID(int staffID);
    }
}
