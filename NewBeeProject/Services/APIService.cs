
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

        //Student services
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


        async public Task<Student> UpdateStudent(string UserID, Student UpdatedStudent)
        {

            if (CurrentConnection.Equals(NetworkAccess.Internet))
            {
                var ConfirmedStudent = await ApiResponse.UpdateStudent(UserID,UpdatedStudent);
                return ConfirmedStudent;
            }

            //TODO: Display "No internet' message and go back
            return null;
        }

        //Course Services
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

        async public Task<List<Course>> GetAllCourses()
        {
            if (CurrentConnection.Equals(NetworkAccess.Internet))
            {
                var CourseResult = await ApiResponse.GetAllCourses();
                return CourseResult;
            }
            // No internet
            return null;
        }

        //Directory services
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

        async public Task<List<Directory>> GetAllDirectories()
        {
            if (CurrentConnection.Equals(NetworkAccess.Internet))
            {
                var DirectoryResult = await ApiResponse.GetAllDirectories();
                return DirectoryResult;
            }

            //TODO: Display "No internet' message and go back
            return null;
        }

        //Schedule Services
        async public Task<bool> RegisterCourse(string UserID, string CourseID)
        {
            if (CurrentConnection.Equals(NetworkAccess.Internet))
            {
                Schedule NewSchedule = new Schedule(UserID, CourseID);
                var RegisteredCourse = await ApiResponse.RegisterCourse(NewSchedule);
                return RegisteredCourse;
            }

            //TODO: Display "No internet' message and go back
            return false;
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
        async public Task<bool> DeleteSchedule(string UserID, string CourseID)
        {
            if (CurrentConnection.Equals(NetworkAccess.Internet))
            {
                var DeleteCourse = await ApiResponse.DeleteSchedule(UserID,CourseID);
                return DeleteCourse;
            }

            //TODO: Display "No internet' message and go back
            return false;
        }

       
    }
 
}
