using System;
using Refit;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using NewBeeProject.Models;

namespace NewBeeProject.Services
{
    public interface INewBeeAPI
    {
        //Student endpoint
        [Post("/student")]
        Task RegisterStudent([Body] Student NewStudent);

        [Get("/student/{UserID}")]
        Task<Student> GetStudent(string UserID);

        //Course endpoint
        [Post("/materia")]
        Task RegisterCourse([Body] Course NewCourse);

        [Get("/materia/{CourseID}")]
        Task<Course> GetCourse(string CourseID);


        //Directory endpoint
        [Get("/directorio/{Area}")]
        Task<Directory> GetDirectory(string Area);

        [Get("/horario/{UserID}")]
        Task<List<Course>> GetSchedule(string UserID);

    }
}
