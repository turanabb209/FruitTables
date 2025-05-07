using System.ComponentModel.DataAnnotations;

namespace Fruittables.ViewModels.Slides
{
    public class CreateSlideVM
    {
        [MaxLength(200, ErrorMessage = "Slide title must be less than 200 characters")]
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Description { get; set; }
        public IFormFile Photo { get; set; }

        public int Order { get; set; }
    }
}
