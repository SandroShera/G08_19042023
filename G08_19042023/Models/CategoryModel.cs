namespace G08_19042023.Models
{
    public class CategoryModel
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public byte[] Picture { get; set; }

        public override string ToString()
        {
            return $"Name: {CategoryName}, Description: {Description}";
        }
    }
}
