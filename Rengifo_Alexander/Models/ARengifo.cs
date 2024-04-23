using System.ComponentModel.DataAnnotations;

namespace Rengifo_Alexander.Models
{
    public class ARengifo
    {
        //Constructor
        public ARengifo()
        {
            idEst = 0;
            Nombre = "";
            Edad = 0;
            Promedio_General = 0.0;
            Beca = false;
            FechaIncripcion = new DateOnly(2024, 02, 25);
        }
        //data estudiante

        [Key] [Required] public int idEst { get; set; }
        [Required] public string Nombre { get; set; }


        [Range(16, 100)] [Required] public int Edad { get; set; }

        [Range(6,10)]
        public Double Promedio_General { get; set; }
        public bool Beca { get; set; }
        //se cambio a DateOnly ya que DateTime da error en postres
        public DateOnly FechaIncripcion { get; set; }

        //interconexion entre clases
        public Carrera? carreraEst { get; set; }
    }
}
