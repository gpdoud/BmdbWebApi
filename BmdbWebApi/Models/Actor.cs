using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BmdbWebApi.Models {
    public class Actor {
        
        public int Id { get; set; }
        [StringLength(30), Required]
        public string Firstname { get; set; }
        [StringLength(30), Required]
        public string Lastname { get; set; }
        [StringLength(1), Required]
        public string Gender { get; set; }
        public DateTime Birthdate { get; set; }

        public virtual string Fullname { get { return $"{Firstname} {Lastname}"; } }

    }
}
