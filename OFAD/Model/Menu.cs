using System.ComponentModel.DataAnnotations;

namespace OFAD.Model
{
    public class Menu
    {
        public class menu
        {
            [key]
            public int Id { get; set; }

            [Required]
            public string Name { get; set; }
            public string Foods { get; set; }
        }
    }
}
