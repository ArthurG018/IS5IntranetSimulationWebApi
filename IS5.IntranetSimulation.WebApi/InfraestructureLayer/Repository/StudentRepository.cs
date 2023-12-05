using Dapper;
using IS5.IntranetSimulation.WebApi.CrossLayer.Interface;
using IS5.IntranetSimulation.WebApi.DomainLayer.Entity;
using IS5.IntranetSimulation.WebApi.InfraestructureLayer.Interface;
using IS5.IntranetSimulation.WebApi.Modules.HelperMapping;
using System.Data;

namespace IS5.IntranetSimulation.WebApi.InfraestructureLayer.Repository
{
    public class StudentRepository:IStudentRepository
    {
        private readonly IConnectionDataBase _connection;

        public StudentRepository(IConnectionDataBase connection)
        {
            _connection = connection;
        }
        #region CRUD
        public bool InsertStudent(Student student)
        {
            using (var db = _connection.GetConnection)
            {
                var query = "sp_insert_student";
                var parameters = new DynamicParameters();
                parameters.Add("university_code", student.UniversityCode);
                parameters.Add("full_name", student.FullName);
                parameters.Add("registration_form_number", student.RegistrationFormNumber);
                parameters.Add("semester", student.Semester);
                parameters.Add("school", student.School);

                var result = db.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }
        public bool InsertAllStudent(String consulta)
        {
            using (var db = _connection.GetConnection)
            {
                var query = "sp_insert_all_students";
                var parameters = new DynamicParameters();
                parameters.Add("query", consulta);

                var result = db.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }
        public Student GetStudent(int id)
        {
            using (var db = _connection.GetConnection)
            {
                var query = "sp_get_student_by_id";
                var parameters = new DynamicParameters();
                parameters.Add("student_id", id);

                MappingForDescription.MapStudent();

                var result = db.QuerySingle<Student>(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
        }
        public IEnumerable<Student> GetAllStudent()
        {
            using (var db = _connection.GetConnection)
            {
                var query = "sp_get_all_students";

                MappingForDescription.MapStudent();

                var result = db.Query<Student>(query, commandType: CommandType.StoredProcedure);
                return result;
            }
        }
        #endregion
    }
}
