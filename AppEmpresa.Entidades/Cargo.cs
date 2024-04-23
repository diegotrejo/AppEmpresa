using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEmpresa.Entidades
{
    public class Cargo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public List<Empleado>? EmpleadoList { get; set;}
    }
}
