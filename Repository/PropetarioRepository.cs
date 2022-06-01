using System.Data.Entity;
using test.Data;

namespace test.Repository
{
    public class PropetarioRepository : IPropetarioRepository
    {
        private readonly DbContextPropiedad dbContext;

        public PropetarioRepository(DbContextPropiedad dbContext)
        {
            this.dbContext = dbContext;
        }

        public  List<Propetario> GetAll() =>  dbContext.Set<Propetario>().ToList();
    }
}
