//from here
//https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/collections#indexable-collections


internal class Program
  {
  private static void Main( string[] args )
    {
    IterateThroughList();
    }

  private static void IterateThroughList()
    {
    var theGalaxies = new List<Galaxy>
    {
    new () { Name="Tadpole", MegaLightYears=400},
    new () { Name="Pinwheel", MegaLightYears=25},
    new () { Name="Milky Way", MegaLightYears=0},
    new () { Name="Andromeda", MegaLightYears=3}
    };

    foreach ( Galaxy theGalaxy in theGalaxies )
      {
      Console.WriteLine( theGalaxy.Name + " " + theGalaxy.MegaLightYears );
      }
    }
  }

public class Galaxy
  {
  public required string Name { get; set; }
  public int MegaLightYears { get; set; }
  }


    /* 
     * Output
     * Tadpole 400
     * Pinwheel 25
     * Milky Way 0
     * Andromeda 3
     */