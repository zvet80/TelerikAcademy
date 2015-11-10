namespace ConsumingWebServicesUsingCSharp
{
    public class Comment
    {
        public int Id { get; set; }

        public int PostId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Body { get; set; }

        public override string ToString()
        {
            return string.Format("ID: {0}\nTitle: {1}\nBody: {2}\n", this.Id, this.Name, this.Body);
        }
    }
}
