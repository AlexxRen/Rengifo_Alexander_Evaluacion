using System.ComponentModel.DataAnnotations;

namespace Rengifo_Alexander.Models
{
    public class Carrera
    {

        Carrera()
        {
            numero_semestres = 0;
            campus = "";
            nombre_carrera = "";
        }
        //data est

        [Key] public required int idCarrea { get; set; }
        public int? numero_semestres { get; set; }
        public string? campus { get; set; }
        public string? nombre_carrera { get; set; }
    }
}
