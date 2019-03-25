namespace DIP
{
    public interface IChore
    {
        string Chorename { get; set; }
        int HoursWorked { get; set; }
        bool IsComplete { get; set; }
        IPerson Owner { get; set; }

        void CompleteChore();
        void PerfomedWord(int hours);
    }
}