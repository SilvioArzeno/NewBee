using Newtonsoft.Json;

namespace NewBeeProject.Models
{
    public class Course
    {
        [JsonProperty (PropertyName ="nombre")]
        public string CourseName { get; set; }

        [JsonProperty(PropertyName = "codigo")]
        public string CourseID { get; set; }

        [JsonProperty(PropertyName = "seccion")]
        public int CourseSection { get; set; }

        [JsonProperty(PropertyName = "aula")]
        public string CourseRoom { get; set; }

        [JsonProperty(PropertyName = "horarioDias")]
        public string CourseScheduleDays { get; set; }

        [JsonProperty(PropertyName = "horarioHoras")]
        public string CourseScheduleHours { get; set; }

        [JsonProperty(PropertyName = "profesor")]
        public string CourseTeacher { get; set; }
    }
}
