using System.Collections.Generic;

namespace Factory.Models
{
    public class Engineer
    {
      public Engineer()
      {
        this.JoinEntries = new HashSet<MachineEngineer>();
      }

      public int EngineerId { get; set; }
      public string EngineerName { get; set; }

      public ICollection<MachineEngineer> JoinEntries { get; }
    }
}