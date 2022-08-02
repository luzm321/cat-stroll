using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CatStroll.Models
{
    public class Cat
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please give your cat a name to be called :)")]
        [MaxLength(35)]
        public string Name { get; set; }

        [Required]
        public string Breed { get; set; }

        [Required(ErrorMessage = "Please give notes about your cat! :D")]
        public string Notes { get; set; }

        [Required(ErrorMessage = "Provide a selfie of your cute cat for us to identify!")]
        [DisplayName("Image URL")]
        public string ImageUrl { get; set; }
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
    }
}
