
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
       Task<bool> CheckLogin(string matricula, string InsertedPassword);

        Task<bool> RegisterStudent(Student NewStudent);

        Task<bool> RegisterCourse(Course NewCourse);

        Task<Course> GetCourse(string CourseID);

        Task<Directory> GetDirectory(string Area);
    }
}
