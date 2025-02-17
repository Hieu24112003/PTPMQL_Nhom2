public class Test
{
    public double Weight { get; set; } // Cân nặng (kg)
    public double Height { get; set; } // Chiều cao (m)
    public double BMI => Weight / (Height * Height); // Công thức tính BMI
}