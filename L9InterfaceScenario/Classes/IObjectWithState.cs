using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9InterfaceScenario.Classes
{
    public interface IObjectWithState
    {
        State State { get; set; }
    }
}