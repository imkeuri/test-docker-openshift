namespace test.Services
{
    public interface IPropetarioService
    {
        Task<List<Propetario>> GetAll();
        Task<Propetario> GetPropetarioById(int id);
    }
}
