
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
        [Get("")]
        Task VerifyConnection();

        [Post("/student")]
        Task<string> RegisterStudent([Body] string NewStudent);

        [Get("/student/{matricula}")]
        Task<Student> GetStudent(string matricula);

        

    }
}
