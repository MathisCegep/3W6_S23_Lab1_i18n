using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ZombieParty.Models
{
    public class Zombie
    {
        public int Id { get; set; }
        [Display(Name = "Name")]
        [StringLength(20, MinimumLength = 5)]
        public string Name { get; set; }

        [StringLength(255)]
        [Display(Name = "ShortDesc")]
        public string ShortDesc { get; set; }
        [Display(Name = "Point")]
        [Range(1, 20, ErrorMessage = "RangeValidation")]
        public int Point { get; set; }
        [Display(Name = "Force")]
        public int Force { get; set; }
        [Display(Name = "Image")]
        [ValidateNever]
        public string Image { get; set; }

        // FACULTATIF on peut formellement identifier le champ lien
        // sinon le champ de foreignKey sera auto généré dans la BD
        [Display(Name = "Type")]
        [ForeignKey("Type")]
        public int ZombieTypeId { get; set; }
        [ValidateNever] 
        public virtual ZombieType? ZombieType { get; set; }

        [ValidateNever] 
        public virtual List<HuntingLog> HuntingLogs { get; set; }
    }
}
