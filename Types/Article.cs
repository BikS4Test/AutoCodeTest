
namespace ProjectName.Types
{
    public class Article
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Author AuthorId { get; set; }
        public string Summary { get; set; }
        public string Body { get; set; }
        public string GoogleDriveID { get; set; }
        public bool HideScrollSpy { get; set; }
        public Guid ImageId { get; set; }
        public Guid PDF { get; set; }
        public DateTime Created { get; set; }
        public DateTime Changed { get; set; }
        public string Langcode { get; set; }
        public bool Status { get; set; }
        public bool Sticky { get; set; }
        public bool Promote { get; set; }
        public string UserRoles { get; set; }
        public Guid CreatorId { get; set; }
        public Guid ChangedUser { get; set; }
        public List<BlogCategory> BlogCategories { get; set; }
        public List<Tag> Tags { get; set; }
    }
}