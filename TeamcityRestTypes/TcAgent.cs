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

        public int TypeId { get; set; }

        public string Name { get; set; }

        public string Href { get; set; }

        public string WebUrl { get; set; }

        public bool Enabled { get; set; }

        public bool Connected { get; set; }

        public bool Authorized { get; set; }

        public StatusInfo EnabledInfo { get; set; }

        public StatusInfo AuthorizedInfo { get; set; }

        public TcAgentPool AgentPool { get; set; }

        public Dictionary<string, string> Properties { get; set; }
    }
}
