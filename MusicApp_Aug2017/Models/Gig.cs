using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicApp_Aug2017.Models
{
    public class Gig
    {
        //Properties we need for our Gig class.
        public int ID { get; set; }

        [Required]
        public ApplicationUser Artist { get; set; }

        public DateTime DateTime { get; set; }

        [Required]
        [StringLength(255)]
        public string Venue { get; set; }

        [Required]
        public Genre Genre { get; set; }

    }

   
}