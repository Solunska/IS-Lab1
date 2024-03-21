using System.ComponentModel.DataAnnotations;

namespace Theatre.Web.Models.Domain
{
    public class Ticket
    {
        [Key]
        public Guid Id { get; set; }
        public int Price { get; set; }
    }
}
