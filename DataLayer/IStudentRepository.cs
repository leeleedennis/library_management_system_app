using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataLayer
{
    public interface IStudentRepository
    {
        List<Student> GetAll();

        Student GetById(int Id);

        Student Insert(Student obj);

        void Update(Student obj);

        void Delete(Student obj);
    }
}

