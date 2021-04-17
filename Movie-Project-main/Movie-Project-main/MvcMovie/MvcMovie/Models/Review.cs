using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Review
    {
        [Key]
        public int Id1 { get; set; }
        public string Name { get; set; }

        public string Message { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReviewDate { get; set; }
    }
}
