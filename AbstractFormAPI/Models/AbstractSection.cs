using System.Collections.Generic;

namespace AbstractFormAPI.Models
{
    public class AbstractSection
    {
        public AbstractSection()
        {
            DataItems = new List<AbstractDataItem>();
        }
        public long Id { get; set; }
        public string Label { get; set; }
        public bool IsVisible { get; set; }
        public List<AbstractDataItem> DataItems {get;set;}
    }
}