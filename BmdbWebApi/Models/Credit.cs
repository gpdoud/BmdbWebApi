using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BmdbWebApi.Models {
    public class Credit {

        public int Id { get; set; }
        [StringLength(255), Required]
        public string Role { get; set; }

        public int ActorId { get; set; }
        public virtual Actor Actor { get; set; }

        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }

    }
}
