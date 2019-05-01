using System.Collections.Generic;
using System.Linq;
using HexArch.ApplicationCore.Repositories;
using HexArch.Domain.Students;

namespace HexArch.Infrastructure.EntityFrameworkDataAccess.Repositories
{
    public class StudentReadOnlyRepository : IStudentReadOnlyRepository
    {
        private readonly Context _context;

        public StudentReadOnlyRepository(Context context)
        {
            _context = context;
        }

        public IEnumerable<Student> GetAll()
        {
            var entities = _context.Students.ToList();

            var students = new List<Student>();

            foreach (var entity in entities)
            {
                var student = Student.Load(entity.Id, $"{entity.FirstName} {entity.LastName}");
                students.Add(student);
            }

            return students;
        }
    }
}
