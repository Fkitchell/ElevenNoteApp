using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models.Category
{
    class CategoryCreate
    {

        [Required]
        public Guid OwnerId { get; set; }
        [Required]
        public string CategoryTitle { get; set; }
    }
}
