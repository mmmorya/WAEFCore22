using System.ComponentModel.DataAnnotations;

namespace WAEFCore22.Models.DbClassess
{
    public class Student_Db
    {
        [Key]
        public int _ID { get; set; }
        public string _FName { get; set; }
        public string _LName { get; set; }
        public string _Email { get; set; }
        public string _Mobile { get; set; }
        public string _Description { get; set; }
        public int _DeptID { get; set; }
    }
}
