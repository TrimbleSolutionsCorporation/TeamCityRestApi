using System.Collections.Generic;

namespace TeamcityRestTypes
{
    public class TcAgent
    {
        public TcAgent()
        {
            this.Properties = new Dictionary<string, string>();
        }

        public string Ip { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Href { get; set; }

        public Dictionary<string, string> Properties { get; set; }
    }
}
