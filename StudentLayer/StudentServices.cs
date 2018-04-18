using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using Model;

namespace StudentLayer
{

    public static class StudentServices
    {
        static IStudentRepository repository;

        static StudentServices()
        {
            
            repository = new StudentRepository();
        }

        public static List<Student> GetAll()
        {
            return repository.GetAll();
        }

        public static Student GetById(int Id)
        {
            return repository.GetById(Id);
        }

        public static Student Insert(Student obj)
        {
            return repository.Insert(obj);
        }

        public static void Update(Student obj)
        {
            repository.Update(obj);
        }

        public static void Delete(Student obj)
        {
            repository.Delete(obj);
        }

       
    }
}
