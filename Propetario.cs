using System.ComponentModel.DataAnnotations;

namespace test
{
    public class Propetario
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
