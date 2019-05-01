using System;
using System.Collections.ObjectModel;
using HexArch.Domain.Students;

namespace HexArch.Infrastructure.InMemoryDataAccess
{
    public class Context
    {
        public Collection<Student> Students { get; set; }

        public Context()
        {
            Students = new Collection<Student>();

            SeedData();
        }

        private void SeedData()
        {
            Students.Add(Student.Load(Guid.Parse("3e7452bc-4408-400c-b3dc-1809e17fd853"), "Dominika Biegańska"));
            Students.Add(Student.Load(Guid.Parse("197a4289-2635-4b82-88dc-fbb1ba95fdd9"), "Gabi Drzewiecka"));
            Students.Add(Student.Load(Guid.Parse("86c27c80-8f2e-487f-b8b2-733813cffa15"), "Martyna Wawryło"));
        }
    }
}
