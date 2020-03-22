using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AerolineaV1.Models
{
    public class Reservacion
    {
        [Key] 
        public int ReservaID { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required(ErrorMessage = "Ingrese un Nombre valido")]
        [DisplayName("Nombre del Cliente")]
        public string NombreCliente { get; set; }
        [Column(TypeName = "varchar(20)")]
        [Required(ErrorMessage = "Ingrese un Pais valido")]
        [DisplayName("Pais de Destino")]
        public string PaisDestino { get; set; }
        [Column(TypeName = "varchar(10)")]
        [DisplayName("Categoria del Vuelo")]
        public string CategoriaVuelo { get; set; }
        [Column(TypeName = "char")]
        [DisplayName("Posicion del Asiento")]
        public char PosAsiento { get; set; }
    }
}

