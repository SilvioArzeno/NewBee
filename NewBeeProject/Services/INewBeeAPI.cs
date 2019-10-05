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
        [Post(Config.CourseEndpoint)]
        Task<bool> RegisterCourse([Body] Course NewCourse);

        [Get(Config.CourseSearchEndpoint)]
        Task<Course> GetCourse(string CourseID);


        //Directory endpoint
        [Post(Config.DirectorySearchEndpoint)]
        Task<Directory> GetDirectory(string Area);

    }
}
