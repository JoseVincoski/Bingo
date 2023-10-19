using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    public class Card
    {
        [Key]
        public Guid Id { get; set; }

        public int Number { get; set; }
    }
}
