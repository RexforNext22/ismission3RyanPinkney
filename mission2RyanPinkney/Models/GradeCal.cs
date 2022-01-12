using System;
using System.ComponentModel.DataAnnotations;


namespace mission2RyanPinkney.Models
{
    public class GradeCal
    {
        [Required]
        public int iAssignment { get; set; }

        [Required]
        public int iGroupProject { get; set; }

        [Required]
        public int iQuizzes { get; set; }

        [Required]
        public int iExams { get; set; }

        [Required]
        public int iINTEX { get; set; }

    }
}
