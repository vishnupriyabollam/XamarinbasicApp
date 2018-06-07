using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BookDetails : ContentPage
	{
        private BookModel Book_Selected { get; set; }
        public BookDetails (BookModel SelectedBook)
        {
            InitializeComponent();
            Book_Selected = SelectedBook;
            image.Source = Book_Selected.Bookimage;
            title.Text = Book_Selected.BookName;
            Author.Text = Book_Selected.Author;
            Summary.Text = Book_Selected.Summary;

        }
        public void BuyToClick(object sender,EventArgs args)
        {
            DisplayAlert("alert", "No stock available right now","ok");
        }

    }
}