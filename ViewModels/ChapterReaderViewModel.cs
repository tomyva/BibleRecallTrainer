using BibleRecallTrainer.Models;
using BibleRecallTrainer.Services;
namespace BibleRecallTrainer.ViewModels;
public sealed class ChapterReaderViewModel(IBibleContentService content) : ViewModelBase { private Chapter? _chapter; public Chapter? Chapter { get => _chapter; private set { _chapter = value; OnPropertyChanged(); OnPropertyChanged(nameof(Title)); } } public string Title => Chapter is null ? "Chapter" : $"{Chapter.Book} {Chapter.Number}"; public async Task LoadAsync(string book, int number) => Chapter = await content.GetChapterAsync(book, number); }
