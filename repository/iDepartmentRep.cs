using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CollegeManagement.Models;


namespace CollegeManagement.repository
{
    public interface iDepartmentRep

    {
        public List<Department> GetDetails();
        public Department GetDetail(int id);
        public int AddDetail(Department dt);
        public int UpdateDetail(int id, Department dt);
        public int Delete(int id);
    }
}
