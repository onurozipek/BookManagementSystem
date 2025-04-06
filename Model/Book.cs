using System.Runtime.InteropServices.JavaScript;

namespace BookManagementSystem.Data;

public class Books
{
    public int Id { get; set; }
   
    public string Title { get; set; }
    
    public string Author { get; set; }
    
    public DateTime PublishedYear { get; set; }
}