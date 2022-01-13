// Author: Ryan Pinkney
// This is the models for the asp.net app

using System;
using System.ComponentModel.DataAnnotations;


namespace mission2RyanPinkney.Models
{
    public class GradeCal
    {
        // Assignment variable for getter and setter and data validation
        [Required]
        [Range(0, 100)]
        public int iAssignment { get; set; }

        // Group Project variable for getter and setter and data validation
        [Required]
        [Range(0, 100)]
        public int iGroupProject { get; set; }

        // Quizzes variable for getter and setter and data validation
        [Required]
        [Range(0, 100)]
        public int iQuizzes { get; set; }

        // Exams variable for getter and setter and data validation
        [Required]
        [Range(0, 100)]
        public int iExams { get; set; }

        // Intex variable for getter and setter and data validation
        [Required]
        [Range(0, 100)]
        public int iINTEX { get; set; }



    }
}
