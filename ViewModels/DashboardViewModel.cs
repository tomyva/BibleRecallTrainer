using System.Windows.Input;
namespace BibleRecallTrainer.ViewModels;
public sealed class DashboardViewModel : ViewModelBase { public string DayLabel => "Day 1 of 10"; public int TotalChapters => 35; public int Mastered => 0; public int Learning => 0; public int NotStarted => 35; public ICommand LearnCommand { get; } = new Command(async () => await Shell.Current.GoToAsync(nameof(Views.BooksPage))); }
