namespace Basti.Web.Models.Domain
{
    public class Tag
    {
        public Guid Id { get; set; } 
        public String Name { get; set; } 
        public String DisplayName { get; set; }

        public ICollection<BlogPost> Tags { get; set; }

    }
}
