using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes;

public class InstructorDal : IInstructorDal
{
    List<Instructor> _instructors;
    public InstructorDal()
    {
        _instructors = new List<Instructor>
        {
            new Instructor
        {
            InstructorId = 1,
            InstructorFirstName = "Engin",
            InstructorLastName = "Demiroğ",
            InstructorEmail = "engindemir@gmail.com",
            // Additional details (optional):
            // - Years of experience: 15
            // - Expertise: C#, ASP.NET, SQL Server, software architecture
        },

            // 2. Ayşe Gül
        new Instructor
        {
            InstructorId = 2,
            InstructorFirstName = "Ayşe",
            InstructorLastName = "Gül",
            InstructorEmail = "aysegul@hotmail.com",
            // Additional details (optional):
            // - Years of experience: 8
            // - Expertise: Java, Spring Boot, React, web development
        },

        // 3. Ali Yıldırım
        new Instructor
        {
            InstructorId = 3,
            InstructorFirstName = "Ali",
            InstructorLastName = "Yıldırım",
            InstructorEmail = "aliyildirim@yahoo.com",
            // Additional details (optional):
            // - Years of experience: 5
            // - Expertise: Python, data analysis, machine learning, artificial intelligence
        },
        };
    }
    public void Add(Instructor instructor)
    {
        _instructors.Add(instructor);
    }

    public void Delete(Instructor instructor)
    {
        _instructors.Remove(instructor);
    }

    public void DeleteById(int id)
    {
        _instructors.Remove(_instructors[id]);
    }

    public List<Instructor> GetAll()
    {
        return _instructors;
    }

    public void Update(Instructor instructor)
    {
        throw new NotImplementedException();
    }
}