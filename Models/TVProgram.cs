
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TVTracker.Models
{
    public class TVProgram
    {
        [Key]
        public int Id { get; set; }
        
        public string Title {get;set;}
        public int Season {get;set;}
        public int Episode {get;set;}
    }
}
            