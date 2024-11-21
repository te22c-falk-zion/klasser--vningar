using System.Reflection.Metadata.Ecma335;

public class book(string n, int p) 
{
    private int pages = p;
    private string name = n;

    private int currentPage = 0;

    public void turnpage()
    {
        currentPage++;
    }

    public int GetCurrentPage()
    {
        return currentPage;
    }
    public string GetName()
    {
        return name;
    }
    public int GetPages()
    {
        return pages;
    }
}