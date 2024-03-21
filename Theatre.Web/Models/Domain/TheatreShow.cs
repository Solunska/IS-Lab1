using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;

namespace Theatre.Web.Models.Domain
{
    public class TheatreShow
    {
        public TheatreShow()
        {
            Id = Guid.NewGuid();
            Title = "";
            Description = "";
            Place = "";
            ImageUrl = "";
            TheatreShowTickets = new List<Ticket>();
        }
        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Place { get; set; }
        public DateTime ShowDate { get; set; }
        public string ImageUrl { get; set; }
        public virtual ICollection<Ticket> TheatreShowTickets { get; set; }
    }
}