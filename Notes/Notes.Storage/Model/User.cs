using System.ComponentModel.DataAnnotations;

namespace Notes.Storage.Model
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
