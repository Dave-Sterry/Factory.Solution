using System.Collections.Generic;
using System;
using System.ComponentModel;

namespace Factory.Models
{
    public class Machine
    {
      public Machine()
      {
        this.JoinEntries = new HashSet<MachineEngineer>();
      }

      public int MachineId { get; set; }
      public string MachineName{ get; set; }
      public virtual ICollection<MachineEngineer> JoinEntries { get; set; }
    }
}