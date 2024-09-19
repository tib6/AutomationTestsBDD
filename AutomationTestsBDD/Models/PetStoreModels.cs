namespace AutomationTestsBDD.Models
{
    public class PetStoreBody
    {
        public int id { get; set; }
        public Category category { get; set; }
        public string name { get; set; }
        public List<string> photoUrls { get; set; }
        public List<Tag> tags { get; set; }
        public string status { get; set; }
    }
    public class Category
    {
        public int id { get; set; }
        public string name { get; set; }
    }
    public class Tag
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class DeletePetResponse
    {
        public int code { get; set; }
        public string type { get; set; }
        public string message { get; set; }
    }

    public class GetDeletedPetResponse
    {
        public int code { get; set; }
        public string type { get; set; }
        public string message { get; set; }
    }

}
