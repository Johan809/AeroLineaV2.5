using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AerolineaV1.Models
{
    public class Cliente
    {
        [Key] 
        public int ClienteID { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required(ErrorMessage = "Ingrese un Pasaporte valido")]
        public string Pasaporte { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required(ErrorMessage = "Ingrese una Cedula valida")]
        public string Cedula { get; set; }
        [Column(TypeName = "varchar(40)")]
        [DisplayName("Nombre Completo")]
        public string NombreCompleto { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string Nacionalidad { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string Direccion { get; set; }

    }
}
