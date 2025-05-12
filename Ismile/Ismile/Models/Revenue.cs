using System.ComponentModel.DataAnnotations;

namespace Ismile.Models
{
    public class Revenue
    {
        [Key]
        public long Id { get; set; }

        public double Amount { get; set; }
    }
}
