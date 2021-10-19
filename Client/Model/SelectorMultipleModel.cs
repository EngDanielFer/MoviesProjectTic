namespace MoviesProject.Client.Model
{
    public class SelectorMultipleModel
    {
        public SelectorMultipleModel(string key, string value)
        {
            Key = key;
            Value = value;
        }
        public string Key{get;set;}
        public string Value{get;set;}
    }
}