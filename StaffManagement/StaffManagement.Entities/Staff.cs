using System;
using System.Collections.Generic;
using System.Text;
using StaffManagementDesign.StaffManagement.Entities.Interface;

namespace StaffManagement.StaffManagement.Entities
{
    public class Staff : IStaff
    {
        public int ID
        {
            get;
            set;
        }

        public string FirstName
        {
            get;
            set;
        }
        public string LastName
        {
            get;
            set;
        }
        public string Designation
        { get ;
          set;
        }
    }
}
