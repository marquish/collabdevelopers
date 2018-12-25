using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnetcore.Models;
using Microsoft.AspNetCore.Mvc;
using StaffManagement.StaffManagement.Entities;
using StaffManagementDesign.StaffManagement.Repositories.Interface;
using StaffManagementDesign.StaffManagement.Entities.Interface;

namespace dotnetcore.Controllers
{
   
    public class StaffController : Controller
    {
        private readonly IStaffRepository _staffRepository;

        public StaffController(IStaffRepository staffRepo)
        {
            _staffRepository = staffRepo;                       
        }
      
        public string Index()
        {
            return "Welcome to staffpage";
        }

 
        public Staff GetByID(int id)
        {
            return (Staff)_staffRepository.getAllStaffs().Where(p => p.ID == id).FirstOrDefault();
        }


        public void AddStaff(IStaff staff)
        {
            bool result = _staffRepository.addStaff(staff);
            if (!result)
            {
                throw new Exception("Unable to Save Staff");
            }
        }
    }
}
