using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name,bool IsWeighted) : base(name, IsWeighted)
        {
            Type = GradeBookType.Ranked;
        }
        public override void CalculateStatistics()
        {
            if (Students.Count >= 5)
                base.CalculateStatistics();
            else if (Students.Count < 5)
                Console.WriteLine("Ranked grading requires at least 5 students.");
        }
        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count >= 5)
                base.CalculateStudentStatistics(name);
            else if (Students.Count < 5)
                Console.WriteLine("Ranked grading requires at least 5 students.");
            
        }
        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
            {
                throw new System.InvalidOperationException("Students number less than 5");
            }
            if (averageGrade >= 80)
                return 'A';
            else if (averageGrade < 80 && averageGrade >= 60)
                return 'B';
            else if (averageGrade >= 40 && averageGrade < 60)
                return 'C';
            else if (averageGrade >= 20 && averageGrade < 40)
                return 'D';
            else
                return 'F';
        }
    }
}
