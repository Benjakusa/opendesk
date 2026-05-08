using System.Collections.Generic;
using OpenDesk.Domain.Models.Tickets;

namespace OpenDesk.Services
{
    public interface IDepartmentService 
    {
        Department GetDepartment(int id);
        IEnumerable<Department> GetDepartments();
        void UpdatePriceTag(string departmentName,string priceTag);
        void ResetCache();
    }
}
