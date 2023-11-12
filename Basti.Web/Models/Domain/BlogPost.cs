namespace Basti.Web.Models.Domain
{
    public class BlogPost
    {
        public Guid Id { get; set; }
        public String Heading { get; set; }    
        public String PageTitle { get; set; }    
        public String Content { get; set; }    
        public String ShortDescription { get; set; }    
        public String FeaturedImageURL { get; set; }    
        public String UrlHandle{ get; set; }    
        public DateTime PublishedDate { get; set; }    
        public String Author { get; set; }    
        public bool Visible { get; set; }
        public ICollection<Tag> Tags { get; set; }

    }
}
