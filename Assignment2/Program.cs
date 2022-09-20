using System.Linq;

foreach (var wizard in WizardCollection.Create())
{
    Console.WriteLine(wizard);
}

IEnumerable<int>[] xs = new IEnumerable<int>[5];

int[] ys = new int[5];

var flattened = xs.SelectMany(x => x.Select(y => y));


ys.Where(x => x % 7 == 0 && x > 42);

ys.Where(x => LeapYear(x));



static bool LeapYear(int year)
{
    //Repeat LeapYear method from before
    if(year %4 == 0)
    {
        if(year % 100 != 0)
        {
            if(year % 400 == 0)
            {
                return true;
            }
        }
    }

    return false;
}