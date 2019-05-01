using System.Collections.Generic;
using HexArch.ApplicationCore.Repositories;
using HexArch.Domain.Students;

namespace HexArch.Infrastructure.InMemoryDataAccess.Repositories
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
            return _context.Students;
        }
    }
}
