using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP03PDMI.Models
{
    [Table("Events")]
    public class Event
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [DisplayName("Descrição")]
        public string Description { get; set; }

        [Required]
        [DisplayName("Status")]
        public DeliveryStatus EventStatus { get; set; }
        public DateTime Date { get; set; }

        [Required]
        [DisplayName("Localização")]
        public string Locate { get; set; }

        public string EventStatusDisplay => Package.GetStatusName(EventStatus);
    }
}