using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Models
{
    public class PointOfInterestForCreationDto
    { 
        [Required(ErrorMessage ="You should provide a name value.")]
        [MaxLength(50)]
        public string Name { get; set; }


        [MaxLength(200,ErrorMessage ="The field description must be a string or array type with a maximum length of '200'")]
        public string Description { get; set; }
    }
}
