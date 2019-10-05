using System;
using System.Collections.Generic;
using System.Text;

namespace NewBeeProject
{
    public static class Config
    {
        
        public const string APIURL = "http://api-newbee.herokuapp.com";
        public const string StudentEndpoint = "/student";
        public const string StudentSearchEndpoint = "/student/{UserID}";
        public const string CourseEndpoint = "/materia";
        public const string CourseSearchEndpoint = "/materia/{CourseID}";
        public const string DirectoryEndpoint = "/directorio";
        public const string DirectorySearchEndpoint = "/directorio/{Area}";


    }
}
