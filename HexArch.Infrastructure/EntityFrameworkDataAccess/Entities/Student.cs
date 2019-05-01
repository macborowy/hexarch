using System;

namespace HexArch.Infrastructure.EntityFrameworkDataAccess.Entities
{
    public class Student
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
