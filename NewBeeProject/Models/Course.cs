using Newtonsoft.Json;

namespace NewBeeProject.Models
{
    public class Course
    {
        public string CourseName { get; set; }

        public string CourseID { get; set; }

        public int CourseSection { get; set; }

        public string CourseRoom { get; set; }

        public string CourseScheduleDays { get; set; }
        public string CourseScheduleHours { get; set; }
        public string CourseTeacher { get; set; }
    }
}
