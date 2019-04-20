using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9InterfaceScenario.Classes
{
    public class CustomerEmail : IObjectWithState
    {
        public State State { get; set; }
        public int CustomerEmailId { get; set; }
        public string Email { get; set; }
        public string CustomerId { get; set; }
        public int CustomerCustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
