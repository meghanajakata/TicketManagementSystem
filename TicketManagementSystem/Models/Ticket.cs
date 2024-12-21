using Microsoft.AspNetCore.Razor.Language.Intermediate;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketManagementSystem.Models
{
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int StatusId { get; set; }
        public DateTime CreatedDate { get; set; }

        [ForeignKey("Agent")]
        public int AgentId { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public virtual User Agent { get; set; }
        public virtual User Customer { get; set; }
    }
}
