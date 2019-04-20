using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9InterfaceScenario.Classes
{
    public class CustomerType : IObjectWithState
    {
        public State State { get; set; }
        public int CustomerTypeId { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }

        public CustomerType()
        {
            this.Customers = new HashSet<Customer>();
        }
    }
}
