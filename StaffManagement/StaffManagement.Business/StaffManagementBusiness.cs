using System;
using System.Collections.Generic;
using System.Text;
using StaffManagementDesign.StaffManagement.Business.Interface;
using StaffManagementDesign.StaffManagement.Entities.Interface;
using StaffManagementDesign.StaffManagement.Repositories.Interface;

namespace StaffManagement.StaffManagement.Business
{
    public class StaffManagementBusiness : IStaffManagement
    {
        private IStaffRepository repo;

        public StaffManagementBusiness()
        {
        }

        public StaffManagementBusiness(IStaffRepository repository)
        {
            repo = repository;
        }

        public bool AddStaff(IStaff staff)
        {
            return repo.addStaff(staff);
        }

        public bool DeleteStaff(int staffID)
        {
            throw new NotImplementedException();
        }

        public IList<IStaff> GetAllStaffs()
        {
            throw new NotImplementedException();
        }

        public IStaff GetStaffByID(int staffID)
        {
            throw new NotImplementedException();
        }

        public bool UpdateStaff(IStaff staff)
        {
            throw new NotImplementedException();
        }
    }
}
