using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gorev_Yoneticisi.Models.Entities
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }

        [Column(TypeName ="nvarchar(100)")]
        public string Title { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string Description { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string Color { get; set; }
    }
}
