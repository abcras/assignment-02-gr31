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

    public static int? FindMrDarthSith() {
        WizardCollection wzCollection = WizardCollection.Create();
        
        return
            (from wz in wzCollection
            where wz.Name.Contains("Darth", StringComparison.InvariantCultureIgnoreCase)
            select wz.Year).FirstOrDefault();
    }

    public static IEnumerable<(string, int?)> FindAllHarryPotterWizards() {
        WizardCollection wzCollection = WizardCollection.Create();
        
        return
            from wz in wzCollection
            where wz.Medium.Contains("Harry Potter", StringComparison.InvariantCultureIgnoreCase)
            select (wz.Name, wz.Year);
    }

    public static IEnumerable<string> FindWizardsGroupedAndSorted() {
        WizardCollection wzCollection = WizardCollection.Create();
        
        var groups = from wz in wzCollection
                        orderby wz.Name descending
                        group wz by wz.Creator into g
                        orderby g.Key descending
                        select g;

        foreach(var group in groups){
            foreach(var wz in group){
                yield return wz.Name;
            }
        }
    }
}
