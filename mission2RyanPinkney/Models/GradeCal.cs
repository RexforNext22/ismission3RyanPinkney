using System;
using System.ComponentModel.DataAnnotations;


namespace mission2RyanPinkney.Models
{
    public class GradeCal
    {

        [Required]
        [Range(0, 100)]
        public int iAssignment { get; set; }

        [Required]
        [Range(0, 100)]
        public int iGroupProject { get; set; }

        [Required]
        [Range(0, 100)]
        public int iQuizzes { get; set; }

        [Required]
        [Range(0, 100)]
        public int iExams { get; set; }

        [Required]
        [Range(0, 100)]
        public int iINTEX { get; set; }

        //GradeCal oGradeCal = new GradeCal();

        //double fPercent = (iAssignment * .55) + (iGroupProject * .05) + (iQuizzes * .10)
        //    + (iExams * .20) + (iINTEX * .10);


    }
}
