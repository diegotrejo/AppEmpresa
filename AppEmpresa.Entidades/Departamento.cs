using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppEmpresa.Entidades
{
    public class Departamento
    {
        [Key]
        public int Id { get; set; }   // PK 

        [DisplayName("Nombre del departamento")]
        public string Nombre { get; set;}

        public string Ciudad { get; set;}

        public List<Empleado>? Empleados { get; set;}
    }
}
