using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using Fisher.Bookstore.Pages;
using System.Collections.Generic;

namespace Fisher.Bookstore.Pages
{
    public class Book
    {
        public int BookId { get; set; }

        public string Title { get; set; }

        public Author Author { get; set; }

        public void SellBook()
        {
            //code to sell book goes here
        }
    }
    public class Books : PageModel
    {
        public List<Book> books;
        
        public IEnumerable<Book> OnGet()
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
        return books;
        }
    }
}