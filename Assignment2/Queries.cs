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

    public static IEnumerable<string> FindMsRowlingWithExtensions() {
        WizardCollection wzCollection = WizardCollection.Create();

        return 
            wzCollection
            .Where(wz => wz.Creator.Contains("Rowling", StringComparison.InvariantCultureIgnoreCase))
            .Select(wz => wz.Name);
    }

    public static int? FindMrDarthSith() {
        WizardCollection wzCollection = WizardCollection.Create();
        
        return
            (from wz in wzCollection
            where wz.Name.Contains("Darth", StringComparison.InvariantCultureIgnoreCase)
            select wz.Year).FirstOrDefault();
    }

    public static int? FindMrDarthSithWithExtensions() {
        WizardCollection wzCollection = WizardCollection.Create();
        
        return
            wzCollection
            .Where(wz => wz.Name.Contains("Darth", StringComparison.InvariantCultureIgnoreCase))
            .Select(wz => wz.Year)
            .FirstOrDefault();
    }

    public static IEnumerable<(string, int?)> FindAllHarryPotterWizards() {
        WizardCollection wzCollection = WizardCollection.Create();
        
        return
            from wz in wzCollection
            where wz.Medium.Contains("Harry Potter", StringComparison.InvariantCultureIgnoreCase)
            select (wz.Name, wz.Year);
    }

    public static IEnumerable<(string, int?)> FindAllHarryPotterWizardsWithExtensions() {
        WizardCollection wzCollection = WizardCollection.Create();
        
        return
            wzCollection
            .Where(wz => wz.Medium.Contains("Harry Potter", StringComparison.InvariantCultureIgnoreCase))
            .Select(wz => (wz.Name, wz.Year));
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

    public static IEnumerable<string> FindWizardsGroupedAndSortedWithExtensions() {
        WizardCollection wzCollection = WizardCollection.Create();
        
        var groups = 
            wzCollection
            .OrderByDescending(wz => wz.Name)
            .GroupBy(wz => wz.Creator)
            .OrderByDescending(group => group.Key)
            .SelectMany(group => group.Select(wz => wz));

        foreach(var wz in groups){
            yield return wz.Name;
        }
    }
}
