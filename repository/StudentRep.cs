using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CollegeManagement.Models;

namespace CollegeManagement.repository
{
    public class StudentRep : iStudentRep
    {
        collegeManagementContext db;
        public StudentRep(collegeManagementContext _db)
        {
            db = _db;
        }

        public List<Student> GetDetails()
        {
            return db.Students.ToList();
        }

        public Student GetDetail(int id)
        {
            if (db != null)
            {
                return (db.Students.Where(x => x.Id == id)).FirstOrDefault();
            }
            return null;
        }

        public int AddDetail(Student emp)
        {
            db.Students.Add(emp);
            db.SaveChanges();

            return emp.Id;
        }



        public int UpdateDetail(int id, Student emp)
        {
            if (db != null)
            {
                var obj = (db.Students.Where(x => x.Id == id)).FirstOrDefault();
                if (obj != null)
                {
                    obj.FirstName = emp.FirstName;
                    obj.LastName = emp.LastName;
                    obj.Gender = emp.Gender;
                    obj.Id = emp.Id;
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

                var post = db.Students.FirstOrDefault(x => x.Id == id);

                if (post != null)
                {

                    db.Students.Remove(post);
                    result = db.SaveChanges();
                    return 1;
                }
                return result;
            }

            return result;

        }
    }
}

    

