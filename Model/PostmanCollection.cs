namespace PostmanCollectionGenerator.Model
{

    public class PostmanCollection
    {
        public Info info { get; set; }
        public List<Item> item { get; set; }
    }

    public class Info
    {
        public string name { get; set; }
        public string schema { get; set; }
    }

    public class Item
    {
        public string name { get; set; }
        public Request request { get; set; }
        public List<object> response { get; set; }
    }

    public class Request
    {
        public string method { get; set; }
        public Url url { get; set; }
        public List<Header> header { get; set; }
    }

    public class Url
    {
        public string raw { get; set; }
        public string[] host { get; set; }
        public string[] path { get; set; }
    }

    public class Header
    {
        public string key { get; set; }
        public string value { get; set; }
    }

}
