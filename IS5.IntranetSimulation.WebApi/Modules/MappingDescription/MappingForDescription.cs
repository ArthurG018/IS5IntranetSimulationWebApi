using Dapper;
using IS5.IntranetSimulation.WebApi.DomainLayer.Entity;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Reflection;

namespace IS5.IntranetSimulation.WebApi.Modules.HelperMapping
{
    public class MappingForDescription
    {
        public static String GetDescriptionFromAttribute(MemberInfo member)
        {
            if (member == null) return null;

            var attrib = Attribute.GetCustomAttribute(member, typeof(DescriptionAttribute), false) as DescriptionAttribute;
            return (attrib?.Description ?? member.Name).ToLower();
        }
        public static void MapStudent()
        {
            var map = new CustomPropertyTypeMap(typeof(Student), (type, columnName) => type.GetProperties().FirstOrDefault(prop => GetDescriptionFromAttribute(prop) == columnName.ToLower()));
            Dapper.SqlMapper.SetTypeMap(typeof(Student), map);
        }
        public static void MapProfessor()
        {
            var map = new CustomPropertyTypeMap(typeof(Professor), (type, columnName) => type.GetProperties().FirstOrDefault(prop => GetDescriptionFromAttribute(prop) == columnName.ToLower()));
            Dapper.SqlMapper.SetTypeMap(typeof(Professor), map);
        }
    }
}
