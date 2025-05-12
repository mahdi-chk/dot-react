using System.ComponentModel.DataAnnotations;

namespace Ismile.Models
{


    public class Role
    {
        [Key]
        public long Id { get; set; }

        public List<string> Privileges { get; set; }
    }

}