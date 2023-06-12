CityBuilder cb = new CityBuilder();


public class City
{
    public object Roads { get; set; }
    public object Firms { get; set; }
    public object Factories { get; set; }
    public object Parks { get; set; }
    public object Schools { get; set; }
    public object Universities { get; set; }
    public object Restaurants { get; set; }
    public object Clubs { get; set; }
    public object Airports { get; set; }
}

public interface ICityBuilder
{
    void Reset();
    void BuildRoads();
    void BuildFirms();
    void BuildFactories();
    void BuildParks();
    void BuildSchools();
    void BuildUniversities();
    void BuildRestaurans();
    void BuildClubs();
    void BuildAirports();
}

public class CityBuilder : ICityBuilder
{
    private City _city;

    public void Reset()
    {
        _city = new City();
    }

    public City GetResult()
    {
        City city = _city;
        Reset();
        return city;
    }

    public void BuildAirports()
    {
        Console.WriteLine("Built Airports.");
    }

    public void BuildClubs()
    {
        Console.WriteLine("Built Clubs.");
    }

    public void BuildFactories()
    {
        Console.WriteLine("Built Factories.");
    }

    public void BuildFirms()
    {
        Console.WriteLine("Built Firms.");
    }

    public void BuildParks()
    {
        Console.WriteLine("Built Parks.");
    }

    public void BuildRestaurans()
    {
        Console.WriteLine("Built Restaurants.");
    }

    public void BuildRoads()
    {
        Console.WriteLine("Built Roads.");
    }

    public void BuildSchools()
    {
        Console.WriteLine("Built Schools.");
    }

    public void BuildUniversities()
    {
        Console.WriteLine("Built Universities.");
    }
}

public class EducationTownDirector
{
    public City MakeEducationTown(CityBuilder cityBuilder)
    {
        cityBuilder.BuildRoads();
        cityBuilder.BuildSchools();
        cityBuilder.BuildUniversities();
        cityBuilder.BuildParks();

        return cityBuilder.GetResult();
    }
}