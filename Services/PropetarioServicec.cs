using test.Repository;

namespace test.Services
{
    public class PropetarioService : IPropetarioService
    {
        private readonly IPropetarioRepository repository;

        public PropetarioService(IPropetarioRepository repository)
        {
            this.repository = repository;
        }

        public async Task<List<Propetario>> GetAll()
        {
            return await repository.GetAll();
        }

        public async Task<Propetario> GetPropetarioById(int Id)
        {
            return await repository.GetPropetarioById(Id);
        }
    }
}
