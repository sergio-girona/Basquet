using System.ComponentModel.DataAnnotations;

namespace mba.basquet {
    public partial class Competes {
        public int YearCompetition { get; set; }
        [MaxLength(20)]
        public string NameTeam { get; set; }
        [MaxLength(20)]
        public string NameDivision { get; set; }

        public Division? DivisionObj { get; set; }
        public Team? TeamObj { get; set; }
    }
}