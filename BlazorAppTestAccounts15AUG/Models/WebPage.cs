namespace BlazorAppTestAccounts15AUG.Models
{
    public class WebPage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Create { get; set; }
        public WebSite? WebSite { get; set; }
    }
}
