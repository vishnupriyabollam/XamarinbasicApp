using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var books = GetMockBooks();
            BookListView.ItemsSource = books;

        }
        List<BookModel> GetMockBooks()
        {
            var books = new List<BookModel>();
            books.Add(new BookModel()
            {
                BookName = "Name : The American novel Ship",
                Author = "Author : Paulo",
                Price = "Price: 500",
                Rating = "Rating : 3",
                Bookimage = "Novel1.jpg",
                Summary = "the ending will be happy",
            });

            books.Add(new BookModel()
            {
                BookName = "Name :Moon Hunt",
                Author = "Author :Stephen hocking",
                Price = "Rating : 451",
                Rating = "Rating 0",
                Bookimage = "Novel2.jpg",
                Summary = "the girl who tries to achieve her goals",
            });
            books.Add(new BookModel()
            {
                BookName = "Name :Lost Kingdom",
                Author = "Author  :Madrid",
                Price = "Price    :63",
                Rating = " Rating  :2",
                Bookimage = "Novel3.jpg",
                Summary = "Never be greedy to donate to poor",
            });
            return books;
        }
        private void BookListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedBook = e.SelectedItem as BookModel;
            Navigation.PushAsync(new BookDetails(selectedBook));
        }
    }
    
}
