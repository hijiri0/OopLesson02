// ■リスト12-8：Bookクラス
class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Pages { get; set; }
    public int Rating { get; set; }
    public Book(string title, string author, int pages, int rating)
    {
        Title = title;
        Author = author;
        Pages = pages;
        Rating = rating;
    }
}
