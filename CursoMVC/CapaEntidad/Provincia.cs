using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Provincia
    {
//        IdProvincia varchar(4) not null,
//Descripcion varchar(45) not null,
//IdDepartamento varchar(2) not null
        public int IdProvincia { get; set; }
        public string Descripcion { get; set; }
        public int IdDepartamento { get; set; }
    }
}
