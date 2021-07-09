using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BmdbWebApi.Models {
    public class Movie {

        public int Id { get; set; }
        [StringLength(255), Required]
        public string Title { get; set; }
        public int Year { get; set; }
        [StringLength(5), Required]
        public string Rating { get; set; }
        [StringLength(255), Required]
        public string Director { get; set; }

    }
}
