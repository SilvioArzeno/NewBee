
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
       Task<Student> CheckLogin(string StudentID, string InsertedPassword);

        Task<bool> RegisterStudent(Student NewStudent);

        Task<Student> UpdateStudent(string StudentID,Student UpdatedStudent);

        //Course Endpoint tasks
        Task<List<Course>> GetAllCourses();
        Task<Course> GetCourse(string CourseID);

        //Directory endpoint tasks
        Task<Directory> GetDirectory(string Area);

        Task<List<Directory>> GetAllDirectories();

        //Schedule endpoint tasks

        Task<List<Course>> GetSchedule(string StudentID);

        Task<bool> RegisterCourse(string StudentID, string CourseID);

        Task<bool> DeleteSchedule(string StudentID, string CourseID);


        //CollegeTasks endpoint tasks

        Task<CollegeTask> RegisterTask(CollegeTask NewTask);

        Task<List<CollegeTask>> GetAllTasks(string StudentID);

        Task UpdateTask(string TaskID);

        Task DeleteTask(string TaskID);

    }
}
