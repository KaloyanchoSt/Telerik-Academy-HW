namespace Exceptions_Homework
{
    using System;

    public class ExamResult
    {
        private int grade;
        private int minGrade;
        private int maxGrade;
        private string comments;

        public ExamResult(int grade, int minGrade, int maxGrade, string comments)
        {
            this.Grade = grade;
            this.MinGrade = minGrade;
            this.MaxGrade = maxGrade;
            this.Comments = comments;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }
            private set
            {
                if (value < this.MinGrade || value > this.MaxGrade)
                {
                    throw new ArgumentOutOfRangeException(string.Format("Grade cannot be grater than {0} or less than {1}!", this.MaxGrade, this.MinGrade));
                }

                this.grade = value;
            }
        }

        public int MinGrade
        {
            get
            {
                return this.minGrade;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Min grade cannot be less than 0");
                }

                this.minGrade = value;
            }
        }

        public int MaxGrade
        {
            get
            {
                return this.maxGrade;
            }
            private set
            {
                if (value <= this.MinGrade)
                {
                    throw new ArgumentOutOfRangeException("MaxGrade cannot be less or equal to MinGrade!");
                }

                this.maxGrade = value;
            }
        }

        public string Comments
        {
            get
            {
                return this.comments;
            }

            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Comment cannot be null or empty");
                }

                this.comments = value;
            }
        }
    }
}