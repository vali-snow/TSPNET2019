using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9InterfaceScenario.Classes
{
    public class Customer : IObjectWithState
    {
        public State State { get; set; }
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string CustomerTypeId { get; set; }
        public int CustomerTypeCustomerTypeId { get; set; }

        public virtual CustomerType CustomerType { get; set; }

        public virtual ICollection<CustomerEmail> CustomerEmails { get; set; }

        public Customer()
        {
            this.CustomerEmails = new HashSet<CustomerEmail>();
        }
    }
}
