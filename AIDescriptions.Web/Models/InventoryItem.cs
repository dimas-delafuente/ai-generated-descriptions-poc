using System.Linq;

namespace AIDescriptions.Web.Models;

public class InventoryItem
{
    public string SKU { get; set; }
    public Dictionary<string, string> CoreAttributes { get; set; }
    public Dictionary<string, string> AdditionalAttributes { get; set; }

    public Dictionary<string, string> AllAttributes 
        => CoreAttributes.Concat(AdditionalAttributes.Where(kvp => !CoreAttributes.ContainsKey(kvp.Key)))
        .ToDictionary(_ => _.Key, _ => _.Value);
}
