using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WAEFCore22.AppCode.Interface;
using WAEFCore22.AppCode.Interface.Repos;
using WAEFCore22.Models.DbClassess;

namespace WAEFCore22.AppCode.BusinessLogic
{
    public class Student_GenRP : IStudent_GenRP
    {
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;

        public Student_GenRP(IUnitOfWorkFactory unitOfWorkFactory)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
        }

        public async Task<List<Student_Db>> GetAllStudentRP(int id)
        {
            try
            {
                using (var unitofwork = _unitOfWorkFactory.Create())
                {
                    var data = await unitofwork.Repository().FindAsync<Student_Db>(x => x._ID == id);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }

        public async Task<IEnumerable<Student_Db>> GetAllStudents()
        {
            try
            {
                using (var unitofwork = _unitOfWorkFactory.Create())
                {
                    var data = await unitofwork.Repository().FindAllRecords<Student_Db>();
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
