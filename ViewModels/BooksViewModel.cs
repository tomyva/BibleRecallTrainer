using System.Windows.Input;
namespace BibleRecallTrainer.ViewModels;
public sealed class BooksViewModel : ViewModelBase { public ICommand OpenRuthCommand { get; } = new Command(async () => await Shell.Current.GoToAsync($"{nameof(Views.ChapterReaderPage)}?book=Ruth&chapter=1")); }
