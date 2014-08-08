using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleSite.Models
{
    public class Person
    {
        public Person()
        {
            Skills = new HashSet<string>();
            BirthDate = DateTime.Now.AddYears(-20);
        }

        public int PersonId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        [UIHint("BooleanButtonLabel")]
        public bool LikesMusic { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        public ICollection<string> Skills { get; set; }
    }
}