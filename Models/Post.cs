using System.ComponentModel.DataAnnotations;

namespace whatnowblog.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get;set; }

        [Required]
        public string SubHeading { get; set; }

        [Required]
        public string PreviewBlurb { get; set; }

        [Required]
        public string BlogBody { get; set; }    


    }
}
