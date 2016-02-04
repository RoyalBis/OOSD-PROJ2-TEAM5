using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    /// <summary>
    /// Agent Entity Class
    /// </summary>
   public class Agent
    {
        public string AgentId { get; set; }
        public string AgentFirstName { get; set; }
        public string AgentMiddleInitial { get; set; }
        public string AgentLastName { get; set; }
        public string AgentEmail { get; set; }
        public string AgentPosition { get; set; }
        public string AgencyId { get; set; }
        public string AgentPassword { get; set; }
    }
}
