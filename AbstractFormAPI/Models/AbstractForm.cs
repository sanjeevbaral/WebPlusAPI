using System.Collections.Generic;

namespace AbstractFormAPI.Models
{
    public class AbstractForm
    {
        public AbstractForm()
        {
            Sections = new List<AbstractSection>();
        }
        public long Id { get; set; }
        public string Name { get; set; }
        public List<AbstractSection> Sections {get;set;}

    }
}