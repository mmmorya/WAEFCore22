using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WAEFCore22.Models.DbClassess;

namespace WAEFCore22.AppCode.Interface
{
    public interface IStudent_GenRP
    {

        Task<List<Student_Db>> GetAllStudentRP(int id);
    }
}
