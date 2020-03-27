using System.Collections.Generic;

namespace SweetSavory.Models
{
  public class Treat
  {
    public Treat()
    {
      this.Flavors = new HashSet<TreatFlavor>();
    }

    public int TreatId { get; set; }
    public string TreatName { get; set; }
    public ApplicationUser User { get; set; }

    public ICollection<TreatFlavor> Flavors { get; set; }
  }  
}