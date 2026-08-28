namespace Student_Grade_System
{
    public class Grade
    {
        public void PrintGrade(string studentName, int grade)
        {
            Console.WriteLine($"Student: {studentName}");
            Console.WriteLine($"Grade: {grade}"); 
        }

        public void PrintGradeStatus()
        {
            Console.WriteLine("Status: Passed");
        }
    }
}
