using System.ComponentModel.DataAnnotations;

namespace GenericApi.Entity
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
