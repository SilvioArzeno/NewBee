using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewBeeProject.Models
{
   public class Student
       {
        [JsonProperty(PropertyName ="activo")]
        public bool Active { get; set; } = true;
        [JsonProperty(PropertyName = "apellidos")]
        public string Apellidos { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "matricula")]
        public string Matricula { get; set; }

        [JsonProperty(PropertyName = "nombres")]
        public string Nombres { get; set; }

        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

    }
    
}
