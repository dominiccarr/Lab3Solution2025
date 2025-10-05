using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RADLab3Solution.Models
{
    public class Book
    {

        public int Id { get; set; }
        [MinLength(4)]
        public string Title { get; set; }
        public string? Summary { get; set; }
        public int? AuthorID { get; set; }
        public int? PublisherID { get; set; }
        [DisplayName("Publication Date")]
        public DateOnly PublicationDate { get; set; }
        [Display(Name = "Cover")]
        public string? CoverPage { get; set; }


        public Author? Author { get; set; }

        public Publisher? Publisher { get; set; }


    }
}
