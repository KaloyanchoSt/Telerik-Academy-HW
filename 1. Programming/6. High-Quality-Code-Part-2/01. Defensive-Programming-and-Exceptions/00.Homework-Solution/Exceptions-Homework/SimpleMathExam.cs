namespace Exceptions_Homework
{
    using System;
    using System.Collections.Generic;

    public class SimpleMathExam : Exam
    {
        private const int MinimumProblemsSolvedPerExam = 0;
        private const int MaximumProblemsSolvedPerExam = 10;
        private int problemsSolved;

        public SimpleMathExam(int problemsSolved)
        {
            this.ProblemsSolved = problemsSolved;
        }

        public int ProblemsSolved
        {
            get
            {
                return this.problemsSolved;
            }

            private set
            {
                if (value < MinimumProblemsSolvedPerExam)
                {
                    throw new ArgumentOutOfRangeException("You cannot solve less than 0 problems!");
                }

                if (value > MaximumProblemsSolvedPerExam)
                {
                    throw new ArgumentOutOfRangeException("You cannot solve more than 10 problems!");
                }

                this.problemsSolved = value;
            }
        }

        public override ExamResult Check()
        {
            var comments = new Dictionary<int, string>()
            {
                { 0, "Bad result: nothing done." },
                { 1, "Low result: almost nothing done." },
                { 2, "Low result: you have to work harder" },
                { 3, "Low result: nothing done." },
                { 4, "Average result: almost nothing done." },
                { 5, "Average result: some exercises are done." },
                { 6, "Average result: more than half exercises are done." },
                { 7, "Good result: more than half exercises are done." },
                { 8, "Very good result: almost all of the exercises are done." },
                { 9, "Very good result: almost all of the exercises are done." },
                { 10, "Excellent result!!! All of the exercises are done!" },
            };

            var examResult = new ExamResult(this.ProblemsSolved, MinimumProblemsSolvedPerExam, MaximumProblemsSolvedPerExam, comments[this.ProblemsSolved]);

            return examResult;
        }
    }
}