using System.ComponentModel;

namespace IS5.IntranetSimulation.WebApi.DomainLayer.Entity
{
    public class Student
    {
        [Description("student_id")]
        public int Id { get; set; }
        [Description("student_university_code")]
        public String UniversityCode { get; set; }
        [Description("student_full_name")]
        public String FullName { get; set; }
        [Description("student_registration_form_number")]
        public String RegistrationFormNumber { get; set; }
        [Description("student_semester")]
        public String Semester { get; set; }
        [Description("student_school")]
        public String School { get; set; }
    }
}
