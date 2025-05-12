using System.ComponentModel.DataAnnotations;

namespace Ismile.Models
{
    public class Disponibilite
    {
        [Key]
        public long Id { get; set; }

        public TimeSpan HeureDebut { get; set; }

        public TimeSpan HeureFin { get; set; }

        public bool EstDisponible { get; set; }
    }


}
