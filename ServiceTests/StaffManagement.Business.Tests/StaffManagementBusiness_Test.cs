using System;
using Xunit;
using StaffManagement.StaffManagement.Business;
using StaffManagement.StaffManagement.Repositories;

namespace StaffLibrary.Tests.StaffManagement.Business.Tests
{
    public class StaffManagementBusiness_Test
    {
        private readonly StaffManagementBusiness business;
        private readonly StaffManagementRepository repo;
        
    
        public StaffManagementBusiness_Test()
        {
            business = new StaffManagementBusiness();
        }

        [Fact]
        public void ShouldBeInitialized_WithRepositoryObject()
        {
            var business2 = new StaffManagementBusiness(repo);
            Assert.IsType(business2.GetType(), business);
        }
        
    }
}
