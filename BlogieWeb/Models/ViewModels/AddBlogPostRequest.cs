using Microsoft.AspNetCore.Mvc.Rendering;

namespace BlogieWeb.Models.ViewModels
{
    public class AddBlogPostRequest
    {
        public string Heading { get; set; }

        public string PageTitle { get; set; }

        public string Content { get; set; }

        public string ShortDescription { get; set; }

        public string FeatureImageUrl { get; set; }

        public string UrlHandle { get; set; }

        public DateTime PublishDate { get; set; }

        public string Author { get; set; }

        public bool Visible { get; set; }

        //Display Tags
        public IEnumerable<SelectListItem> Tags { get; set; }
        //Collect Tags - Selecting Multiple Tags here
        public string[] SelectedTags { get; set; } = Array.Empty<string>();
    }
}
