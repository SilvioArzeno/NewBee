using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NewBeeProject.Models;
using Newtonsoft.Json;
using Refit;

namespace NewBeeProject.Services
{
    public class APIService : IAPIService
    {
        async public Task<bool> CheckLogin(string UserID, string InsertedPassword)
        {
            var apiResponse = RestService.For<IStudentAPI>(Config.APIURL);
            var StudentResult = await apiResponse.GetStudent(UserID);
            if(StudentResult.Password == InsertedPassword)
            {
                return true;
            }
            return false;
        }

        async public Task<bool> RegisterStudent(Student NewStudent)
        {
            var apiResponse = RestService.For<IStudentAPI>(Config.APIURL);
            await apiResponse.RegisterStudent(NewStudent);


    
            return true;
        }
    }
 
}
