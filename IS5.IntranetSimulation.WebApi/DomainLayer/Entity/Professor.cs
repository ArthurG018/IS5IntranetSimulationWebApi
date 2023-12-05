using System.ComponentModel;

namespace IS5.IntranetSimulation.WebApi.DomainLayer.Entity
{
    public class Professor
    {
        [Description("professor_id")]
        public int Id { get; set; }
        [Description("professor_full_name")]
        public String FullName { get; set; }
        [Description("professor_dni")]
        public String Dni { get; set; }
    }
}
