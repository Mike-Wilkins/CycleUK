using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleUK.Models
{
    public class Events
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage ="Title name is required")]
        [StringLength(EventsConstants.MAX_TITLE_NAME_LENGTH)]
        public string Title { get; set; }

        [Required(ErrorMessage="Postcode is required")]
        [StringLength(EventsConstants.MAX_POSTCODE_LENGTH, MinimumLength = EventsConstants.MIN_POSTCODE_LENGTH)]
        public string Postcode { get; set; }

        [Required(ErrorMessage="Comment is required")]
        [StringLength(EventsConstants.MAX_COMMENT_LENGTH)]
        public string Comment { get; set; }

        [Required(ErrorMessage="Date is required")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }



    }
}
