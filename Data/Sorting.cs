namespace PetitionAdminApp.Data;

public class Sorting : IComparer<string?>
{
    public int Compare(string? x, string? y)
    { 
        if (x == null || y == null)
        { 
            return 0; 
        }
          
        // "CompareTo()" method
        return String.Compare(x, y, StringComparison.Ordinal);
    }
}