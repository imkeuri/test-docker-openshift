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

        public   List<Propetario> GetAll()
        {
            return  repository.GetAll();
        }
    }
}
