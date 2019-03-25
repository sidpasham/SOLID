namespace DIP
{
    public interface IChore
    {
        string Chorename { get; set; }
        int HoursWorked { get; set; }
        bool IsComplete { get; set; }
        IPerson Owner { get; set; }

        void CompleteChore(string email);
        void PerfomedWord(int hours);
    }
}