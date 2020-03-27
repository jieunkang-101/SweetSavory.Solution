using System.Collections.Generic;

namespace SweetSavory.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.Treats = new HashSet<TreatFlavor>();
    }

    public int FlavorId { get; set; }
    public string FlavorName { get; set; }
    public ApplicationUser User { get; set; }

    public ICollection<TreatFlavor> Treats { get; set; }
  }  
}  