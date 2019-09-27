
using NewBeeProject.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewBeeProject.Services
{
    public interface IAPIService
    {
        [Get("")]
        Task VerifyConnection();

        [Post("/student")]
        Task<Student> RegisterStudent([Body] Student NewStudent);

        [Get("/student/{matricula}")]
        Task<Student> GetStudent(string matricula);

        

    }
}
