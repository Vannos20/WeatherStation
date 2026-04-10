using Database;
using Repository;
namespace WeatherStation;

public class Program
{
    public static void Main(string[] args)
    {
        using (var myContext = new WeatherStationContext())
        {
            myContext.Database.EnsureCreated();
            IUserRepository iusrep = new UserRepository(myContext);
            iusrep.GetUser(1);
            var iuse = iusrep.GetUser(2);
            Console.WriteLine(iuse);  
        }

        
            
    }
    

}


