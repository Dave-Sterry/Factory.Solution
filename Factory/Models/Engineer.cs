using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
    public class Engineer
    {
      public Engineer()
      {
        this.JoinEntries = new HashSet<MachineEngineer>();
      }

      [DisplayName("Hire Date")]
      [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd hh:mm tt}")]
      public DateTime HireDate { get; set; }
      public int EngineerId { get; set; }

      [DisplayName("Engineer Name")]
      public string EngineerName { get; set; }

      public ICollection<MachineEngineer> JoinEntries { get; }
    }
}