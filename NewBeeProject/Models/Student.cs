using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewBeeProject.Models
{
   public class Student
       {
        [JsonProperty(PropertyName ="active")]
        public bool Active { get; set; } = true;


        [JsonProperty(PropertyName = "nombres")]
        public string FirstName { get; set; }

        [JsonProperty(PropertyName = "apellidos")]
        public string LastName { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "matricula")]
        public string StudentID { get; set; }


        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

    }
    
}
