using System.ComponentModel.DataAnnotations;

namespace mba.basquet {
    public partial class Team {
        [Key]
        [MaxLength(20)]
        public string Name { get; set; }

        public ICollection<Competes>? Divisions { get; set; }
    }
}