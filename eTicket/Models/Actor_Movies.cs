using System.ComponentModel.DataAnnotations;

namespace eTicket.Models
{
    public class Actor_Movies
    {
        [Key]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public int ActorId { get; set; }
        public Actor Actor { get; set; }
    }
}
