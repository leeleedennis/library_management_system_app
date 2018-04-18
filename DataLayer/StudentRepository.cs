using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataLayer
{
    public class StudentRepository : IStudentRepository
    {
        LibraryManagementEntities ctx = new LibraryManagementEntities();

        public void Delete(Student obj)
        {
            ctx.Students.Attach(obj);
            ctx.Students.Remove(obj);
            ctx.SaveChanges();
        }

        public List<Student> GetAll()
        {
            return ctx.Students.ToList();
        }

        public Student GetById(int Id)
        {
            return ctx.Students.Find(Id);
        }

        public Student Insert(Student obj)
        {
            ctx.Students.Add(obj);
            ctx.SaveChanges();
            return obj;
        }

        public void Update(Student obj)
        {
            ctx.Students.Attach(obj);
            ctx.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            ctx.SaveChanges();
        }
    }
}
