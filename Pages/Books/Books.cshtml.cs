using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using Fisher.Bookstore.Models;

    
namespace Fisher.Bookstore.Pages
{
    
    public class Books : PageModel
    {
        

        public class Book
    {
        public int BookId { get; set; }

        public string Title { get; set; }

        public Author Author {get; set; }

        public void SellBook()
        {
            //code to sell book goes here
        }

    }
        public List<Book> books;
        
        public void OnGet()
        {
            books = new List<Book>();

            books.Add(new Book()
            {
                Title = "Continous Delivery",
                Author = new Author() {Name = "Jez Humble"}});
            
            books.Add(new Book()
            {
                Title = "Lean Enterprise",
                Author = new Author() {Name = "Barry O'Reilly"}});
            
            books.Add(new Book()
            {
                Title = "The Goal",
                Author = new Author() {Name = "Eliyahu Goldratt"}});

        
        }
    }
}
