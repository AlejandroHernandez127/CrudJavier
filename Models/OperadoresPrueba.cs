using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OperadoresAplicacion.Models
{
    public class OperadoresPrueba
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Nullable<int> Edad { get; set; }
        public Nullable<int> Salario { get; set; }
        public Nullable<System.DateTime> Fecha_Nacimiento { get; set; }
        public Nullable<int> IdEmpresa { get; set; }
        public virtual Empresa Empresa { get; set; }
    }
}