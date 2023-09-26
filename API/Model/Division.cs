using System.ComponentModel.DataAnnotations;

namespace mba.basquet {
    public partial class Division {
        [Key]
        public string Name { get; set; }
    }
}