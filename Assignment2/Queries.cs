using System.Linq;
namespace Assignment2;

public static class Queries
{
    public static IEnumerable<string> FindMsRowling() {
        WizardCollection wzCollection = WizardCollection.Create();
        
        return
            from wz in wzCollection
            where wz.Creator.Contains("Rowling", StringComparison.InvariantCultureIgnoreCase)
            select wz.Name;
    }
}
