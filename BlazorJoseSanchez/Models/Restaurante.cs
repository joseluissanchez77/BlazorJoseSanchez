using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorJoseSanchez.Models
{
    public class Restaurante
    {
        [JsonProperty("idRestaurante")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDRestaurante { get; set; }

        [JsonProperty("nombreRestaurante")]
        public String NombreRestaurante { get; set; }

        [JsonProperty("idCiudad")]
        public int IDCiudad { get; set; }

        [JsonProperty("numeroAforo")] 
        public int NumeroAforo { get; set; }

        [JsonProperty("telefono")] 
        public String Telefono { get; set; }

        [JsonProperty("fechaCreacion")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaCreacion { get; set; }

        [JsonProperty("nombreCiudad")]
        public String NombreCiudad { get; set; }
    }
}
