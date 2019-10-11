
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NewBeeProject.Models;
using Refit;
using Xamarin.Essentials;

namespace NewBeeProject.Services
{
    public class APIService : IAPIService
    {
        NetworkAccess CurrentConnection = Connectivity.NetworkAccess;
        INewBeeAPI ApiResponse = RestService.For<INewBeeAPI>(Config.APIURL);
        async public Task<Student> CheckLogin(string UserID, string InsertedPassword)
        {
            if (CurrentConnection.Equals(NetworkAccess.Internet))
            {
                var StudentResult = await ApiResponse.GetStudent(UserID);
                return (StudentResult.Password == InsertedPassword ? StudentResult : null);
            }

            //TODO: Display "No internet' message and go back
            return null;
        }

        async public Task<bool> RegisterStudent(Student NewStudent)
        {
            if (CurrentConnection.Equals(NetworkAccess.Internet))
            {
                try
                {
                    await ApiResponse.RegisterStudent(NewStudent);
                    return true;
                }
                catch (ApiException error)
                {

                    return false;
                    // TODO: Error messages for different status codes
                }
            }

            //TODO: Display "No internet' message and go back
            return false;
        }


        async public Task<bool> RegisterCourse(Course NewCourse)
        {
            if (CurrentConnection.Equals(NetworkAccess.Internet))
            {
                try
                {
                    await ApiResponse.RegisterCourse(NewCourse);
                    return true;
                }
                catch (ApiException error)
                {

                    return false;
                    // TODO: Error messages for different status codes
                }
            }

            //TODO: Display "No internet' message and go back
            return false;
        }
        async public Task<Course> GetCourse(string CourseID)
        {
            if (CurrentConnection.Equals(NetworkAccess.Internet))
            {
                var CourseResult = await ApiResponse.GetCourse(CourseID);
                return CourseResult;
            }

            //TODO: Display "No internet' message and go back
            return null;
        }

       async public Task<Directory> GetDirectory(string Area)
        {
            if (CurrentConnection.Equals(NetworkAccess.Internet))
            {
                var DirectoryResult = await ApiResponse.GetDirectory(Area);
                return DirectoryResult;
            }

            //TODO: Display "No internet' message and go back
            return null;
        }

       async public Task<List<Course>> GetSchedule(string UserID)
        {
            if (CurrentConnection.Equals(NetworkAccess.Internet))
            {
                var DirectoryResult = await ApiResponse.GetSchedule(UserID);
                return DirectoryResult;
            }

            //TODO: Display "No internet' message and go back
            return null;
        }
    }
 
}
