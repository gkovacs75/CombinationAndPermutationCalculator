using System.ComponentModel.DataAnnotations;

namespace CombinationAndPermutationCalculator
{
    public class OddsViewModel
    {
        [Required]
        public int N { get; set; }

        [Required]
        public int R { get; set; }

        [Required]
        public bool IsOrderImportant { get; set; }

        [Required]
        public bool IsRepetitionAllowed { get; set; }

        public double Result { get; set; }
    }
}
