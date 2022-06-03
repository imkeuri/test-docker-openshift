namespace test.Repository
{
    public interface IPropetarioRepository
    {
        Task<List<Propetario>> GetAll();
        Task<Propetario> GetPropetarioById(int id);
    }
}
