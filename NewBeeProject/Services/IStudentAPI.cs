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

        [Post(Config.StudentEndpoint)]
        Task<Student> RegisterStudent([Body] Student NewStudent);

        [Get(Config.StudentSearchEndpoint)]
        Task<Student> GetStudent(string UserID);
    }
}
