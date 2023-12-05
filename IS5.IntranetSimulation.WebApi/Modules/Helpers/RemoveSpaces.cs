using IS5.IntranetSimulation.WebApi.DomainLayer.Entity;

namespace IS5.IntranetSimulation.WebApi.Modules.Helpers
{
    public static class RemoveSpaces
    {
        public static IEnumerable<Professor> RemoveSpaceListProfessor(IEnumerable<Professor> professors)
        {
            foreach (var professor in professors)
            {
                professor.FullName = professor.FullName.Trim();
                professor.Dni = professor.Dni.Trim();
            }
            return professors;
        }
        public static Professor RemoveSpaceProfessor(Professor professor)
        {
            professor.FullName = professor.FullName.Trim();
            professor.Dni = professor.Dni.Trim();

            return professor;
        }
        public static IEnumerable<Student> RemoveSpaceListStudent(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                student.UniversityCode = student.UniversityCode.Trim();
                student.FullName = student.FullName.Trim();
                student.RegistrationFormNumber = student.RegistrationFormNumber.Trim();
                student.Semester = student.Semester.Trim();
                student.School = student.School.Trim();
            }
            return students;
        }
        public static Student RemoveSpaceStudent(Student student)
        {
            student.UniversityCode = student.UniversityCode.Trim();
            student.FullName = student.FullName.Trim();
            student.RegistrationFormNumber = student.RegistrationFormNumber.Trim();
            student.Semester = student.Semester.Trim();
            student.School = student.School.Trim();

            return student;
        }
    }
}
