namespace BibleRecallTrainer;

public partial class AppShell : Shell { public AppShell(IServiceProvider services, Views.DashboardPage dashboard) { InitializeComponent(); Items[0].Items[0].Content = dashboard; Routing.RegisterRoute(nameof(Views.BooksPage), new ServiceRouteFactory(services, typeof(Views.BooksPage))); Routing.RegisterRoute(nameof(Views.ChapterReaderPage), new ServiceRouteFactory(services, typeof(Views.ChapterReaderPage))); } }
