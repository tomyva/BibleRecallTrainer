using BibleRecallTrainer.ViewModels;
namespace BibleRecallTrainer.Views;
public partial class DashboardPage : ContentPage { public DashboardPage(DashboardViewModel vm) { InitializeComponent(); BindingContext = vm; } }
