using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CollegeManagement.Models;


namespace CollegeManagement.repository
{
    public class DepartmentRep : iDepartmentRep
    {
        collegeManagementContext db;
        public DepartmentRep(collegeManagementContext _db)
        {
            db = _db;
        }

        public List<Department> GetDetails()
        {
            return db.Departments.ToList();
        }

        public Department GetDetail(int id)
        {
            if (db != null)
            {
                return (db.Departments.Where(x => x.Id == id)).FirstOrDefault();
            }
            return null;
        }

        public int AddDetail(Department emp)
        {
            db.Departments.Add(emp);
            db.SaveChanges();

            return emp.Id;
        }



        public int UpdateDetail(int id, Department dt)
        {
            if (db != null)
            {
                var obj = (db.Departments.Where(x => x.Id == id)).FirstOrDefault();
                if (obj != null)
                {
                    obj.Name = dt.Name;
                    
                    
                    obj.Id = dt.Id;
                    db.SaveChanges();
                    return 1;
                }
                return 0;
            }
            return 0;
        }

        public int Delete(int id)
        {
            int result = 0;

            if (db != null)
            {

                var post = db.Departments.FirstOrDefault(x => x.Id == id);

                if (post != null)
                {

                    db.Departments.Remove(post);
                    result = db.SaveChanges();
                    return 1;
                }
                return result;
            }

            return result;

        }
    }
}

    


