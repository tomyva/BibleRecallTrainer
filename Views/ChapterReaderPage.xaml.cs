using BibleRecallTrainer.ViewModels;
namespace BibleRecallTrainer.Views;
public partial class ChapterReaderPage : ContentPage, IQueryAttributable { private readonly ChapterReaderViewModel _vm; public ChapterReaderPage(ChapterReaderViewModel vm) { InitializeComponent(); BindingContext = _vm = vm; } public async void ApplyQueryAttributes(IDictionary<string, object> query) { var book = query["book"]?.ToString() ?? "Ruth"; _ = int.TryParse(query["chapter"]?.ToString(), out var chapter); await _vm.LoadAsync(book, chapter == 0 ? 1 : chapter); } }
