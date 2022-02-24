using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WAEFCore22.AppCode.Connections;
using WAEFCore22.AppCode.Interface;
using WAEFCore22.Models.DbClassess;

namespace WAEFCore22.AppCode.BusinessLogic
{
    public class Student_BL :IStudent_BL
    {
        private readonly AppDbContext _appDbContext;
        public Student_BL(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Student_Db> GetAllStudents()
        {
            return _appDbContext.tbl_Student;
        }

        public IEnumerable<Student_Db> GetStudent(int id)
        {
            var resp = new List<Student_Db>();
            try
            {
                var param = new SqlParameter("@id", id);
                resp = _appDbContext.proc_GetStudent.FromSqlRaw("exec proc_GetStudent @id={0}", id).ToList();

            }
            catch (Exception)
            {
                throw;
            }
            return resp;
        }
    }
}
