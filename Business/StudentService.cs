using Data.Models;
using Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class StudentService : IStudentService
    {
        private IOrnekRepository _ornekRepository;
        public StudentService(IOrnekRepository ornekRepository)
        {
            _ornekRepository = ornekRepository;
        }
        public string GetStudent(int id)
        {
            return _ornekRepository.GetById(id).StuName;
        }
    }

    public interface IStudentService
    {
        string GetStudent(int id);
    }
}
