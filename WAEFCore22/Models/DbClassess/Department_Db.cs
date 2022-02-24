using System.ComponentModel.DataAnnotations;
namespace WAEFCore22.Models.DbClassess
{
    public class Department_Db
    {
        [Key]
        public int _ID { get; set; }
        public string _Name { get; set; }
    }
}
