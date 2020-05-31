﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Data
{
    public class Category
    {
        [Key]
        public string CategoryTitle { get; set; }
        [Required]
        public Guid OwnerId { get; set; }
        [Key]
        public int CategoryId { get; set; }

    }
}
