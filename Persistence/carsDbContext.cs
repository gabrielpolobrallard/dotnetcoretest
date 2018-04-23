using Microsoft.EntityFrameworkCore;

namespace testingdotnet.Persistence
{
    public class carsDbContext:DbContext
    {
        
        public carsDbContext(string conectionString):base(conectionString)
        {
            
        }
    }
}