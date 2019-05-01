using System;

namespace HexArch.Domain.Students
{
    public class Student
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }

        private Student() { }

        public Student(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }

        public static Student Load(Guid id, string name)
        {
            var student = new Student();

            student.Id = id;
            student.Name = name;

            return student;
        }
    }
}
