using Microsoft.EntityFrameworkCore;
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

        public async  Task<List<Propetario>> GetAll()
        {
            var SpProcedure = "exec selectAllPropetarios;";
            var result = await dbContext.Propetario.FromSqlRaw(SpProcedure).ToListAsync();
           
            if (result == null) throw new NullReferenceException();
            
            return result;
        } 

        public async Task<Propetario> GetPropetarioById(int Id)
        {
            var SpProcedure = "exec SPselectPropetarioById {0}" ;
            var result = await dbContext.Set<Propetario>().FromSqlRaw(SpProcedure, Id).ToListAsync();

            if (result == null)
            {
                throw new NullReferenceException();
            }

            return result.First();
        }

 
    }
}
