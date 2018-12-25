using System;
using System.Collections.Generic;
using System.Text;
using StaffManagementDesign.StaffManagement.Entities.Interface;

namespace StaffManagementDesign.StaffManagement.Repositories.Interface
{
    public interface IStaffRepository
    {
        bool addStaff(IStaff staff);
        bool updateStaff(IStaff staff);
        bool removeStaff(IStaff staff);
        List<IStaff> getAllStaffs();
    }
}
