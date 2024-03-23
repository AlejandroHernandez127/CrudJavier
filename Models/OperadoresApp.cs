using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OperadoresAplicacion.Models
{
    public class OperadoresApp
    {
        public int Id { get; set; }
        public string Nombre{ get; set; }
        public int Edad { get; set; }
        public int Salario { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public int IdEmpresa { get; set; }
        public Empresa Empresa { get; set; }
    }
}