using System.ComponentModel.DataAnnotations;

namespace Fruittables.ViewModels.Slides
{
    public class UpdateSlideVM
    {
        [MaxLength(200, ErrorMessage = "Slide title must be less than 200 characters")]
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Description { get; set; }
        public string? Image { get; set; }

        public int Order { get; set; }
        public IFormFile? Photo { get; set; }
    }
}
