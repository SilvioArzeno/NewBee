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

        [Put("/student/{UserID}")]
        Task<Student> UpdateStudent(string UserID, [Body] Student UpdatedStudent);

        //Course endpoint

        [Get("/materia")]
        Task<List<Course>> GetAllCourses();
        [Get("/materia/{CourseID}")]
        Task<Course> GetCourse(string CourseID);


        //Directory endpoint
        [Get("/directorio/{Area}")]
        Task<Directory> GetDirectory(string Area);

        //Schedule endpoint


        [Post("/horario")]
        Task<bool> RegisterCourse([Body] Horario NewSchedule);


        [Get("/horario/{UserID}")]
        Task<List<Course>> GetSchedule(string UserID);


        [Delete("/horario/{UserID}/{CourseID}")]
        Task<bool> DeleteCourse(string UserID, string CourseID);
    }
}
