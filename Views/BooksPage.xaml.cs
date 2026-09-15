using BibleRecallTrainer.ViewModels;
namespace BibleRecallTrainer.Views;
public partial class BooksPage : ContentPage { public BooksPage(BooksViewModel vm) { InitializeComponent(); BindingContext = vm; } }
