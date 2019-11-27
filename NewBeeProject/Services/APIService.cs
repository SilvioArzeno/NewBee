
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NewBeeProject.Models;
using Prism.Services;
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
               if(await ApiResponse.VerifyStudent(UserID, InsertedPassword))
                {
                    return await ApiResponse.GetStudent(UserID);
                }

                return null;
            }

            await NoInternetAlert();
            return null;
        }

        async public Task<bool> RegisterStudent(Student NewStudent)
        {
            if (CurrentConnection.Equals(NetworkAccess.Internet))
            {
                    await ApiResponse.RegisterStudent(NewStudent);
                    return true;
            }

            await NoInternetAlert();
            return false;
        }


        async public Task<Student> UpdateStudent(string UserID, Student UpdatedStudent)
        {

            if (CurrentConnection.Equals(NetworkAccess.Internet))
            {
                var ConfirmedStudent = await ApiResponse.UpdateStudent(UserID,UpdatedStudent);
                return ConfirmedStudent;
            }

            await NoInternetAlert();
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

            await NoInternetAlert();
            return null;
        }

        async public Task<List<Course>> GetAllCourses()
        {
            if (CurrentConnection.Equals(NetworkAccess.Internet))
            {
                var CourseResult = await ApiResponse.GetAllCourses();
                return CourseResult;
            }
            await NoInternetAlert();
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

            await NoInternetAlert();
            return null;
        }

        async public Task<List<Directory>> GetAllDirectories()
        {
            if (CurrentConnection.Equals(NetworkAccess.Internet))
            {
                var DirectoryResult = await ApiResponse.GetAllDirectories();
                return DirectoryResult;
            }

            await NoInternetAlert();
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

            await NoInternetAlert();
            return false;
        }

        async public Task<List<Course>> GetSchedule(string UserID)
        {
            if (CurrentConnection.Equals(NetworkAccess.Internet))
            {
                var DirectoryResult = await ApiResponse.GetSchedule(UserID);
                return DirectoryResult;
            }

            await NoInternetAlert();
            return null;
        }
        async public Task<bool> DeleteSchedule(string UserID, string CourseID)
        {
            if (CurrentConnection.Equals(NetworkAccess.Internet))
            {
                var DeleteCourse = await ApiResponse.DeleteSchedule(UserID,CourseID);
                return DeleteCourse;
            }

            await NoInternetAlert();
            return false;
        }


       async public Task<CollegeTask> RegisterTask(CollegeTask NewTask)
        {
            if (CurrentConnection.Equals(NetworkAccess.Internet))
            {
                var TaskResult = await ApiResponse.AddTask(NewTask);
                return TaskResult;
            }

            await NoInternetAlert();
            return null;
        }

        async public Task<List<CollegeTask>> GetAllTasks(string StudentID)
        {
            if (CurrentConnection.Equals(NetworkAccess.Internet))
            {
                var TaskList = await ApiResponse.GetTasks(StudentID);
                return TaskList;
            }

            await NoInternetAlert();
            return null;
        }

       async public Task UpdateTask(string TaskID)
        {
            if (CurrentConnection.Equals(NetworkAccess.Internet))
            {
                await ApiResponse.UpdateTask(TaskID);
                return;
            }

            await NoInternetAlert();
            return;
        }

        async public Task DeleteTask(string TaskID)
        {
            if (CurrentConnection.Equals(NetworkAccess.Internet))
            {
                await ApiResponse.DeleteTask(TaskID);
                return;
            }

            await NoInternetAlert();
            return;
        }


        async public Task NoInternetAlert()
        {
            await App.Current.MainPage.DisplayAlert("No internet", "No internet conenction try again later", "Ok");
        }
    }
 
}
