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

    // We could not complete this, as the assignment wishes to Group By creator, and return a list of names. We cant return outside the group 
    public static IEnumerable<string> FindWizardsGroupedAndSorted() {
        WizardCollection wzCollection = WizardCollection.Create();
        
        return 
            from wz in wzCollection
                 orderby wz.Creator
                 orderby wz.Name
                 group wz by wz.Creator into g
                 select g.Key;
    }
}
