using SQLite;

namespace GeradorChave.Models
{
    public class GeradorModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public DateTime FirstData { get; set; }
        public DateTime SecondData { get; set; }
        public string Numero { get; set; }
        public string Cnpj { get; set; }
    }
}
