using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NewBeeProject.Models;
using Refit;

namespace NewBeeProject.Services
{
    public class APIService
    {
        async public Task<bool> CheckLogin(string matricula, string InsertedPassword)
        {
            var apiResponse = RestService.For<IAPIService>(Config.APIURL);
            var StudentResult = await apiResponse.GetStudent(matricula);
            if(StudentResult.Password == InsertedPassword)
            {
                return true;
            }
            return false;
        }

        async public Task<bool> RegisterStudent(Student NewStudent)
        {
            var apiResponse = RestService.For<IAPIService>(Config.APIURL);
            var RegisterStudent = await apiResponse.RegisterStudent(NewStudent);

            if (RegisterStudent.Equals(NewStudent))
            {
                return true;
            }

            return false;
        }
    }
 
}
