using System;

public class SimpleMathExam : Exam
{
    private const int MinProblemsSolved = 0;
    private const int MaxProblemsSolved = 10;
    private const int AverageProblemsSolved = 5;
    private const int WorstGrade = 2;
    private const int AverageGrade = 4;
    private const int BestGrade = 6;
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
            if (value < SimpleMathExam.MinProblemsSolved ||
                value > SimpleMathExam.MaxProblemsSolved)
            {
                throw new ArgumentOutOfRangeException(string.Format("problemsSolved must be in the range [{0}:{1}]", this.GetType(), MinProblemsSolved, MaxProblemsSolved));
            }

            this.problemsSolved = value;
        }
    }

    public override ExamResult Check()
    {
        if (this.ProblemsSolved == SimpleMathExam.MinProblemsSolved)
        {
            return new ExamResult(SimpleMathExam.WorstGrade, SimpleMathExam.WorstGrade, SimpleMathExam.BestGrade, "Bad result: nothing done.");
        }
        else if (this.ProblemsSolved <= SimpleMathExam.AverageProblemsSolved)
        {
            return new ExamResult(SimpleMathExam.AverageGrade, SimpleMathExam.WorstGrade, SimpleMathExam.BestGrade, "Average result: good.");
        }
        else
        {
            return new ExamResult(SimpleMathExam.BestGrade, SimpleMathExam.WorstGrade, SimpleMathExam.BestGrade, "Very good result: well done.");
        }
    }
}
