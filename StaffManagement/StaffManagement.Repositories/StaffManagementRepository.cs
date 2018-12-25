using Microsoft.Extensions.Configuration;
using StaffManagementDesign.StaffManagement.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using StaffManagementDesign.StaffManagement.Repositories.Interface;
using Dapper;

namespace StaffManagement.StaffManagement.Repositories
{
    public class StaffManagementRepository: IStaffRepository
    {

        private readonly IConfiguration staffConfig;

        public StaffManagementRepository(IConfiguration config)
        {
            staffConfig = config;

        }
        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(staffConfig.GetConnectionString("MyConnectionString"));
            }
        }

        public bool addStaff(IStaff staff)
        {
            int returnvalue = 0;
            try
            {
                DynamicParameters qp = new DynamicParameters();
                qp.Add("@ID", staff.ID);
                qp.Add("@FirstName", staff.FirstName);
                qp.Add("@LastName", staff.LastName);
                qp.Add("@Designation", staff.Designation);
                using (IDbConnection connection = Connection)
                {
                   returnvalue = SqlMapper.Execute(connection, "AddStaff", param: qp, commandType: CommandType.StoredProcedure);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return (returnvalue==1); // true only if one row is affected

        }

        public List<IStaff> getAllStaffs()
        {
            throw new NotImplementedException();
        }

        public bool removeStaff(IStaff staff)
        {
            throw new NotImplementedException();
        }

        public bool updateStaff(IStaff staff)
        {
            throw new NotImplementedException();
        }
    }
}
