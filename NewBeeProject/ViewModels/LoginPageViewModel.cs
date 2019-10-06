using NewBeeProject.Models;
using NewBeeProject.Services;
using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewBeeProject.ViewModels
{
    public class LoginPageViewModel: BaseViewModel
    {
        public DelegateCommand LoginCommand { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }
        public DelegateCommand NavRegisterCommand { get; set; }
        public LoginPageViewModel(INavigationService navigationService ,IAPIService APIservice) : base(navigationService,APIservice)
        {

            LoginCommand = new DelegateCommand(async () =>
              {
                 
                  if(!string.IsNullOrEmpty(UserID) || !string.IsNullOrEmpty(Password))
                  {
                      Student LoggedStudent = await APIservice.CheckLogin(UserID, Password);
                      if (!LoggedStudent.Equals(null))
                      {
                          if (!string.IsNullOrEmpty(LoggedStudent.CoursesID))
                          {
                              string[] CoursesID = LoggedStudent.CoursesID.Split(',');
                              LoggedStudent.StudentCoursesList = new List<Course>();
                              foreach (string CourseID in CoursesID)
                              {
                                  LoggedStudent.StudentCoursesList.Add(await APIservice.GetCourse(CourseID));
                              }
                          }
                          await AbsoluteGoToHome(LoggedStudent);
                      }
                      
                      // TODO: Login Error
                  }


                  //TODO: Incorrect login error message
              });

            NavRegisterCommand = new DelegateCommand(async () =>
            {
               await navigationService.NavigateAsync($"{NavConstants.Navigation}/{NavConstants.Registration}");
            });
        }
    }
}
