using System.ComponentModel.DataAnnotations;

namespace whatnowblog.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get;set; }

        public string SubHeading { get; set; }

        public string PreviewBlurb { get; set; }

        public string BlogBody { get; set; }    


    }
}
