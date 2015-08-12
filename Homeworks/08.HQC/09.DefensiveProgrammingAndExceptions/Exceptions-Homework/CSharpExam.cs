using System;

public class CSharpExam : Exam
{
    private const int MinGrade = 0;
    private const int MaxGrade = 100;
    private int score;

    public CSharpExam(int score)
    {
        this.Score = score;
    }

    public int Score
    {
        get
        {
            return this.score;
        }

        set
        {
            if (value < CSharpExam.MinGrade || value > CSharpExam.MaxGrade)
            {
                throw new ArgumentOutOfRangeException(string.Format("{0} score must be in the range [{1}:{2}]", this.GetType(), CSharpExam.MinGrade, CSharpExam.MaxGrade));
            }

            this.score = value;
        }
    }

    public override ExamResult Check()
    {
        if (this.Score < 0 || this.Score > 100)
        {
            throw new InvalidOperationException("check cannot be done, CSharp score is out of range");
        }
        else
        {
            return new ExamResult(this.Score, CSharpExam.MinGrade, CSharpExam.MaxGrade, "Exam results calculated by score.");
        }
    }
}
