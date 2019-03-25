namespace ISP
{
    public interface IBook: ILibraryItem
    {
        string Author { get; set; }
        int Pages { get; set; }
    }
}