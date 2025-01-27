﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CovidWebAPI.Entities
{
    [Table("CovidDetails")]
    public class CovidDetails
    {
  
        
        public int Id { get; set; }
        [StringLength(50)]
        [Column(TypeName ="varchar")]
        [Key]
        public string CountryName { get; set; }

        public int? InfectedCases { get; set; }
        public int? RecoveredCases { get; set; }
        public int? DeceasedCases { get; set; }

    }
}
