using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WAEFCore22.Models.DbClassess;

namespace WAEFCore22.AppCode.Interface
{
    public interface IStudent_BL
    {

        IEnumerable<Student_Db> GetAllStudents();
        IEnumerable<Student_Db> GetStudent(int id);
    }
}
