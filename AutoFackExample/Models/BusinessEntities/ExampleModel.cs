using System.ComponentModel.DataAnnotations.Schema;

namespace AutoFackExample.Models.BusinessEntities
{
    [Table("ExampleTable", Schema = "dbo")]
    public class ExampleModel
    {
        [Column("id")]
        public int id { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("Age")]
        public int Age { get; set; }
    }
}