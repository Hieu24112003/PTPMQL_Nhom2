public class GradeModel
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }

    public double FinalScore => (A * 0.6) + (B * 0.3) + (C * 0.1);

    public string GetGrade()
    {
        if (FinalScore >= 8.5) return "A (Xuất sắc)";
        if (FinalScore >= 7.0) return "B (Khá)";
        if (FinalScore >= 5.5) return "C (Trung bình)";
        if (FinalScore >= 4.0) return "D (Yếu)";
        return "F (Kém)";
    }
}