using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Person
    {
        [Key]
        public int PersonID { get; set; }

        [MaxLength(200)]
        public string FullName { get; set; }

        [MaxLength(200)]
        public string Email { get; set; }

        public string WebSite { get; set; }

        [Required]
        public string Age { get; set; }


    }
}
