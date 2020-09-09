using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CollegeManagement.Models;

namespace CollegeManagement.repository
{
    public interface iStudentRep
    {
        public List<Student> GetDetails();
        public Student GetDetail(int id);
        public int AddDetail(Student st);
        public int UpdateDetail(int id, Student emp);
        public int Delete(int id);
    }
}
