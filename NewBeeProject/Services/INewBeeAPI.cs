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

        [Get("/course")]
        Task<List<Course>> GetAllCourses();
        [Get("/course/{CourseID}")]
        Task<Course> GetCourse(string CourseID);

        [Post("/student/{userID}/{insertedPassword}")]
        Task<bool> VerifyStudent(string userID, string insertedPassword);


        //Directory endpoint
        [Get("/directory/{Area}")]
        Task<Directory> GetDirectory(string Area);

        [Get("/directory")]
        Task<List<Directory>> GetAllDirectories();

        //Schedule endpoint


        [Post("/schedule")]
        Task<bool> RegisterCourse([Body] Schedule NewSchedule);


        [Get("/schedule/{UserID}")]
        Task<List<Course>> GetSchedule(string UserID);


        [Delete("/schedule/{UserID}/{CourseID}")]
        Task<bool> DeleteSchedule(string UserID, string CourseID);


        // Task Endpoint

        [Post("/tasks")]
        Task<CollegeTask> AddTask([Body] CollegeTask NewTask);

        [Get("/tasks/{StudentID}")]
        Task<List<CollegeTask>> GetTasks(string StudentID);

        [Put("/tasks/{TaskID}")]
        Task UpdateTask(string TaskID);

        [Delete("/tasks/{TaskID}")]

        Task DeleteTask(string TaskID);


    }
}
