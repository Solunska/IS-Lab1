using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using Theatre.Web.Models.Domain;

namespace Theatre.Web.Models.Identity
{
    public class User : IdentityUser
    {
        public User()
        {
            Id = Guid.NewGuid().ToString();
            UserTickets = new List<Ticket>();
        }
        [Key]
        public override string Id { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public virtual ICollection<Ticket> UserTickets { get; set; }
    }

}
