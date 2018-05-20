namespace AbstractFormAPI.Models
{
    public class AbstractDataItem
    {
        public long Id { get; set; }
        public string Label { get; set; }
        public bool IsProtected { get; set; }
        public bool IsVisible { get; set; }
        public string DefaultValue { get; set; }
    }
}