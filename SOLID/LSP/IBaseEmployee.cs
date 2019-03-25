namespace LSP
{
    public interface IBaseEmployee
    {
        string Firstname { get; set; }
        string Lastname { get; set; }
        int Salary { get; set; }

        int CalculateSalaryPerHour();
    }
}