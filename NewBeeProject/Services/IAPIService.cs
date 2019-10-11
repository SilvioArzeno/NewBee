
using NewBeeProject.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewBeeProject.Services
{
    [Headers("Content-Type: application/json")]
    public interface IAPIService
    {
        //Student endpoint tasks
       Task<Student> CheckLogin(string matricula, string InsertedPassword);

        Task<bool> RegisterStudent(Student NewStudent);

        Task<Student> UpdateStudent(string UserID,Student UpdatedStudent);

        //Course Endpoint tasks
        Task<List<Course>> GetAllCourses();
        Task<Course> GetCourse(string CourseID);

        //Directory endpoint tasks
        Task<Directory> GetDirectory(string Area);

        //Schedule endpoint tasks

        Task<List<Course>> GetSchedule(string UserID);

        Task<bool> RegisterCourse(string UserID, string CourseID);

        Task<bool> DeleteCourse(string UserID, string CourseID);

    }
}
