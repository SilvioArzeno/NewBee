using System;
using Refit;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NewBeeProject.Models;

namespace NewBeeProject.Services
{
    public interface IStudentAPI
    {

        [Get("")]
        Task VerifyConnection();

        [Post("/student")]
        Task<Student> RegisterStudent([Body] Student NewStudent);

        [Get("/student/{UserID}")]
        Task<Student> GetStudent(string UserID);
    }
}
