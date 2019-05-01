using System;
using System.Collections.Generic;
using HexArch.Domain.Students;

namespace HexArch.ApplicationCore.Repositories
{
    public interface IStudentReadOnlyRepository
    {
        IEnumerable<Student> GetAll();
    }
}
